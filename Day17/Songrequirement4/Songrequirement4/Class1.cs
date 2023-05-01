using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songrequirement4
{
    internal class Class1 : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
           return x.Name.CompareTo(y.Name);
        }

    }
}
