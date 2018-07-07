using System;
using MLogger.Builders;
using MLogger.Entities;
using MLogger.Settings;

namespace MLogger.Strategies.BuildStrategies
{
    public class LogicalStringBuildStrategy : ILogStringBuildStrategy
    {
        private readonly ILogStringBuilder _logStringBuilder;
        public LogicalStringBuildStrategy(ILogStringBuilder logStringBuilder)
        {
            _logStringBuilder = logStringBuilder;
        }
        public string BuildLogString(ILogObject logObject)
        {
            return _logStringBuilder
                 .WithLevel(logObject.Level)
                 .WithDelimeter()
                 .WithException(logObject.Exception.ToString())
                 .WithDelimeter()
                 .WithMethod(logObject.Method)
                 .WithDelimeter()
                 .WithMessage(logObject.Message)
                 .GetLogString();
        }
    }
}
