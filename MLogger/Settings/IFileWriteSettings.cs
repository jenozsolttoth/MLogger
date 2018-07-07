
using System.Text;

namespace MLogger.Settings
{
    public interface IFileWriteSettings
    {
        Encoding Encoding { get; set; }
        string Path { get; set; }
    }
}
