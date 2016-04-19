namespace Logger
{
    using Logger.Contracts;
    using Logger.Models;
    using Logger.Models.Appenders;
    using Logger.Models.Layouts;
    using Logger.Models.Loggers;
    
    public class LoggerMain
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.RestrictedReportLevel = ReportLevel.Error;

            var logger = new CustomLogger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
