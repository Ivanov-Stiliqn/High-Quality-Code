namespace Logger.Contracts
{
    using Logger.Models;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        void Append(ReportLevel reportLevel, string message);
    }
}
