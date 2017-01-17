using NLog;

namespace ActiveWindow
{
    public class LoggerFactory
    {
        public Logger GetApplicationLogger()
        {
            return LogManager.GetLogger("application");
        }

        public Logger GetDataLogger()
        {
            return LogManager.GetLogger("data");
        }
    }
}
