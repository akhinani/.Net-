using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowerffruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose" };
            string[] fruits = { "apple", "mango" };

            var fQuery =
                from flower in flowers
                from fruit in fruits
                select new flowerffruit(f.flower, f.flower);
                
                foreach(var f in fQuery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
