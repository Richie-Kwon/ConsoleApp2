using System;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Hello World!");
            int number = 1_234;
            const int A = 4;
            // Nullable
            int? number2 = null;
            var result = "odd";
            string multilines = @"
            Hello
            world";
            Console.WriteLine($"{A} is {result}");
            
            // string.Format()
            var msg = string.Format("{0},{1}", "Yera", "wins");
            
            // Boolean
            var bln = true; 
            Int32 number100 = 5;
            
            Console.WriteLine("${DateTime.Now.Date}!");
            Console.WriteLine("{0}", "Bye");
            Console.WriteLine("{0}", "Bye");
            Console.ReadLine();

            string result100 = (number100 % 2 == 0) ? "even" : "odd";
            
        }
    }
}