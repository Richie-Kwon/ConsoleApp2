using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int [2];
                arr[100] = 1234;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

   
}  