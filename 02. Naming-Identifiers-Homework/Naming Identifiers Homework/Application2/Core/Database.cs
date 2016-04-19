using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Contracts;

namespace Application2.Core
{
    public class Database : IDatabase
    {
        private const int TopPlayerSize = 6;
        private List<IPlayer> topPlayers;

        public Database()
        {
            this.topPlayers = new List<IPlayer>(TopPlayerSize);
        }

        public List<IPlayer> TopPlayers
        {
            get { return this.topPlayers; }
        }
    }
}
