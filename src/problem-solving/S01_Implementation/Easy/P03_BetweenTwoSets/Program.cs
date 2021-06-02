using System;
using System.Linq;
using System.Collections.Generic;

namespace P03_BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.GetTotalX(arr, brr);

            Console.WriteLine(total);
        }
    }

    class Result
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            var total = 0;

            for (int i = a.Max(); i <= b.Max(); i++)
            {
                if (i == 0)
                {
                    continue;
                }

                var isFactor = true;

                foreach (var aItem in a)
                {
                    if (i % aItem != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }

                if (isFactor)
                {
                    foreach (var bItem in b)
                    {
                        if (bItem % i != 0)
                        {
                            isFactor = false;
                            break;
                        }
                    }
                }

                if (isFactor)
                {
                    total++;
                }
            }

            return total;
        }
    }
}
