namespace Logger.Contracts
{
    using System;
    using Logger.Models;

    public interface ILayout
    {
        string Format(DateTime date, ReportLevel reportLevel, string message);
    }
}
