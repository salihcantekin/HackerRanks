using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class SuperReducedString
    {
        // https://www.hackerrank.com/challenges/reduced-string/problem


        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = superReducedString(s);

            Console.WriteLine(result);

            Console.ReadLine();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static string superReducedString(string s)
        {
            while (true)
            {
                char pr = ' ';

                bool foundAny = false;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (pr == s[i])
                    {
                        s = s.Remove(i, 2);
                        i -= 2;
                        foundAny = true;
                    }

                    if (i > -1)
                        pr = s[i];
                    else break;
                }

                if (!foundAny) break;
            }

            return String.IsNullOrEmpty(s) ? "Empty String" : s;
        }
    }
}
