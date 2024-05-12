using BtkAkademi.Business.Concrete;
using NLog;

namespace BtkAkademi.Business
{
    public class LoggerManager : ILoggerServices
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message) => logger.Debug(message);

        public void LogError(string message) => logger.Error(message);

        public void LogInfo(string message) => logger.Info(message);

        public void LogWarnin(string message) => logger.Warn(message);
    }
}
