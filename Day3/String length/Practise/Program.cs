using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int length = 0;
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            foreach (char chr in str)

            {
                length +=1;
            }
            Console.WriteLine("the string length is {0} ",length);
        }
  
        
    }
}
