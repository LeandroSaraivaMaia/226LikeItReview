using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt.Features
{
    class Share
    {
        private Messenger messenger = null;
        private String myName = null;

        public Share(Messenger messenger)
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
