using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {    
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.BreakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));
        }
    }

    class Result
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            var minPoints = scores[0];
            var maxPoints = scores[0];
            var minBroken = 0;
            var maxBroken = 0;

            for (int i = 1; i < scores.Count(); i++)
            {
                var s = scores[i];

                if (s < minPoints)
                {
                    minPoints = s;
                    minBroken++;
                }

                if (s > maxPoints)
                {
                    maxPoints = s;
                    maxBroken++;
                }
            }

            return new List<int>() { maxBroken, minBroken };
        }
    }
}
