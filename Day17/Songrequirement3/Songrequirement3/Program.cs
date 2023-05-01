using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songrequirement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongsRepo.Getallsongs();

            foreach (Song s in ls)
            {

                Console.WriteLine(s.ToString());
            }
        }
        


    }
}
