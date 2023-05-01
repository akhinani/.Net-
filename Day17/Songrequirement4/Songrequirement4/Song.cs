using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songrequirement4
{
    public class Song :IComparable<Song>
    {
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime _dateDownloaded;
        private double _rating;
        private int _numberOfDownloads;

        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public string Artist
        { 
            get { return _artist; } 
            set {  _artist = value; } }
        public string SongType
        {
            get { return _songType; } 
            set { _songType = value; } }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set{_dateDownloaded = value;}
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set{_numberOfDownloads = value;} 
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _dateDownloaded = dateDownloaded;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            
        }
        public override string ToString()
        {
            return string.Format("name{0}:\n artist{1}:\n songtype{2} dateDownloaded{3}\n rating{4}\n numberOfDownloads{5}",
                _name, _artist, _songType, _dateDownloaded, _rating, _numberOfDownloads);


        }
        public int CompareTo(Song other)
        {
            return Name.CompareTo(other.Name);
        }

    }
}
