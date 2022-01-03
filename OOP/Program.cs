using System;
using System.Data;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] data1 = { 1, 2, 5, 3, 4 };

            // int [] data2 = data1.OrderBy(x => x).ToArray();
            // // Array.Sort(data1);
            // // data1 = data1.OrderByDescending(x => x).ToArray();
            //
            // foreach (var i in data2)
            // {
            //     Console.WriteLine(i);
            // }  
              
            // int[] data2 = Array.Sort(data);
            
            // selection sort

            for (int i=0; i < data1.Length-1; i++) 
            {
                for (int j = i+1; j< data1.Length; j++) 
                {
                    if (data1[i] > data1[j])
                    {
                        int temp = data1[i];
                        data1[i] = data1[j];
                        data1[j] = temp;
                    }

                }

            }

        }
    }
}