using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class AVeryBigSum
    {
        // https://www.hackerrank.com/challenges/a-very-big-sum/problem

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
        //    long result = aVeryBigSum(ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}


        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;

            for (int i = 0; i < ar.Length; i++)
                sum += ar[i];

            return sum;

        }
    }
}
