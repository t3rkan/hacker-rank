using System;
using System.Linq;
using System.Collections.Generic;

namespace P09_BillDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            Result.BonAppetit(bill, k, b);
        }
    }

    class Result
    {
        public static void BonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            var bActual = bill.Sum() / 2;

            if (bActual == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - bActual);
            }
        }
    }
}
