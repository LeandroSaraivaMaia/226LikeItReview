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

        public void shareMedia(Media sharedMedia, string emailAddress)
        {
            try
            {

                //Simulation of actual share action

                messenger.DisplayMessageOnConsole(getMyName(), "Vous avez partage le media \"" + sharedMedia.Name + "." + sharedMedia.Format + "\" a : " + emailAddress);
            }
            catch
            {
                messenger.DisplayMessageOnConsole(getMyName(), "ERREUR lors du partage du media : \"" + sharedMedia.Name + "." + sharedMedia.Format + "\"");
            }
        }

        private String getMyName()
        {
            Type objtype = this.GetType();
            return objtype.Name;
        }
    }
}
