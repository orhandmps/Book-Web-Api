namespace BtkAkademi.Business.Concrete
{
    public interface ILoggerServices
    {
        void LogInfo(string message);
        void LogWarnin(string message);
        void LogError(string message);
        void LogDebug(string message);
    }
}
