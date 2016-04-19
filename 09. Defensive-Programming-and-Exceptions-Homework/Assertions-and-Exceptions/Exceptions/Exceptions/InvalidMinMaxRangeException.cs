namespace Exceptions_Homework.Exceptions
{
    using System;

    public class InvalidMinMaxRangeException : Exception
    {
        public InvalidMinMaxRangeException(string message)
            : base(message)
        {    
        }
    }
}
