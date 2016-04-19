using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can attack with current damage.
    /// </summary>
    public interface IAttacker
    {
        int Damage { get; }
    }
}
