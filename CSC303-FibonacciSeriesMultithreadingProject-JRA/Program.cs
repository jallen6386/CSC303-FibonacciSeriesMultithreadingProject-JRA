using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FibonacciSeries
{
    class Program
    {
        public static int Create_FibSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Create_FibSeries(n - 1) + Create_FibSeries(n - 2);
        }

        public static void Fibonacci_Series(int length)
        {
            Console.Write("Fibonacci Series: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Create_FibSeries(i));
            }
        }

    public static void FibonacciReversed(int length)
        {
            Console.Write("Fibonacci Series Reversed: ");
            for (int i = length; i >= 1; i--)
            {
                Console.Write("{0} ", Create_FibSeries(i));
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Fibonacci_Series(length);
            Console.WriteLine();
            FibonacciReversed(length);
            Console.ReadKey();
        }
    }
}