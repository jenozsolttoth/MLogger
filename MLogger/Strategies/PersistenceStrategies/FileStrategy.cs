using MLogger.Entities;
using MLogger.FileStore;
using MLogger.Strategies.BuildStrategies;

namespace MLogger.Strategies.PersistenceStrategies
{
    public class FileStrategy : IPersistenceStrategy
    {
        private readonly ILogStringBuildStrategy _logStringBuildStrategy;
        private readonly ILogFileWriter _logFileWriter;
        public FileStrategy(ILogStringBuildStrategy logStringBuildStrategy, ILogFileWriter logFileWriter)
        {
            _logStringBuildStrategy = logStringBuildStrategy;
            _logFileWriter = logFileWriter;
        }

        public void Store(ILogObject logOBject)
        {
            string logstring = _logStringBuildStrategy.BuildLogString(logOBject);
            _logFileWriter.AppendAllText(logstring);
        }
    }
}
