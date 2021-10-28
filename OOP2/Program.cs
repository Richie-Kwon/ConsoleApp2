using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Code code1 = new Code();
            code1.Go();
        }
    }

    public class Code
    {
        public void Go() => Console.WriteLine("Start coding");
        public override string ToString() => "My code";
    }
}