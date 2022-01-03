using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Square square1 = new Square();
            square1.Weight = 10;
            Console.WriteLine(square1.Weight);
            Console.WriteLine("test");
        }
    }

    class Square
    {
        public int Width;
        public int Weight;
        public static string Creator;
        
    }

}   