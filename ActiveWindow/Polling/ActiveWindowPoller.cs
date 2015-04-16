using ActiveWindow.Publishing;
using ActiveWindow.Settings.Application;
using ActiveWindow.Windows;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace ActiveWindow.Polling
{
    internal sealed class ActiveWindowPoller
    {
        private readonly ApplicationSettings applicationSettings;
        private readonly EventPublisher eventPublisher;
        private readonly ForegroundWindowInfoFactory foregroundWindowInfoFactory;
        private readonly ForegroundWindowInfoEqualityComparer equalityComparer;

        private ForegroundWindowInfo previousActiveWindow;
        private bool isComputerLocked;

        public ActiveWindowPoller(ApplicationSettings applicationSettings, EventPublisher eventPublisher, ForegroundWindowInfoFactory foregroundWindowInfoFactory, ForegroundWindowInfoEqualityComparer equalityComparer)
        {
            this.applicationSettings = applicationSettings;
            this.eventPublisher = eventPublisher;
            this.foregroundWindowInfoFactory = foregroundWindowInfoFactory;
            this.equalityComparer = equalityComparer;
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        public void Poll()
        {
            if (isComputerLocked)
            {
                return;
            }

            var foregroundWindowInfo = foregroundWindowInfoFactory.Create();

            if (!equalityComparer.Equals(foregroundWindowInfo, previousActiveWindow))
            {
                eventPublisher.PublishEvent(properties => SetApplicablePropertyValues(properties, foregroundWindowInfo));
                previousActiveWindow = foregroundWindowInfo;
            }
        }

        private void SetApplicablePropertyValues(JObject properties, ForegroundWindowInfo foregroundWindowInfo)
        {
            if (!string.IsNullOrWhiteSpace(foregroundWindowInfo.Path))
            {
                properties[applicationSettings.ProcessPropertyName] = foregroundWindowInfo.Path;
            }

            properties[applicationSettings.TitlePropertyName] = foregroundWindowInfo.WindowTitle;
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            previousActiveWindow = null;

            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                isComputerLocked = true;
                eventPublisher.PublishEvent(properties => properties[applicationSettings.TitlePropertyName] = applicationSettings.SessionLockedMessage);
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                isComputerLocked = false;
                eventPublisher.PublishEvent(properties => properties[applicationSettings.TitlePropertyName] = applicationSettings.SessionUnlockedMessage);
            }
        }
    }
}
