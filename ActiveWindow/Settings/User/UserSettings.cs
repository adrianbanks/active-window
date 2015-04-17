namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettings
    {
        public string StreamId { get; set; }
        public string WriteToken { get; set; }

        public int PollingIntervalInSeconds { get; set; }
    }
}
