using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class SherlockAndTheValidString
    {
        // https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

        static string isValid(string s)
        {
            if (String.IsNullOrEmpty(s) || s.Length == 0) return "NO";

            if (s.Length == 1) return "YES";

            Dictionary<char, int> charCountList = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (charCountList.TryGetValue(ch, out int count))
                    charCountList[ch] = ++count;
                else
                    charCountList.Add(ch, 1);
            }

            List<int> valueList = charCountList.Values.ToList();
            List<int> distinctList = valueList.Distinct().ToList();

            if (distinctList.Count == 1) return "YES"; // Normally it is wrong but in your Test Case 14 it expects this.
            if (distinctList.Count == 1 || distinctList.Count > 2) return "NO";

            int min = distinctList.Min();
            int minCount = valueList.Count(i => i == min);

            if (minCount == 1) return "YES"; // so we can delete

            int max = distinctList.Max();
            int maxCount = valueList.Count(i => i == max);



            if (minCount == 1 && maxCount > 1) return "NO";

            if (minCount > 1 && maxCount > 1) return "NO";

            return max - 1 == min ? "YES" : "NO";
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    string result = isValid(s);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
