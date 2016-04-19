using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models
{
    public class Swordsman : Unit
    {
        private const int SwordsmanDamage = 13;
        private const int SwordsmanHealth = 40;

        public Swordsman() 
            : base(SwordsmanDamage, SwordsmanHealth)
        {
        }
    }
}
