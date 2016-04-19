using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can read from the current Environment.
    /// </summary>
    public interface IInputReader
    {
        string ReadLine();
    }
}
