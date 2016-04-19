namespace Exceptions_Homework.Exceptions
{
    using System;

    public class NoCurrentExamsExcepiton : Exception
    {
        public NoCurrentExamsExcepiton(string message)
            : base(message)
        {
        }
    }
}