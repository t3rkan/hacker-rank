using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            Result.CountApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }

    class Result
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var applesCount = 0;
            var orangesCount = 0;

            foreach (var range in apples)
            {
                if (a + range >= s && a + range <= t)
                {
                    applesCount++;
                }
            }

            foreach (var range in oranges)
            {
                if (b + range <= t && b + range >= s)
                {
                    orangesCount++;
                }
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }
    }
}
