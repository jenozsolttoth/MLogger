using MLogger.Entities;

namespace MLogger
{
    public interface ILogger
    {
        void Log(ILogObject logObject);
    }
}
