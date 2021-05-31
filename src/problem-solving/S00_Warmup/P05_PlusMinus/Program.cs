using System;
using System.Linq;
using System.Collections.Generic;

namespace P05_PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.PlusMinus(arr);
        }
    }

    class Result
    {
        public static void PlusMinus(List<int> arr)
        {
            decimal positivesCount = 0;
            decimal negativesCount = 0;
            decimal zerosCount = 0;

            foreach (var el in arr)
            {
                if (el > 0)
                {
                    positivesCount++;
                }
                else if (el < 0)
                {
                    negativesCount++;
                }
                else
                {
                    zerosCount++;
                }
            }

            decimal positivesRatio = CalculateRatio(arr.Count, positivesCount);
            decimal negativesRatio = CalculateRatio(arr.Count, negativesCount);
            decimal zerosRatio = CalculateRatio(arr.Count, zerosCount);

            Console.WriteLine(Decimal.Round(positivesRatio, 6));
            Console.WriteLine(Decimal.Round(negativesRatio, 6));
            Console.WriteLine(Decimal.Round(zerosRatio, 6));
        }

        private static decimal CalculateRatio(int elementsCount, decimal elementCount)
        {
            if (elementCount == 0)
            {
                return 0;
            }

            decimal ratio = 1 / ( elementsCount / elementCount );

            return ratio;
        }
    }
}
