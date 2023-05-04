using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_witharrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose","lotus","lilly","hibiscus","daffodil" };
            var fQuery =
                from flower in flowers
                let len = flower.Length
                where len > 5 && len < 7
                //where (flower.StartsWith("d"))
                select flower;
            foreach (string f in fQuery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
