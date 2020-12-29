using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class DiagonalDifference
    {
        // https://www.hackerrank.com/challenges/diagonal-difference/problem

        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<int>> arr = new List<List<int>>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //    }

        //    int result = diagonalDifference(arr);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}

        public static int diagonalDifference(List<List<int>> arr)
        {
            if (arr == null || !arr.Any()) return 0;

            int leftSum = 0, rightSum = 0;
            int countSubList = arr[0].Count;

            for (int i = 0; i < arr.Count; i++)
            {
                leftSum += arr[i][i];
                rightSum += arr[i][countSubList - i - 1];
            }

            return Math.Abs(leftSum - rightSum);
        }
    }
}
