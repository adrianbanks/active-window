namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettingsSaver
    {
        public void Save(UserSettings settings)
        {
            var defaultSettings = Properties.Settings.Default;
            defaultSettings.oneSelf_StreamId = settings.StreamId;
            defaultSettings.oneSelf_WriteToken = settings.WriteToken;
            defaultSettings.sendLockEvents = settings.SendLockEvents;
            defaultSettings.sendActiveWindowEvents = settings.SendActiveWindowEvents;
            defaultSettings.pollingInterval_Seconds = settings.PollingIntervalInSeconds;
            defaultSettings.Save();
        }
    }
}
