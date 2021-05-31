using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine()
                    .TrimEnd()
                    .Split(' ').ToList()
                    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.DiagonalDifference(arr);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var firstSum = 0;
            var secondSum = 0;

            for (int row = 0; row < arr.Count; row++)
            {
                firstSum += arr[row][row];
                secondSum += arr[row][(arr.Count - 1) - row];
            }

            var sum = 0;

            if (firstSum > secondSum)
            {
                sum = firstSum - secondSum;
            }
            else if (firstSum < secondSum)
            {
                sum = secondSum - firstSum;
            }

            return sum;
        }
    }
}
