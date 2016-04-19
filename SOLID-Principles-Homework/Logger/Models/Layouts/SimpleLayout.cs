namespace Logger.Models.Layouts
{
    using System;
    using System.Text;
    using Logger.Contracts;

    public class SimpleLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            StringBuilder format = new StringBuilder();
            format.AppendFormat("{0} - {1} - {2}", date, reportLevel, message);

            return format.ToString();
        }
    }
}
