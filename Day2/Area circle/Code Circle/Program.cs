using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Code_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0; double a;
            Console.WriteLine("enter radius");
            r = double.Parse(Console.ReadLine());
            a = Math.PI * r * r;
            Console.WriteLine(a);

        }
        
    }
}
