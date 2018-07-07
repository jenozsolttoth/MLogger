using System;
using System.Runtime.Serialization;

namespace MLogger.Exceptions
{
    public class PersistenceStrategyNotSetException : Exception
    {
        public PersistenceStrategyNotSetException()
        {
        }

        public PersistenceStrategyNotSetException(string message) : base(message)
        {
        }

        public PersistenceStrategyNotSetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersistenceStrategyNotSetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
