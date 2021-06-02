using System;
using System.Linq;
using System.Collections.Generic;

namespace P06_DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.DivisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            // Console.WriteLine(3 % 1);
        }
    }

    class Result
    {
        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            var pairs = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                var a = ar[i];

                for (int j = i + 1; j < ar.Count; j++)
                {
                    var b = ar[j];

                    if ((a + b) % k == 0)
                    {
                        pairs++;
                    }
                }
            }
            
            return pairs;
        }
    }
}
