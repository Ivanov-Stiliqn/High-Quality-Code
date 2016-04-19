using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;
using Empires.Factories;

namespace Empires.Models
{
    public abstract class Building : IBuilding
    {
        private int turns;

        protected Building(string unitType,ResourceType resourceType,int unitCycles,int resourceCycles,int resourceQuantity)
        {
            this.UnitType = unitType;
            this.ResourceType = resourceType;
            this.UnitCycles = unitCycles;
            this.ResourceCycles = resourceCycles;
            this.ResourceQuantity = resourceQuantity;
            this.turns = 0;

        }

        public int Turns
        {
            get { return this.turns; }
        }

        public string UnitType { get; set; }

        public int UnitCycles { get; set; }

        public int ResourceCycles { get; set; }

        public ResourceType ResourceType { get; set; }

        public int ResourceQuantity { get; set; }

        public bool CanProduceResource { get; set; }

        public bool CanProduceUnit { get; set; }

        /// <summary>
        /// Calls the ResourceFactory class to create resources. 
        /// </summary>
        /// <returns>Returns quantity of the requared resource.</returns>
        public IResource ProduceResource()
        {
            ResourceFactory resourceFactory = new ResourceFactory();

            var resource=resourceFactory.CreateResource(this.ResourceType, this.ResourceQuantity);

            return resource;
        }

        /// <summary>
        /// Calls the UnitFactory class to create units.
        /// </summary>
        /// <returns>Returns requared unit.</returns>
        public IUnit ProduceUnit()
        {
            UnitFactory unitFactory = new UnitFactory();

            var unit=unitFactory.CreateUnit(this.UnitType);

            return unit;
        }

        /// <summary>
        /// For each round cheks if the bulding can produce resources and/or create units.
        /// </summary>
        public void Update()
        {
            this.turns++;

            this.CanProduceResource = this.Turns > 1 && ((this.Turns -1 )% this.ResourceCycles==0);

            this.CanProduceUnit = this.Turns > 1 && ((this.Turns -1) % this.UnitCycles==0);

            
        }

        public override string ToString()
        {
            StringBuilder output=new StringBuilder();
            int turnsToUnit = this.UnitCycles -((this.Turns-1)%this.UnitCycles);
            int turnsToResource = this.ResourceCycles- ((this.Turns-1)%this.ResourceCycles);
            output.AppendFormat("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})", this.GetType().Name, this.Turns-1,
                turnsToUnit, this.UnitType, turnsToResource, this.ResourceType);

            return output.ToString();
        }
    }
}
