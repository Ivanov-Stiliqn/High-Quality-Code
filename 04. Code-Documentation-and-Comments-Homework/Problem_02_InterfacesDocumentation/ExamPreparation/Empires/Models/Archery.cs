using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Models
{
    /// <summary>
    /// Building that produces archers and gold.
    /// </summary>
    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int ArcheryUnitCycles = 3;

        private const ResourceType ArcheryResourceType=ResourceType.Gold;
        private const int ArcheryResourceCycles = 2;
        private const int ArcheryResourceQuantity = 5;



        public Archery() 
            : base(ArcheryUnitType, ArcheryResourceType ,ArcheryUnitCycles,ArcheryResourceCycles,ArcheryResourceQuantity)
        {

        }
    }
}
