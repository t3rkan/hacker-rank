using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(arTemp => Convert.ToInt32(arTemp))
                .ToList();

            int result = Result.SimpleArraySum(ar);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int SimpleArraySum(List<int> ar)
        {
            var sum = 0;

            foreach (var el in ar)
            {
                sum += el;
            }

            return sum;
        }
    }
}
