using System;
using System.Windows.Forms;
using ActiveWindow.Polling;
using ActiveWindow.Settings.Application;
using ActiveWindow.Settings.User;
using ActiveWindow.Windows;

namespace ActiveWindow
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            var userSettings = new UserSettingsLoader().Load();
            StartPolling(userSettings);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm(new UserSettingsSaver(), userSettings);
            Application.Run(mainForm);
        }

        private static void StartPolling(UserSettings userSettings)
        {
            var applicationSettings = new ApplicationSettingsLoader().Load();

            var logger = new LoggerFactory().GetLogger();
            var eventPublisher = new EventPublisher(logger, applicationSettings, userSettings);
            var poller = new ActiveWindowPoller(applicationSettings, eventPublisher, new ForegroundWindowInfoFactory());

            WindowPolling.Start(userSettings, poller);
        }
    }
}
