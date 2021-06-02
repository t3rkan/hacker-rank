using System;

namespace P08_DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.DayOfProgrammer(year);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static string DayOfProgrammer(int year)
        {
            var leapYear = $"12.09.{year}";
            var regularYear = $"13.09.{year}";

            // Julian
            if (year < 1918 && year % 4 == 0)
            {
                return leapYear;
            }
            // Gregorian
            else if (year > 1918)
            {
                var isLeap = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);

                if (isLeap)
                {
                    return leapYear;
                }
            }
            else if (year == 1918)
            {
                return "26.09.1918";
            }

            return regularYear;
        }
    }
}
