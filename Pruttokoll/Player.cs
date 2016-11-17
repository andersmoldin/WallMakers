using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class Player
    {
        public int y;
        public int x;
        public string userName;

        public Player(int x, int y, string userName)
        {
            this.y = x;
            this.x = y;
            this.userName = userName;
        }
    }
}
