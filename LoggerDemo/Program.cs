using System;
using System.Text;
using MLogger;
using MLogger.Builders;
using MLogger.Entities;
using MLogger.FileStore;
using MLogger.Settings;
using MLogger.Strategies.BuildStrategies;
using MLogger.Strategies.PersistenceStrategies;

namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStringBuilder = new MyStringBuilder();
            var logBuilderStrategySettings = new LogStringBuilderStrategySettings
            {
                Delimeter = ';',
                LineCloser = "\r\n"
            };

            var logStringBuilder = new LogStringBuilder(myStringBuilder, logBuilderStrategySettings);

            var myFileWriterSettings = new FileWriterSettings
            {
                Encoding = Encoding.UTF8,
                Path = "log.txt"
            };

            var myFileWrapper = new FileWrapper();

            var logFileWriter = new LogFileWriter(myFileWriterSettings, myFileWrapper);

            var logicalStringBuilderStrategy = new LogicalStringBuildStrategy(logStringBuilder);
            var fileStrategy = new FileStrategy(logicalStringBuilderStrategy, logFileWriter);

            Logger.InitializePersistenceStrategy(fileStrategy);

            Logger.Instance.Log(new LogObject { Exception = new Exception("sajtosrolád"), Level = LogLevel.Critical, Message = "Sajt", Method = "Sajtmethod" });
            Logger.Instance.Log(new LogObject { Exception = new Exception("sajtosrolád123"), Level = LogLevel.Critical, Message = "Sajt123", Method = "Sajtmethod123" });
            Logger.Instance.Log(new LogObject { Exception = new Exception("sajtosrolád123123"), Level = LogLevel.Critical, Message = "Sajt123123", Method = "Sajtmethod123123" });
            Console.WriteLine("Hello World!");
        }
    }

}
