using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class RepeatedString
    {
        // https://www.hackerrank.com/challenges/repeated-string/problem

        static long repeatedString(string s, long n)
        {
            int strLen = s.Length;

            if (strLen == 0)
                return 0;

            n = Math.Max(n, 0);

            int aCount = strLen - s.Replace("a", "").Length;

            if (n % strLen == 0)
                return n / strLen * aCount;

            long aCountForDiv = aCount * (n / strLen);
            String leftStr = s.Substring(0, (int)(n % strLen));
            int aCountInLeftStr = leftStr.Length - leftStr.Replace("a", "").Length;

            return aCountForDiv + aCountInLeftStr;

        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    long n = Convert.ToInt64(Console.ReadLine());

        //    long result = repeatedString(s, n);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
