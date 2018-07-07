using MLogger.Entities;
using MLogger.Exceptions;
using MLogger.Strategies.PersistenceStrategies;

namespace MLogger
{
    public class Logger : ILogger
    {
        private Logger()
        {
        }

        public static Logger Instance => NestedLogger.Instance;

        private static IPersistenceStrategy _persistenceStrategy;


        public void Log(ILogObject logObject)
        {
            if (_persistenceStrategy == null)
            {
                throw new PersistenceStrategyNotSetException("Persistence strategy is not initialized.");
            }
            _persistenceStrategy.Store(logObject);            
        }

        public void Log(ILogObject logObject, IPersistenceStrategy persistenceStrategy)
        {
            if (persistenceStrategy == null)
            {
                throw new PersistenceStrategyNotSetException("Persistence strategy is not initialized.");
            }
            persistenceStrategy.Store(logObject);
        }

        public static void InitializePersistenceStrategy(IPersistenceStrategy persistenceStrategy)
        {
            _persistenceStrategy = persistenceStrategy;
        }

        private class NestedLogger
        {
            internal static readonly Logger Instance = new Logger();
        }
    }
}
