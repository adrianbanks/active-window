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
        private readonly Logger logger;
        private readonly ApplicationSettings applicationSettings;
        private readonly UserSettings userSettings;
        private readonly StreamSettingsValidator streamSettingsValidator;
        private int eventCount;

        public EventPublisher(Logger logger, ApplicationSettings applicationSettings, UserSettings userSettings, StreamSettingsValidator streamSettingsValidator)
        {
            this.logger = logger;
            this.applicationSettings = applicationSettings;
            this.userSettings = userSettings;
            this.streamSettingsValidator = streamSettingsValidator;
        }

        public void PublishEvent(object[] objectTags, object[] actionTags, Action<JObject> setPropertiesCallback)
        {
            if (!streamSettingsValidator.RelevantSettingsPresent())
            {
                logger.Info("Not publishing event - stream properties not set");
                return;
            }

            logger.Info("Publishing event ({0})...", ++eventCount);

            var activityEvent = new JObject();
            activityEvent["dateTime"] = DateTime.Now.ToString("o");
            activityEvent["objectTags"] = new JArray(objectTags);
            activityEvent["actionTags"] = new JArray(actionTags);

            JObject properties = new JObject();
            setPropertiesCallback(properties);
            activityEvent["properties"] = properties;

            var url = string.Format(applicationSettings.PublishingUrlFormat, userSettings.StreamId);

            var content = new StringContent(activityEvent.ToString(Newtonsoft.Json.Formatting.None));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            logger.Debug("Activity event being published: {0}", activityEvent.ToString());

            var client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", userSettings.WriteToken);

            logger.Info("Publishing activity event to {0}", url);

            client.PostAsync(url, content).ContinueWith(postTask =>
            {
                try
                {
                    logger.Info("Event published successfully. Result: {0}", postTask.Result.StatusCode);
                }
                catch (Exception exception)
                {
                    logger.Info("Error publishing event", exception);
                }
            });
        }
    }
}
