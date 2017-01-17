using System;
using System.Net.Http;
using System.Net.Http.Headers;
using ActiveWindow.Settings.Application;
using ActiveWindow.Settings.User;
using Newtonsoft.Json.Linq;
using NLog;

namespace ActiveWindow.Publishing
{
    internal sealed class EventPublisher
    {
        private readonly Logger applicationLogger;
        private readonly Logger dataLogger;
        private readonly ApplicationSettings applicationSettings;
        private readonly UserSettings userSettings;
        private readonly StreamSettingsValidator streamSettingsValidator;
        private int eventCount;

        public EventPublisher(Logger applicationLogger, Logger dataLogger, ApplicationSettings applicationSettings, UserSettings userSettings, StreamSettingsValidator streamSettingsValidator)
        {
            this.applicationLogger = applicationLogger;
            this.dataLogger = dataLogger;
            this.applicationSettings = applicationSettings;
            this.userSettings = userSettings;
            this.streamSettingsValidator = streamSettingsValidator;
        }

        public void PublishEvent(object[] objectTags, object[] actionTags, Action<JObject> setPropertiesCallback)
        {
            if (!streamSettingsValidator.RelevantSettingsPresent())
            {
                applicationLogger.Info("Not publishing event - stream properties not set");
                return;
            }

            applicationLogger.Info("Publishing event ({0})...", ++eventCount);

            JObject properties = new JObject();
            setPropertiesCallback(properties);

            var activityEvent = new JObject
            {
                ["dateTime"] = DateTime.Now.ToString("o"),
                ["objectTags"] = new JArray(objectTags),
                ["actionTags"] = new JArray(actionTags),
                ["properties"] = properties
            };

            var url = string.Format(applicationSettings.PublishingUrlFormat, userSettings.StreamId);

            var content = new StringContent(activityEvent.ToString(Newtonsoft.Json.Formatting.None));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            applicationLogger.Debug("Activity event being published: {0}", activityEvent.ToString());

            var client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", userSettings.WriteToken);

            applicationLogger.Info("Publishing activity event to {0}", url);
            dataLogger.Info(activityEvent.ToString());

            client.PostAsync(url, content).ContinueWith(postTask =>
            {
                try
                {
                    applicationLogger.Info("Event published successfully. Result: {0}", postTask.Result.StatusCode);
                }
                catch (Exception exception)
                {
                    applicationLogger.Info("Error publishing event", exception);
                }
            });
        }
    }
}
