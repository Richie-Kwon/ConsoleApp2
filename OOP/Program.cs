using System;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] data1 = { 1, 2, 5, 3, 4 };
            Array.Sort(data1);
            data1 = data1.OrderByDescending(x => x).ToArray();

            foreach (var i in data1)
            {
                Console.WriteLine(i);
            }
            
            // int[] data2 = Array.Sort(data);
              
            
        }
    }
}