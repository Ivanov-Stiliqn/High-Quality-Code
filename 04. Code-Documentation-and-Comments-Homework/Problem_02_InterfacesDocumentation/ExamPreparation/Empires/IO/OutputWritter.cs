using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;

namespace Empires.IO
{
    /// <summary>
    /// Writes to the current Environment.
    /// </summary>
    public class OutputWritter : IOutputWritter
    {
        /// <summary>
        /// Writes a line to the Environment.
        /// </summary>
        /// <param name="output"></param>
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
