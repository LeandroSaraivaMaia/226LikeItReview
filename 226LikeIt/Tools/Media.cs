using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt
{
    public class Media
    {
        private String name;
        private String format;
        private List<int> quality;
        private int durationInSec;
        private Tuple<int, int> counterVotes;

        public Media(String name, String format, int durationInSec, List<int> availableResolution)
        {
            this.name = name;
            this.format = format;
            this.durationInSec = durationInSec;
            this.quality = availableResolution;
            this.counterVotes = new Tuple<int,int>(0,0);
        }

        public int DurationInSec
        {
            get { return this.durationInSec; }
        }

        public String Name
        {
            get { return this.name; }
        }
    }
}
