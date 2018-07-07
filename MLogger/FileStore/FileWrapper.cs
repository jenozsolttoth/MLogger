using System.IO;
using System.Text;

namespace MLogger.FileStore
{
    public class FileWrapper : IFileWrapper
    {
        private static readonly object Lockobject = new object();
        public void AppendAllText(string path, string content, Encoding encoding)
        {
            lock (Lockobject)
            {
                File.AppendAllText(path, content, encoding);
            }
        }
    }
}
