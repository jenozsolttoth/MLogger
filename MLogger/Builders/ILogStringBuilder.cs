using MLogger.Entities;

namespace MLogger.Builders
{
    public interface ILogStringBuilder
    {
        ILogStringBuilder WithLevel(LogLevel level);
        ILogStringBuilder WithException(string exception);
        ILogStringBuilder WithMethod(string method);
        ILogStringBuilder WithMessage(string message);
        ILogStringBuilder WithDelimeter();
        string GetLogString();
    }
}
