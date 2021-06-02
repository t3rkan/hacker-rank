using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.MigratoryBirds(arr);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int MigratoryBirds(List<int> arr)
        {
            var birdsCounter = new Dictionary<int, int>();
            birdsCounter.Add(1, 0);
            birdsCounter.Add(2, 0);
            birdsCounter.Add(3, 0);
            birdsCounter.Add(4, 0);
            birdsCounter.Add(5, 0);

            foreach (var a in arr)
            {
                birdsCounter[a]++;
            }

            var mostFrequent = birdsCounter
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .FirstOrDefault()
                .Key;

            return mostFrequent;
        }
    }
}
