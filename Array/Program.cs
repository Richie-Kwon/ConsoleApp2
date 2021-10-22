using System;
using System.ComponentModel.DataAnnotations;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int [] perfectNumbers = {6,28,496} ;
            Console.WriteLine(perfectNumbers[0]);

            int[] eng = new int [3];
            eng[0] = 0;
            eng[1] = 1;
            eng[2] = 2;
            for (int i = 0; i < eng.Length; i++)
            {
                Console.Write(eng[i]);
            }     
            
            int[] eng2 = new int [3]{4,5,6};
            for (int j = 0; j < eng.Length; j++)
            {
                Console.Write(eng[j]);
            }

            int[] mvp = {7, 8, 9};
            int[,] mvp2 = new int [2, 3];
            int[,] mvp3 = {{1,2,3},{4,5,6}};
            
            // list
            // https://www.tutorialsteacher.com/csharp/csharp-list
            


        }
    } 
}