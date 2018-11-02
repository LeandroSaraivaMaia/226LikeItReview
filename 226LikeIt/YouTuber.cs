using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226LikeIt
{
    
    class YouTuber
    {
        static private Messenger messenger = new Messenger();
        static private Viewer viewer = new Viewer(messenger);
        static private List<Media> listOfMedia = null;

        static void Main(string[] args)
        {
            //init
            listOfMedia = Init(listOfMedia);

            /*********1er scenario - début *************/
            //lecture de la première vidéo - jusqu'à la fin de la lecture
            viewer.ReadMedia(listOfMedia[0]);

            //TODO
            //le youtuber désire voter sur la vidéo qu'il vient de voir


            /*********1er scenario - fin **********/
            messenger.DisplayMessageOnConsole("YouTuber", "Fin du programme");
            Console.ReadLine();//"empêche" la console de se fermer
        }

        static List<Media> Init(List<Media> listOfMedia)
        {
            //declare and init a list of Media
            listOfMedia = new List<Media>();

            //create Media
            Media media01 = new Media("a380_initial_flight", "mpg", 10, new List<int> { 480, 360 });
            Media media02 = new Media("bloomberg", "flv", 5, new List<int> { 144, 240 });
            Media media03 = new Media("halloween", "mkv", 20, new List<int> { 144, 480 });
            
            //add media in the list of Media
            listOfMedia.Add(media01);
            listOfMedia.Add(media02);
            listOfMedia.Add(media03);

            messenger.DisplayMessageOnConsole("YouTuber", "L'initialisation de l'application est terminée.");
            return listOfMedia;
        }
    }
}
