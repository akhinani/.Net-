using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songrequirement3
{
    public class SongsRepo
    {
        static List<Song> _songs = new List<Song>

        {
            new Song("Shape of you","ED SHAREEN","POP",4.8, 10000, DateTime.Parse("01-01-2000")),
            new Song("Perfect", "ED SHAREEN", "POP", 4.5, 12000, DateTime.Parse("04-05-2016")),
            new Song("Something Just like this", "Coldplay", "MELODY", 4.8, 12445, DateTime.Parse("01-03-2000"))
        };
        public static List<Song> Getallsongs()
        {
            return _songs;
        }

    }
}
