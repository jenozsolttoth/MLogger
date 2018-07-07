
using MLogger.Entities;

namespace MLogger.Strategies.PersistenceStrategies
{
    public interface IPersistenceStrategy
    {
        void Store(ILogObject logOBject);
    }
}
