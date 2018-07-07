
using System;

namespace MLogger.Entities
{
    public interface ILogObject
    {
        LogLevel Level { get; set; }
        Exception Exception { get; set; }
        string Method { get; set; }
        string Message { get; set; }
    }
}
