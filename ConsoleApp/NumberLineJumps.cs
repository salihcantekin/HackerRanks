using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class NumberLineJumps
    {

        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        //    int x1 = Convert.ToInt32(x1V1X2V2[0]);

        //    int v1 = Convert.ToInt32(x1V1X2V2[1]);

        //    int x2 = Convert.ToInt32(x1V1X2V2[2]);

        //    int v2 = Convert.ToInt32(x1V1X2V2[3]);

        //    string result = Kangaroo(x1, v1, x2, v2);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}


        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            int x1CurrentLoc = x1, x2CurrentLoc = x2;

            for (int i = 1; i <= 10000; i++)
            {
                if (x1CurrentLoc == x2CurrentLoc)
                    return "YES";

                x1CurrentLoc += v1;
                x2CurrentLoc += v2;
            }


            return "NO";

        }
    }



}
