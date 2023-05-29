using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string W1 = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string W2 = Console.ReadLine();
            char[] ch1 = W1.ToLower().ToCharArray();
            char[] ch2 = W2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string S1 = new string(ch1);
            string S2 = new string(ch2);
            if (S1 == S2)
            {
                Console.WriteLine("it is Anagrams");
            }
            else

            {
                Console.WriteLine("Not Anagrams");
            }

        }
    }
    
}
