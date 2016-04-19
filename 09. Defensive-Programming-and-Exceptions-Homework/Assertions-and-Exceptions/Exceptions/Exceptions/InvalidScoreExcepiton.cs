namespace Exceptions_Homework.Exceptions
{
    using System;

    public class InvalidScoreExcepiton : Exception
    {
        public InvalidScoreExcepiton(string message)
            : base(message)
        {
        }
    }
}
