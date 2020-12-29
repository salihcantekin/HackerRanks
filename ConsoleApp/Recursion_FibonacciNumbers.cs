using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Recursion_FibonacciNumbers
    {
        // https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem

        public static int Fibonacci(int n)
        {
            return n == 0 ? 0 : n == 1 ? 1 : Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(Fibonacci(n));
        //}
    }
}
