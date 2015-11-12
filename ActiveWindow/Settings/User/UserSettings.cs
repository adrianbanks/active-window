namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettings
    {
        public string StreamId { get; set; }
        public string WriteToken { get; set; }

        public bool SendLockEvents { get; set; }
        public bool SendActiveWindowEvents { get; set; }

        public int PollingIntervalInSeconds { get; set; }
    }
}
