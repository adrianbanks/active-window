using NLog;

namespace ActiveWindow
{
    public class LoggerFactory
    {
        public Logger GetLogger()
        {
            return LogManager.GetLogger("default");
        }
    }
}
