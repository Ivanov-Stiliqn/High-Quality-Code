using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Exceptions
{
    public class InvalidDigitException : Exception
    {
        public InvalidDigitException()
        {
            
        }

        public InvalidDigitException(string message)
            :base(message)
        {
            
        }
    }
}
