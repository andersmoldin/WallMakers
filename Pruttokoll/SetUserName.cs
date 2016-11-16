using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class SetUserName : Message
    {
        public string username;

        public SetUserName(string username) : base("SetUserName")
        {
            this.username = username;
        }
    }
}
