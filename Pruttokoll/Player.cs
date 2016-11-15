using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class Player
    {
        public int x;
        public int y;
        public string userName;

        public Player(int x, int y, string userName)
        {
            this.x = x;
            this.y = y;
            this.userName = userName;
        }
    }
}
