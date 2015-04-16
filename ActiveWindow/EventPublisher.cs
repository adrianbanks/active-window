using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using ActiveWindow.Settings.Application;
using ActiveWindow.Settings.User;
using Newtonsoft.Json.Linq;
using NLog;

namespace ActiveWindow
{
    internal sealed class EventPublisher
    {
        private readonly Logger logger;
        private readonly ApplicationSettings applicationSettings;
        private readonly UserSettings userSettings;

        public EventPublisher(Logger logger, ApplicationSettings applicationSettings, UserSettings userSettings)
        {
            this.logger = logger;
            this.applicationSettings = applicationSettings;
            this.userSettings = userSettings;
        }

        public void PublishEvent(Action<JObject> setPropertiesCallback)
        {
            logger.Info("Publishing event...");

            var activityEvent = new JObject();
            activityEvent["dateTime"] = DateTime.Now.ToString("o");
            activityEvent["objectTags"] = new JArray(applicationSettings.ObjectTags.Cast<object>().ToArray());
            activityEvent["actionTags"] = new JArray(applicationSettings.ActionTags.Cast<object>().ToArray());

            SetLocation(activityEvent);

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

        private void SetLocation(JObject activityEvent)
        {
            if (!string.IsNullOrWhiteSpace(userSettings.Latitude)
                && !string.IsNullOrWhiteSpace(userSettings.Longitude))
            {
                var location = new JObject();
                location["lat"] = userSettings.Latitude;
                location["long"] = userSettings.Longitude;
                activityEvent["location"] = location;
            }
        }
    }
}
