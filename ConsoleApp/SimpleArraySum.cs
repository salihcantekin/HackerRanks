using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class SimpleArraySum
    {
        // https://www.hackerrank.com/challenges/simple-array-sum/problem


        static int simpleArraySum(int[] ar)
        {
            int total = 0;
            foreach (int arrVal in ar)
                total += arrVal;

            return total;

        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //    ;
        //    int result = simpleArraySum(ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
