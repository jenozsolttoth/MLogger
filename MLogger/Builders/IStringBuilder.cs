
namespace MLogger.Builders
{
    public interface IStringBuilder
    {
        IStringBuilder Append(string value);
        IStringBuilder Append(char value);
    }
}
