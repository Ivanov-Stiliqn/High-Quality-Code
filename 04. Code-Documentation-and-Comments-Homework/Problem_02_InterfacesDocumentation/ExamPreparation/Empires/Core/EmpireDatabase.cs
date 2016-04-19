using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Core
{
    /// <summary>
    /// Class for conteining all created data.
    /// </summary>
    public class EmpireDatabase
    {
        private readonly ICollection<IBuilding> buildings=new List<IBuilding>();

        public EmpireDatabase()
        {
            this.Units = new Dictionary<string, int>();
            this.Resources = new Dictionary<ResourceType, int>();
            FillResources();
        }

        public IDictionary<string,int> Units { get; private set; }

        public IDictionary<ResourceType, int> Resources { get; private set; }

        public IEnumerable<IBuilding> Buildings
        {
            get
            {
                return this.buildings;
            }
        }

        public void FillResources()
        {
            foreach (ResourceType resource in Enum.GetValues(typeof(ResourceType)))
            {
                this.Resources.Add(resource,0);
            }
        }

        public void AddBuilding(IBuilding building)
        {
            this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException("Unit cannot be null");
            }

            string unitName = unit.GetType().Name;
            if (!this.Units.ContainsKey(unitName))
            {
                this.Units.Add(unitName,0);
            }
            this.Units[unitName]++;
        }
    }
}
