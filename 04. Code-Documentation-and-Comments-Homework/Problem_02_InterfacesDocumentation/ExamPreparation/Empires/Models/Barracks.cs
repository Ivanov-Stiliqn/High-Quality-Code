using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Models
{
    /// <summary>
    /// Building that produce swordsmen and steel.
    /// </summary>
    public class Barracks :Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCycles = 4;

        private const ResourceType BarracksResourceType=ResourceType.Steel;
        private const int BarracksResourceCycles = 3;
        private const int BarracksResourceQuantity = 10;



        public Barracks()
            : base(
                BarracksUnitType, BarracksResourceType, BarracksUnitCycles, BarracksResourceCycles,
                BarracksResourceQuantity)
        {
            
        }

        
    }
}
