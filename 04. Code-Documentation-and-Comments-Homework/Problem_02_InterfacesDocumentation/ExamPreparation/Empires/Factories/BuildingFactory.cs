using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Models;

namespace Empires.Factories
{
    /// <summary>
    /// Factory class for creating buildings.
    /// </summary>
    public class BuildingFactory : IBuildingFactory
    {
        /// <summary>
        /// Creates building by its name.
        /// </summary>
        /// <param name="buildingType"></param>
        /// <returns></returns>
        public IBuilding CreateBuilding(string buildingType)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery();
                case "barracks":
                    return new Barracks();
                default:
                    throw new ArgumentException(buildingType,"There is no such building");
            }
        }
    }
}
