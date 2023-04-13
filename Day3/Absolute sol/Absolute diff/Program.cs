using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, Abo;
            Console.WriteLine("enter n value");
            n =int.Parse(Console.ReadLine());
            Abo = calcAbo(n);
            Console.WriteLine(Abo);
            
        }
        static int calcAbo(int n)
        {
            int x = 51;
            if(x>n)
            {
                return (x - n) * 3;
            }
            return (n - x);
        }
    }
}
