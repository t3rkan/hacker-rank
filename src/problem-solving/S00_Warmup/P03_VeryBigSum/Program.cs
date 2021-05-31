using System;
using System.Linq;
using System.Collections.Generic;

namespace P03_VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.VeryBigSum(ar);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static long VeryBigSum(List<long> ar)
        {
            var sum = 0L;

            foreach (var el in ar)
            {
                sum += el;
            }

            return sum;
        }
    }
}
