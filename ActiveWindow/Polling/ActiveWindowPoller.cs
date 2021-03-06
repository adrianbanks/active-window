﻿using System;
using System.Linq;
using ActiveWindow.Publishing;
using ActiveWindow.Settings.Application;
using ActiveWindow.Settings.User;
using ActiveWindow.Windows;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace ActiveWindow.Polling
{
    internal sealed class ActiveWindowPoller
    {
        private readonly ApplicationSettings applicationSettings;
        private readonly UserSettings userSettings;
        private readonly EventPublisher eventPublisher;
        private readonly ForegroundWindowInfoFactory foregroundWindowInfoFactory;
        private readonly ForegroundWindowInfoEqualityComparer equalityComparer;

        private ForegroundWindowInfo previousActiveWindow;
        private DateTime? sessionLockedAt;

        public ActiveWindowPoller(ApplicationSettings applicationSettings, UserSettings userSettings, EventPublisher eventPublisher, ForegroundWindowInfoFactory foregroundWindowInfoFactory, ForegroundWindowInfoEqualityComparer equalityComparer)
        {
            this.applicationSettings = applicationSettings;
            this.userSettings = userSettings;
            this.eventPublisher = eventPublisher;
            this.foregroundWindowInfoFactory = foregroundWindowInfoFactory;
            this.equalityComparer = equalityComparer;
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        public void Poll()
        {
            if (sessionLockedAt.HasValue)
            {
                return;
            }

            var foregroundWindowInfo = foregroundWindowInfoFactory.Create();

            if (userSettings.SendActiveWindowEvents && !equalityComparer.Equals(foregroundWindowInfo, previousActiveWindow))
            {
                var objectTags = applicationSettings.WindowEventObjectTags.Cast<object>().ToArray();
                var actionTags = applicationSettings.WindowEventActionTags.Cast<object>().ToArray();
                eventPublisher.PublishEvent(objectTags, actionTags, properties => SetApplicablePropertyValues(properties, foregroundWindowInfo));
                previousActiveWindow = foregroundWindowInfo;
            }
        }

        private void SetApplicablePropertyValues(JObject properties, ForegroundWindowInfo foregroundWindowInfo)
        {
            if (!string.IsNullOrWhiteSpace(foregroundWindowInfo.Path))
            {
                properties[applicationSettings.WindowEventProcessPropertyName] = foregroundWindowInfo.Path;
            }

            properties[applicationSettings.WindowEventTitlePropertyName] = foregroundWindowInfo.WindowTitle;
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            previousActiveWindow = null;

            var objectTags = applicationSettings.SessionEventObjectTags.Cast<object>().ToArray();

            if (e.Reason == SessionSwitchReason.SessionLock || e.Reason == SessionSwitchReason.RemoteDisconnect || e.Reason == SessionSwitchReason.ConsoleDisconnect)
            {
                sessionLockedAt = DateTime.Now;

                if (userSettings.SendLockEvents)
                {
                    var actionTags = applicationSettings.SessionEventLockedActionTags.Cast<object>().ToArray();
                    eventPublisher.PublishEvent(objectTags, actionTags, properties => { });
                }
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock || e.Reason == SessionSwitchReason.RemoteConnect || e.Reason == SessionSwitchReason.ConsoleConnect)
            {
                var lockedDuration = DateTime.Now - sessionLockedAt;
                sessionLockedAt = null;

                if (userSettings.SendLockEvents)
                {
                    var actionTags = applicationSettings.SessionEventUnlockedActionTags.Cast<object>().ToArray();
                   eventPublisher.PublishEvent(objectTags, actionTags, properties => properties["duration"] = lockedDuration.ToString());
                }
            }
        }
    }
}
