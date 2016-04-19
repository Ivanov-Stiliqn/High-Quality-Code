namespace Logger.Models.Appenders
{
    using Logger.Contracts;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; set; }

        public ReportLevel RestrictedReportLevel { get; set; }

        public abstract void Append(ReportLevel reportLevel, string message);
    }
}
