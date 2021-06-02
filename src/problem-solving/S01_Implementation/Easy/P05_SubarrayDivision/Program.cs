using System;
using System.Linq;
using System.Collections.Generic;

namespace P05_SubarrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.Birthday(s, d, m);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            var totalSum = 0;

            for (int i = 0; i < s.Count; i++)
            {
                if (i + m <= s.Count)
                {
                    var segment = s.GetRange(i, m);
                    var segmentSum = GetSegmentSum(segment);

                    if (segmentSum == d)
                    {
                        totalSum++;
                    }
                }
                else
                {
                    break;
                }
            }

            return totalSum;
        }

        static int GetSegmentSum(List<int> segment)
        {
            var sum = 0;

            for (int i = 0; i < segment.Count; i++)
            {
                sum += segment[i];
            }

            return sum;
        }
    }
}
