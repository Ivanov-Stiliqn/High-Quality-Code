namespace Logger.Models.Appenders
{
    using System;
    using Logger.Contracts;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.RestrictedReportLevel)
            {
                Console.WriteLine(this.Layout.Format(DateTime.Now, reportLevel, message));   
            }
        }
    }
}
