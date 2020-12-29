using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class BirthdayCakeCandles
    {
        //https://www.hackerrank.com/challenges/birthday-cake-candles/problem

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //    int result = birthdayCakeCandles(ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}


        static int birthdayCakeCandles(int[] ar)
        {
            if (ar == null || !ar.Any())
                return 0;

            int tallest = 0;
            int tallestCount = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > tallest)
                {
                    tallest = ar[i];
                    tallestCount = 0;
                }

                if (ar[i] == tallest)
                    tallestCount++;
            }

            return tallestCount;

        }
    }
}
