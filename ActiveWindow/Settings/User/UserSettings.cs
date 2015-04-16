namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettings
    {
        public string StreamId { get; set; }
        public string WriteToken { get; set; }

        public int PollingIntervalInSeconds { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
