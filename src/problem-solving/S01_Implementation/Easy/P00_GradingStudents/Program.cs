using System;
using System.Linq;
using System.Collections.Generic;

namespace P00_GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.GradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }

    class Result
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    continue;
                }
                if ((grades[i] + 1) % 5 == 0)
                {
                    grades[i] += 1;
                }
                else if ((grades[i] + 2) % 5 == 0)
                {
                    grades[i] += 2;
                }
            }

            return grades;
        }
    }
}
