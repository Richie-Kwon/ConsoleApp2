using System;
using System.Net;

namespace Thread
{
    class Program
    {
        static void Main(string[] args) => (new Kitchen()).Food();
    }

    class Kitchen
    {
        public void Food()
        {
            Console.WriteLine($"YeraLee");
        }
    }
}