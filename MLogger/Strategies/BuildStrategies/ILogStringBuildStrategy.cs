
using MLogger.Entities;

namespace MLogger.Strategies.BuildStrategies
{
    public interface ILogStringBuildStrategy
    {
        string BuildLogString(ILogObject logObject);
    }
}
