using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;

namespace Empires.Models
{
    public abstract class Unit : IUnit
    {
        protected Unit(int damage,int health)
        {
            this.Damage = damage;
            this.Health = health;
        }

        public int Damage { get; private set; }

        public int Health { get; set; }
    }
}
