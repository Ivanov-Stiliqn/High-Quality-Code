namespace Logger.Models.Loggers
{
    using System.Collections.Generic;

    using Logger.Contracts;

    public class CustomLogger : ILogger
    {
        private readonly IEnumerable<IAppender> appenders;

        public CustomLogger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Critical(string message)
        {
            this.CallAllAppenders(ReportLevel.Critical, message);
        }

        public void Error(string message)
        {
            this.CallAllAppenders(ReportLevel.Error, message);
        }

        public void Fatal(string message)
        {
            this.CallAllAppenders(ReportLevel.Fatal, message);
        }

        public void Info(string message)
        {
            this.CallAllAppenders(ReportLevel.Info, message);
        }

        public void Warn(string message)
        {
            this.CallAllAppenders(ReportLevel.Warning, message);
        }

        private void CallAllAppenders(ReportLevel reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(reportLevel, message);
            }
        }
    }
}