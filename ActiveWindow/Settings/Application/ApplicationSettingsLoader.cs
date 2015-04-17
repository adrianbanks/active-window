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

                WindowEventObjectTags = GetTags(appSettings, "1selfEvent_WindowEvent_ObjectTags"),
                WindowEventActionTags = GetTags(appSettings, "1selfEvent_WindowEvent_ActionTags"),
                WindowEventTitlePropertyName = appSettings["1selfEvent_WindowEventTitlePropertyName"],
                WindowEventProcessPropertyName = appSettings["1selfEvent_WindowEventProcessPropertyName"],

                SessionEventObjectTags = GetTags(appSettings, "1selfEvent_SessionEvent_ObjectTags"),
                SessionEventLockedActionTags = GetTags(appSettings, "1selfEvent_SessionEvent_Locked_ActionTags"),
                SessionEventUnlockedActionTags = GetTags(appSettings, "1selfEvent_SessionEvent_Unlocked_ActionTags")
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
