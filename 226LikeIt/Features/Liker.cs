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

        public void UpdateCounter(Media likedMedia, bool isLike)
        {
            try
            {
                Tuple<int, int> votes;

                if (isLike)
                {
                    votes = new Tuple<int, int>(likedMedia.CounterVotes.Item1 + 1, likedMedia.CounterVotes.Item2);
                }
                else
                {
                    votes = new Tuple<int, int>(likedMedia.CounterVotes.Item1, likedMedia.CounterVotes.Item2 + 1);
                }

                likedMedia.CounterVotes = votes;

                messenger.DisplayMessageOnConsole(getMyName(), "Vous avez voter pour le media : \"" + likedMedia.Name + "." + likedMedia.Format + "\"");
            }
            catch
            {
                messenger.DisplayMessageOnConsole(getMyName(), "ERREUR lors du vote du media : \"" + likedMedia.Name + "." + likedMedia.Format + "\"");
            }
        }

        private String getMyName()
        {
            Type objtype = this.GetType();
            return objtype.Name;
        }
    }
}
