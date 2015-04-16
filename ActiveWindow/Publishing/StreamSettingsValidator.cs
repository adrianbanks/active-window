using ActiveWindow.Settings.User;

namespace ActiveWindow.Publishing
{
    internal sealed class StreamSettingsValidator
    {
        private readonly UserSettings settings;

        public StreamSettingsValidator(UserSettings settings)
        {
            this.settings = settings;
        }

        public bool RelevantSettingsPresent()
        {
            return !string.IsNullOrWhiteSpace(settings.StreamId)
                   && !string.IsNullOrWhiteSpace(settings.WriteToken);
        }
    }
}
