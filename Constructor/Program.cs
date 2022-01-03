using System;
using System.Security.Cryptography.X509Certificates;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car("SM%5");
            car1.Go();
        }   
    }

    class Car
    {
        private readonly string _name;

        public Car(string name) //ctor 단축키 
        {
            this._name = name;
        }

        public Car(): this("Nothing") //forwarding skill
        {
            
        }

        public void Go() => Console.WriteLine($"{_name} is running");
        

    }

    
}