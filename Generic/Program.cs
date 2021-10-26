using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack<int> st1 = new Stack<int>();
            st1.Push(100);
            Console.WriteLine(st1.Pop());

            List<int> list = new List<int>();
            list.Add(100);
            Console.WriteLine(list[0]);

        }  
    }
}