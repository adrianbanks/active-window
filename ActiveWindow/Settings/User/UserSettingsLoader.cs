namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettingsLoader
    {
        public UserSettings Load()
        {
            var defaultSettings = Properties.Settings.Default;

            return new UserSettings
            {
                StreamId = defaultSettings.oneSelf_StreamId,
                WriteToken = defaultSettings.oneSelf_WriteToken,
                PollingIntervalInSeconds = defaultSettings.pollingInterval_Seconds
            };
        }
    }
}
