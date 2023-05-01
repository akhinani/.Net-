using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Songrequirement4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            {
                new Song("The Way", "Fastball", "Emotional", DateTime.Parse("12-01-2002"), 4.6, 12000);
                new Song("Man World", "Gray jules", "Emotional", DateTime.Parse("01-03-2001"), 4.7, 13000);
                new Song("Let It Be", "The Beatless", "Motivational", DateTime.Parse("02-03-2004"), 4.2, 12000);

            }
            Console.WriteLine("name \t artist\t songType\t dateDownloaded\t rating\t numberOfDownloads\t ");
            foreach(Song s in list) 
            {
                Console.WriteLine(s);
            }
            list.Sort();
            Console.WriteLine("Sort Song in the Array");
            Console.WriteLine();
            foreach (Song s in list)
            {
                Console.WriteLine(s);
            }
        }
       
    }
}
