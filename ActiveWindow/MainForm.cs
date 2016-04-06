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

            Application.Idle += Application_Idle;

            this.settingsSaver = settingsSaver;

            streamIdTextBox.Text = settings.StreamId;
            writeTokenTextBox.Text = settings.WriteToken;
            sendLockEventsCheckBox.Checked = settings.SendLockEvents;
            sendActiveWindowEventsCheckBox.Checked = settings.SendActiveWindowEvents;
            pollingIntervalNumericUpDown.Value = settings.PollingIntervalInSeconds;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            pollingIntervalPanel.Enabled = sendActiveWindowEventsCheckBox.Checked;
        }

        private void PostInitializeComponent()
        {
            notifyIcon.Text = Text;
            optionsMenuItem.Click += optionsMenuItem_Click;
            exitMenuItem.Click += exitMenuItem_Click;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void optionsMenuItem_Click(object sender, EventArgs args)
        {
            ShowWindow();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideWindow();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void SaveSettings()
        {
            var settings = new UserSettings
            {
                StreamId = streamIdTextBox.Text,
                WriteToken = writeTokenTextBox.Text,
                SendLockEvents = sendLockEventsCheckBox.Checked,
                SendActiveWindowEvents = sendActiveWindowEventsCheckBox.Checked,
                PollingIntervalInSeconds = (int) pollingIntervalNumericUpDown.Value
            };

            settingsSaver.Save(settings);
        }

        private void HideWindow()
        {
            Hide();
            ShowInTaskbar = false;
        }

        private void ShowWindow()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Show();
            ShowInTaskbar = true;
        }
    }
}
