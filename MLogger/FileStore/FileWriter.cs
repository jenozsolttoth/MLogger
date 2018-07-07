using System.IO;
using MLogger.Settings;

namespace MLogger.FileStore
{
    public class MyFileWriter : IFileWriter
    {
        private static object lockobject;
        private readonly IFileWriteSettings _fileWriteSettings;
        public MyFileWriter(IFileWriteSettings fileWriteSettings)
        {
            _fileWriteSettings = fileWriteSettings;
        }
        public void WriteAllText(string value)
        {
            lock (lockobject)
            {
                File.AppendAllText(_fileWriteSettings.Path, value, _fileWriteSettings.Encoding);
            }
        }
    }
}
