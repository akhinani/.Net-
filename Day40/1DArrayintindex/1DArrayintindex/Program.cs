using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DArrayintindex
{
    class Solution
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); 
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); 
                myArray[i] = num;
            }
           
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }

        }

    }
}
