using System;
using System.Collections.Generic;
using System.Linq;

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
            list.Insert(1, 200);
            Console.WriteLine(list[0]);

            for (int i =0; i< list.Count; i++)
            {
                Console.WriteLine(list[i]);
                
            }

            List<int> list2 = new List<int>();
            list2.AddRange(Enumerable.Range(1, 10));

            Dictionary<int, string> todo = new Dictionary<int, string>();
            todo.Add(1, "Miss");
            todo.Add(2, "New");

            foreach (var item in todo)
            { 
                Console.WriteLine($"{item.Key} and {item.Value}");
            }

        }  
    }
}