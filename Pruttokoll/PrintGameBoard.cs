using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    class RefreshGameBoard : Message
    {
        public List<Player> players;

        public RefreshGameBoard(List<Player> players) : base("RefreshGameBoard")
        {
            this.players = players;
        }
    }
}
