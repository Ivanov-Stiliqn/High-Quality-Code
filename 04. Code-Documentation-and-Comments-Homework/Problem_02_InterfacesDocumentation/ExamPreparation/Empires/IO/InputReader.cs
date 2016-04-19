using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;

namespace Empires.IO
{
    /// <summary>
    /// Reads the input from diffrent Environments.
    /// </summary>
    public class InputReader : IInputReader
    {
        /// <summary>
        /// Read a single line from the Environment input.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
