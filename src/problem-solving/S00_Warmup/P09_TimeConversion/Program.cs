using System;

namespace P09_TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = Result.TimeConversion(s);

            Console.WriteLine(result);
        }
    }
    class Result
    {
        public static string TimeConversion(string s)
        {
            var dateTime = DateTime.Parse(s);

            return dateTime.ToString("HH:mm:ss");
        }
    }
}
