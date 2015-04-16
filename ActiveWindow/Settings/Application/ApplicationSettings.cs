namespace ActiveWindow.Settings.Application
{
    internal sealed class ApplicationSettings
    {
        public string PublishingUrlFormat { get; set; }

        public string TitlePropertyName { get; set; }
        public string ProcessPropertyName { get; set; }

        public string SessionLockedMessage { get; set; }
        public string SessionUnlockedMessage { get; set; }

        public string[] ObjectTags { get; set; }
        public string[] ActionTags { get; set; }
    }
}
