using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = { 1, 2, 4 };
            Console.WriteLine(numbers.Sum());

            List<int> a = new List<int>();
            
            a.AddRange(numbers.Where(n => n % 2 == 0));
                // numbers.Where(n => n % 2 == 0).ToList();
            
            for (int i =0; i< a.Count; i++)
            {
                Console.WriteLine(a[i]);
            
            }
            
            // Query syntax
            // var query = from n in a
            //     where n % 2 == 0;
            // Select n;





        }
    }
}