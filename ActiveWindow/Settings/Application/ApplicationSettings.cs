namespace ActiveWindow.Settings.Application
{
    internal sealed class ApplicationSettings
    {
        public string PublishingUrlFormat { get; set; }

        public string[] WindowEventObjectTags { get; set; }
        public string[] WindowEventActionTags { get; set; }
        public string WindowEventTitlePropertyName { get; set; }
        public string WindowEventProcessPropertyName { get; set; }

        public string[] SessionEventObjectTags { get; set; }
        public string[] SessionEventLockedActionTags { get; set; }
        public string[] SessionEventUnlockedActionTags { get; set; }
    }
}
