using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car1 = new Car();
            car1.Go();
        }
    }

    class Car
    {
        public Car()
        {
            Console.WriteLine("create");
        }

        public void Go() => Console.WriteLine("running");

        ~Car()
        {
            Console.WriteLine("demolished");
        }

    }
}    