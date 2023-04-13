using System;

namespace Find_notes
{
    public class Program
    {
        public  void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 10; i++)
            {
           
            }
        }
    }
}
