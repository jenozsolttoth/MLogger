using MLogger.Settings;

namespace MLogger.FileStore
{
    public class LogFileWriter : ILogFileWriter
    {
        private static object lockobject;
        private readonly IFileWriteSettings _fileWriteSettings;
        private readonly IFileWrapper _fileWrapper;
        public LogFileWriter(IFileWriteSettings fileWriteSettings, IFileWrapper fileWrapper)
        {
            _fileWriteSettings = fileWriteSettings;
            _fileWrapper = fileWrapper;
        }
        public void AppendAllText(string value)
        {
            _fileWrapper.AppendAllText(_fileWriteSettings.Path, value, _fileWriteSettings.Encoding);
        }
    }
}
