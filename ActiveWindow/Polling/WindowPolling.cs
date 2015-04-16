using System.Threading;
using ActiveWindow.Settings.User;

namespace ActiveWindow.Polling
{
    internal static class WindowPolling
    {
        private static Timer timer;

        public static void Start(UserSettings settings, ActiveWindowPoller poller)
        {
            int pollingIntervalInMilliseconds = settings.PollingIntervalInSeconds * 1000;
            timer = new Timer(_ => poller.Poll(), null, 0, pollingIntervalInMilliseconds);
        }
    }
}
