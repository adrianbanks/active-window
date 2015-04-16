using System;
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
            PostInitializeComponent();

            this.settingsSaver = settingsSaver;

            streamIdTextBox.Text = settings.StreamId;
            writeTokenTextBox.Text = settings.WriteToken;
            pollingIntervalNumericUpDown.Value = settings.PollingIntervalInSeconds;
            latitudeTextBox.Text = settings.Latitude;
            longitudeTextBox.Text = settings.Longitude;
        }

        private void PostInitializeComponent()
        {
            notifyIcon.Text = this.Text;
            optionsMenuItem.Click += optionsMenuItem_Click;
            exitMenuItem.Click += exitMenuItem_Click;
        }

        private void saveButton_Click(object sender, EventArgs e)
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

        private void locateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void optionsMenuItem_Click(object sender, EventArgs args)
        {
            if (!Visible)
            {
                this.ShowInTaskbar = true;
            }

            Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs args)
        {
            Application.Exit();
        }
    }
}
