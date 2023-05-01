using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requiremnet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter name,artist,songtype,rating ,number of downloads,date of download");
                string input = Console.ReadLine();
                string[] arr = input.Split(',');
                string name = arr[0];
                string artist = arr[1];
                string songtype = arr[2];
                DateTime dateDownloaded = Convert.ToDateTime(arr[3]);
                double rating = double.Parse(arr[3]);
                int numberofDownloads = int.Parse(arr[4]);
               
                Song s = new Song(name, artist, songtype,dateDownloaded, rating, numberofDownloads);
                list.Add(s);

            }
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd = Song.CalculateTypeCount(list);
            Console.WriteLine("songType \t count");
            foreach (var item  in sd)
            {
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            }
        }
    }
}

