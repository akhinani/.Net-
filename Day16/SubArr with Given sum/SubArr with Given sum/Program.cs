using System;

namespace SubArr_With_Given_sum

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n, sum;
            Console.WriteLine("Enter length of N:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sum:");
            sum = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter your array elements:" );
                arr[i] = int.Parse(Console.ReadLine());
            }
            subarray(n, sum,arr);
        }
        public static void subarray(int n, int sum, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                int currentSum = arr[i];
                if (currentSum == sum)
                {
                    
                    return;
                }
                else
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        currentSum += arr[j];
                        if (currentSum == sum)
                        {
                            Console.WriteLine("Sum found between indexes " + i + " and " + j);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No subarray found");
        }
    }

}