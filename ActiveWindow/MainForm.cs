using System.Windows.Forms;
using ActiveWindow.Settings.User;

namespace ActiveWindow
{
    internal partial class MainForm : Form
    {
        private readonly UserSettingsSaver settingsSaver;

        public MainForm(UserSettingsSaver settingsSaver, UserSettings settings)
        {
            InitializeComponent();
            this.settingsSaver = settingsSaver;

            streamIdTextBox.Text = settings.StreamId;
            writeTokenTextBox.Text = settings.WriteToken;
            pollingIntervalNumericUpDown.Value = settings.PollingIntervalInSeconds;
            latitudeTextBox.Text = settings.Latitude;
            longitudeTextBox.Text = settings.Longitude;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            var settings = new UserSettings
            {
                StreamId = streamIdTextBox.Text,
                WriteToken = writeTokenTextBox.Text,
                PollingIntervalInSeconds = (int) pollingIntervalNumericUpDown.Value,
                Latitude = latitudeTextBox.Text,
                Longitude = longitudeTextBox.Text
            };

            settingsSaver.Save(settings);
        }

        private void locateButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
