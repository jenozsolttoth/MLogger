using System;

namespace MLogger.Entities
{
    public class LogObject : ILogObject
    {
        public LogLevel Level { get; set; }
        public Exception Exception { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
    }
}
