using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class MarsExploration
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    int result = marsExploration(s);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}

        private static int marsExploration(string s)
        {
            if (String.IsNullOrEmpty(s)) return 0;
            string sos = "SOS";
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
                if (s[i] != sos[i % 3])
                    sum++;

            return sum;
        }
    }
}
