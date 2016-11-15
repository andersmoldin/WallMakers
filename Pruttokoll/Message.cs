using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public abstract class Message
    {
        public Guid id;
        public double version = 8.0;
        public string type;


        public Message(string type)
        {
            id = Guid.NewGuid();
            this.type = type;
        }
    }
}
