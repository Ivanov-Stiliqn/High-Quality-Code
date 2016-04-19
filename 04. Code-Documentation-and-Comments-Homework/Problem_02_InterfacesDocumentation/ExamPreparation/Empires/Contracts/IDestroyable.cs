using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can be destroyed when the health falls to 0 or beneath.
    /// </summary>
    public interface IDestroyable
    {
        int Health { get; set; }
    }
}
