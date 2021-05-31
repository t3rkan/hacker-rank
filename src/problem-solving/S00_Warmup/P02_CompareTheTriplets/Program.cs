using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(aTemp => Convert.ToInt32(aTemp))
                .ToList();
    
            List<int> b = Console.ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(bTemp => Convert.ToInt32(bTemp))
                .ToList();
    
            List<int> result = Result.CompareTriplets(a, b);
    
            Console.WriteLine(String.Join(" ", result));
        }
    }

    class Result
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var resultsContainer = new List<int>();
            var resultA = 0;
            var resultB = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    resultA++;
                    continue;
                }
                else if (a[i] < b[i])
                {
                    resultB++;
                }
            }

            resultsContainer.Add(resultA);
            resultsContainer.Add(resultB);

            return resultsContainer;
        }
    }
}
