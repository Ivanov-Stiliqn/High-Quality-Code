namespace Logger.Models.Appenders
{
    using System;

    using System.IO;

    using Logger.Contracts;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.RestrictedReportLevel)
            {
                using (var writter = new StreamWriter(this.File, true))
                {
                    writter.WriteLine(this.Layout.Format(DateTime.Now, reportLevel, message));
                }
            }  
        }
    }
}
