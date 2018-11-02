using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt.Features
{
    class Liker
    {
        private Messenger messenger = null;
        private String myName = null;

        public Liker (Messenger messenger)
        {
            this.messenger = messenger;
            this.myName = getMyName();
        }


        //TODO


        private String getMyName()
        {
            Type objtype = this.GetType();
            return objtype.Name;
        }
    }
}
