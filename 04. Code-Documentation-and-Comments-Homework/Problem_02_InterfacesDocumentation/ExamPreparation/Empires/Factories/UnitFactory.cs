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
    /// Factory class for creating units.
    /// </summary>
    public class UnitFactory : IUnitFactory
    {
        /// <summary>
        /// Creates unit by its type.
        /// </summary>
        /// <param name="unitType"></param>
        /// <returns></returns>
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                    default:
                    throw new ArgumentException(unitType,"There is no such unit");
            }
        }
    }
}
