using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class MiniMaxSum
    {
        //https://www.hackerrank.com/challenges/mini-max-sum/problem

        //static void Main(string[] args)
        //{
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    miniMaxSum(arr);
        //}


        static void miniMaxSum(int[] arr)
        {
            if (arr == null || !arr.Any())
                return;

            Int64 min = Int64.MaxValue, max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Int64 sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == i) continue;
                    sum += arr[j];
                }

                if (sum < min) min = sum;
                if (sum > max) max = sum;
            }

            Console.WriteLine(min + " " + max);
        }
    }
}
