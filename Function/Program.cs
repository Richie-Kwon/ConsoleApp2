using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = Convert.ToInt32(args[0]);
            Factorial(n);
        }
        
        // recursion
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Sum() => Console.WriteLine("Sum: ");
        

    }
}