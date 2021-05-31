using System;
using System.Linq;
using System.Collections.Generic;

namespace P08_CakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {    
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine()
                .TrimEnd()
                .Split(' ').ToList()
                .Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.BirthdayCakeCandles(candles);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            var tallestCandle = 0;
            var tallestCandleCount = 0;

            foreach (var c in candles)
            {
                if(c > tallestCandle)
                {
                    tallestCandle = c;
                    tallestCandleCount = 1;
                }
                else if (c == tallestCandle)
                {
                    tallestCandleCount++;
                }
            }

            return tallestCandleCount;
        }
    }
}
