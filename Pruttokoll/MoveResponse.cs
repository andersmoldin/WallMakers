using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class MoveResponse : Message
    {
        public bool success;

        public MoveResponse(bool success) : base("MoveResponse")
        {
            this.success = success;
        }
    }
}
