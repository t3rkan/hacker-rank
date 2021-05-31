using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.MiniMaxSum(arr);
        }
    }

    class Result
    {
        public static void MiniMaxSum(List<int> arr)
        {
            long sum = 0;
            long minEl = long.MaxValue;
            long maxEl = long.MinValue;

            foreach (var el in arr)
            {
                sum += el;
                
                if (minEl > el)
                {
                    minEl = el;
                }

                if (maxEl < el)
                {
                    maxEl = el;
                }
            }

            var minSum = sum - maxEl;
            var maxSum = sum - minEl;

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
