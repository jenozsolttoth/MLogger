using MLogger.Entities;
using MLogger.Settings;

namespace MLogger.Builders
{
    public class LogStringBuilder : ILogStringBuilder
    {
        private readonly IStringBuilder _stringBuilder;
        private readonly ILogStringBuilderStrategySettings _settings;

        public LogStringBuilder(IStringBuilder stringBuilder, ILogStringBuilderStrategySettings settings)
        {
            _stringBuilder = stringBuilder;
            _settings = settings;
        }

        public ILogStringBuilder WithDelimeter()
        {
            _stringBuilder.Append(_settings.Delimeter);
            return this;
        }

        public ILogStringBuilder WithLevel(LogLevel level)
        {
            _stringBuilder.Append(level.ToString());
            return this;
        }

        public ILogStringBuilder WithException(string exception)
        {
            _stringBuilder.Append(exception);
            return this;
        }

        public ILogStringBuilder WithMethod(string method)
        {
            _stringBuilder.Append(method);
            return this;
        }

        public ILogStringBuilder WithMessage(string message)
        {
            _stringBuilder.Append(message);
            return this;
        }

        public string GetLogString()
        {
            _stringBuilder.Append(_settings.LineCloser);
            return _stringBuilder.ToString();
        }
    }
}
