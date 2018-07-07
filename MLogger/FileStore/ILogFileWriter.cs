
namespace MLogger.FileStore
{
    public interface ILogFileWriter
    {
        void AppendAllText(string value);
    }
}
