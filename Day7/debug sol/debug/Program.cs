using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first nun");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            int j = int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("Debugging over");
        }

        public static void foo(int x, int y)
            {
            int t = 100;
            for(int i=x; i<=y; i++)
            {
                Console.WriteLine("india");
                t = t + 34;
            }
}

    }
}
