using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt
{
    class Viewer
    {
        private Messenger messenger = null;
        private String myName = null;

        public Viewer (Messenger messenger)
        {
            this.messenger = messenger;
            this.myName = getMyName();
        }

        public void ReadMedia(Media media)
        {
            this.PrepareMedia(media);
            messenger.DisplayMessageOnConsole(myName, "La lecture débute, le temps de lecture sera de : " + media.DurationInSec + " secondes...");
            System.Threading.Thread.Sleep(media.DurationInSec * 1000);
            messenger.DisplayMessageOnConsole(myName, "La lecture est terminée");
        }

        private void PrepareMedia(Media media)
        {
            System.Threading.Thread.Sleep(media.DurationInSec * 100);
            messenger.DisplayMessageOnConsole(myName, "Le media est prêt pour la lecture");
        }

        private String getMyName()
        {
            Type objtype = this.GetType();
            return objtype.Name;
        }
    }
}
