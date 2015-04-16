namespace ActiveWindow.Settings.User
{
    internal sealed class UserSettingsSaver
    {
        public void Save(UserSettings settings)
        {
            var defaultSettings = Properties.Settings.Default;
            defaultSettings.oneSelf_StreamId = settings.StreamId;
            defaultSettings.oneSelf_WriteToken = settings.WriteToken;
            defaultSettings.pollingInterval_Seconds = settings.PollingIntervalInSeconds;
            defaultSettings.location_latitude = settings.Latitude;
            defaultSettings.location_longitude = settings.Longitude;
            defaultSettings.Save();
        }
    }
}
