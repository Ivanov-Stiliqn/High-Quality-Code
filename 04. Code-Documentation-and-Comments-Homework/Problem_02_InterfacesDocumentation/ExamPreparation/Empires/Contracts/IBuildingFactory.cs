using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can create buildings by their types.
    /// </summary>
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string bildingType);
    }
}
