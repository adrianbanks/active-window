using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace ActiveWindow.Settings.Application
{
    internal sealed class ApplicationSettingsLoader
    {
        public ApplicationSettings Load()
        {
            var appSettings = ConfigurationManager.AppSettings;

            return new ApplicationSettings
            {
                PublishingUrlFormat = appSettings["1selfEvent_PublishingUrlFormat"],
                ProcessPropertyName = appSettings["1selfEvent_ProcessPropertyName"],
                TitlePropertyName = appSettings["1selfEvent_TitlePropertyName"],
                SessionLockedMessage = appSettings["1selfEvent_SessionLockedMessage"],
                SessionUnlockedMessage = appSettings["1selfEvent_SessionUnlockedMessage"],
                ObjectTags = GetTags(appSettings, "1selfEvent_ObjectTags"),
                ActionTags = GetTags(appSettings, "1selfEvent_ActionTags")
            };
        }

        private string[] GetTags(NameValueCollection appSettings, string key)
        {
            string setting = appSettings[key];
            string[] tags = setting.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return tags.Select(tag => tag.Trim()).ToArray();
        }
    }
}
