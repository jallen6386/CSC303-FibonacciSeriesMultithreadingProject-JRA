using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FibonacciSeries
{
    class Program
    {
        public static void Main() //Main method
        {
            Console.WriteLine("Processor Count = " + Environment.ProcessorCount);
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            //Ask the user for length input and stores it to calculate given Fibonacci Series length.
            Console.WriteLine();

            Thread mainThread = Thread.CurrentThread; //Creates Main Thread
            mainThread.Name = "Main Thread"; //Renames Main Thread

            //Stopwatch feature starts after receiving user input to determine how fast the multithreaded calculation is
            Stopwatch stopwatch = Stopwatch.StartNew();

            //Multithreaded operation
            //Thread 1 Calculates Fibonacci Series in Incrementing Order
            Thread T1 = new Thread(() => Fibonacci_Series(length));
            //Thread 2 Calculates Fibonacci Series in Reverse Order
            Thread T2 = new Thread(() => FibonacciReversed(length));


            T1.Start(); //Starts Thread 1
            T2.Start(); //Starts Thread 2

            T1.Join(); //Waits for T1 to complete
            T2.Join(); //Waits for T2 to complete

            stopwatch.Stop();

            Console.WriteLine("Total milliseconds with multiple threads = " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();

            //Single Thread Operation
            stopwatch = Stopwatch.StartNew();
            Fibonacci_Series(length);
            FibonacciReversed(length);
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds without multiple threads = " + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
        static int Create_FibSeries(int n)
            //This method is used to generate a list of the elements in the Fibonacci Series using an iterative approach.
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        public static void Fibonacci_Series(int length)
            //This method is used to generate the Fibonacci Series in incrementing order given user input.
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Fibonacci Series: {0}", Create_FibSeries(i));
            }
        }

        public static void FibonacciReversed(int length)
            //This method is used to generate the Fibonacci Series in reverse order given user input.
        {
            for (int i = length - 1; i >= 0; i--)
            {
                Console.WriteLine("Fibonacci Series Reversed: {0}", Create_FibSeries(i));
            }
        }
    }
}