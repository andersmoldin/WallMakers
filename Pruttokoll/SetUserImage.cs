using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class SetUserImage : Message
    {
        public int userImageIndex;

        public SetUserImage(int userImageIndex) : base("SetUserImage")
        {
            this.userImageIndex = userImageIndex;
        }
    }
}
