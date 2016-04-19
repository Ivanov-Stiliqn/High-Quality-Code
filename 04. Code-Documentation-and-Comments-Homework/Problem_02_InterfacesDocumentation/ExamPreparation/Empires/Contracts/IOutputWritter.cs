using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can write on the current Environment.
    /// </summary>
    public interface IOutputWritter
    {
        void WriteLine(string output);
    }
}
