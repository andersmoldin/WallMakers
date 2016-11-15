using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pruttokoll.Enums;

namespace Pruttokoll
{
    class Move : Message
    {
        public  direction direction;

        public Move(direction direction) : base("Move")
        {
            this.direction = direction;
        }
    }
}
