using System;

namespace P06_Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.Staircase(n);
        }
    }

    class Result
    {
        public static void Staircase(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine($"{new String(' ', n - row)}{new String('#', row)}");
            }
        }
    }
}
