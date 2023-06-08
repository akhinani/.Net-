using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Endoffile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int lineNum = 1;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(lineNum + " " + line);
                lineNum++;
            }

        }

    }

}