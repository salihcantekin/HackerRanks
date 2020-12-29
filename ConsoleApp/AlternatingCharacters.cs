using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class AlternatingCharacters
    {
        // https://www.hackerrank.com/challenges/alternating-characters/problem


        static int alternatingCharacters(string s)
        {
            char[] arr = s.ToArray();
            int counter = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    break;

                if (arr[i] == arr[i - 1])
                {
                    arr[i - 1] = arr[i];
                    counter++;
                }
            }

            return counter;
        }

        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string s = Console.ReadLine();

        //        int result = alternatingCharacters(s);

        //        textWriter.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
