using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requiremnet5
{
    public class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime _dateDownloaded;
        private double _rating;
        private int _numberofDownloaded;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        { get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songType; }
            set
            {
                _songType = value;
            }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NumberofDownloaded
        {
            get { return _numberofDownloaded; }
            set { _numberofDownloaded = value; }
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberofDownloaded)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            DateDownloaded = dateDownloaded;
            Rating = rating;
            NumberofDownloaded = numberofDownloaded;
            
        }

        public static SortedDictionary<String, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            foreach (var item in list)
            {
                if (sd.ContainsKey(item.SongType))
                {
                    sd[item.SongType]++;
                }
                else
                {
                    sd.Add(item.SongType,1);
                }
            }
            return sd;

        }

    }
}

