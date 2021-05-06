using System;

namespace FibonacciSeries
{
    public class FibonacciSeriesProgram
    {
        static void Main(string[] args)
        {
            int length = 8;
            Fibonacci(0, 1, 1, length);
            Console.ReadKey();
        }
        //print the fibonacci series for a given length
        public static void Fibonacci(int firstnumber, int secondnumber, int count, int length)
        {
            if (count <= length)
            {
                Console.Write("{0}, ", firstnumber);
                Fibonacci(secondnumber, firstnumber + secondnumber, count + 1, length);
            }
        }
    }
}
