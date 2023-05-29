using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_ArrayLeap
{
    class Solution
    {
        static bool CanWinGame(int n, int leap, int[] game)
        {
            if (n >= game.Length || game[n] == 1)
            {
                return false;
            }
            if (n + 1 >= game.Length || n + leap >= game.Length)
            {
                return true;
            }
            game[n] = 1; 
            return CanWinGame(n + leap, leap, game) || CanWinGame(n + 1, leap, game) || CanWinGame(n - 1, leap, game);
        }
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                int[] vals = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = vals[0];
                int leap = vals[1];
                int[] game = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                bool canWin = CanWinGame(0, leap, game);
                Console.WriteLine(canWin ? "YES" : "NO");
            }
        }
    }
}
