using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Contracts;

namespace Application2.Models
{
    public class Player : IPlayer
    {

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }

}
