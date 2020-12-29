using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class SalesByMatch
    {
        //https://www.hackerrank.com/challenges/sock-merchant/problem

        static int sockMerchant(int n, int[] ar)
        {
            var groupedList = ar.GroupBy(i => i)
                .Select(i => new { Sock = i.Key, totalEach = i.Count() });

            int totalPair = 0;

            foreach (var item in groupedList)
                totalPair += item.totalEach / 2;

            return totalPair;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //    int result = sockMerchant(n, ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
