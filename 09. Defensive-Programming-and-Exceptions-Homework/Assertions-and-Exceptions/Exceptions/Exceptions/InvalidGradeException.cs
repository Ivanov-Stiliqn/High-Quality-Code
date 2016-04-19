namespace Exceptions_Homework.Exceptions
{
    using System;

    public class InvalidGradeException : Exception
    {
        public InvalidGradeException(string message)
            : base(message)
        {
        }
    }
}
