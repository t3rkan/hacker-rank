using System;

namespace P02_NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            while (x1 != x2)
            {
                if ((x1 > x2 && v1 > v2) ||
                    (x2 > x1 && v2 > v1) ||
                    (x1 < x2 && v1 == v2))
                {
                    return "NO";
                }

                x1 += v1;
                x2 += v2;
            }

            return "YES";
        }
    }
}
