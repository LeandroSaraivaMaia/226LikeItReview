using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt
{
    public class Messenger
    {
        public void DisplayMessageOnConsole(string author, string message)
        {
            DateTime timeStamp = DateTime.Now;
            Console.WriteLine(timeStamp.ToString("yyyy:dd:mm-HH:MM:ss") +"\t[" + author + "] \t" + message);
        }
    }
}
