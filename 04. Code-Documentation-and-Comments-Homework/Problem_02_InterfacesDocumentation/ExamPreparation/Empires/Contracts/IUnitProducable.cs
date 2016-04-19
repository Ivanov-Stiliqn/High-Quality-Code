using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can create units within a given time.
    /// </summary>
    public interface IUnitProducable
    {
        bool CanProduceUnit { get; set; }

        IUnit ProduceUnit();
    }
}
