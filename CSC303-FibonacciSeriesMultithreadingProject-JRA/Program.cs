using System;
namespace FibonacciSeries
{
    class Program
    {
        static int FibonacciIterative(int n)
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

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciIterative(i));
            }
            Console.ReadKey();
        }
    }
}