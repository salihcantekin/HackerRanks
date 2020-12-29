using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class GradingStudents
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> grades = new List<int>();

        //    for (int i = 0; i < gradesCount; i++)
        //    {
        //        int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
        //        grades.Add(gradesItem);
        //    }

        //    List<int> result = gradingStudents(grades);

        //    textWriter.WriteLine(String.Join("\n", result));

        //    textWriter.Flush();
        //    textWriter.Close();
        //}

        private static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = grades
                .Select(i => i = (i > 37 && i % 5 >= 3) ? i + 5 - (i % 5) : i)
                .ToList();

            return result;
        }

    }
}
