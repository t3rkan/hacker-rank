using System;

namespace P10_DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.PageCount(n, p);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int PageCount(int n, int p)
        {
            if (p - 1 < n - p)
            {
                return (int)Math.Floor((p / 2m));
            }
            else
            {
                if (n % 2 == 0)
                {
                    if (n  - p == 1)
                    {
                        return 1;
                    }
                }

                return (int)Math.Floor(((n - p) / 2m));
            }
        }
    }
}
