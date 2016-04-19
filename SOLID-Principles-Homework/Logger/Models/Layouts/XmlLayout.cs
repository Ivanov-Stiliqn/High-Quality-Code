namespace Logger.Models.Layouts
{
    using System;
    using System.Text;

    using Logger.Contracts;

    public class XmlLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            var format = new StringBuilder();
            format.AppendLine("<log>");
            format.AppendFormat("   <date>{0}</date>\n", date);
            format.AppendFormat("   <level>{0}</level>\n", reportLevel);
            format.AppendFormat("   <message>{0}</message>\n", message);
            format.Append("</log>");

            return format.ToString();
        }
    }
}