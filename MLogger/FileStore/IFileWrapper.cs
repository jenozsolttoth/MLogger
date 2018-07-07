using System.Text;

namespace MLogger.FileStore
{
    public interface IFileWrapper
    {
        void AppendAllText(string path, string content, Encoding encoding);
    }
}
