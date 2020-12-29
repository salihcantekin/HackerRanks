using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class TimeConversion
    {
        //https://www.hackerrank.com/challenges/time-conversion/problem

        static string timeConversion(string s)
        {
            if (String.IsNullOrEmpty(s))
                return String.Empty;

            int hour = int.Parse(s.Substring(0, 2));

            switch (s.Substring(s.Length - 2, 2))
            {
                case "PM":
                    hour = hour == 12 ? 12 : hour + 12;
                    break;
                case "AM":
                    hour = hour == 12 ? 00 : hour;
                    break;
            }

            return hour.ToString("D2") + s.Substring(2, s.Length - 4);
        }

        //static void Main(string[] args)
        //{
        //    TextWriter tw = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    string result = timeConversion(s);

        //    tw.WriteLine(result);

        //    tw.Flush();
        //    tw.Close();
        //}
    }
}
