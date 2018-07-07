using System.Text;

namespace MLogger.Settings
{

    public class FileWriterSettings : IFileWriteSettings
    {
        public Encoding Encoding { get; set; }
        public string Path { get; set; }
    }
}
