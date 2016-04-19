using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Exceptions
{
    public class NoneExistingStudentException : Exception
    {
        public NoneExistingStudentException()
        {
            
        }

        public NoneExistingStudentException(string message)
            :base(message)
        {
            
        }
    }
}
