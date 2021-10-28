using System;
using System.Diagnostics;
using System.Globalization;

namespace Field
{
    class Program
    {
        private static string message = "Hello";
        public static void Hi() => Console.WriteLine("Hello2");
        static void Main(string[] args)
        {
              Console.WriteLine(message);
              Hi();
              Myclass example = new Myclass();
              example.Hi();
              Person Me = new Person();
              Me.ShowProfile();
              
        }
    }

    public class Myclass
    {
        private string message = "good to see you";

        public void Hi()
        {
            // Console.WriteLine(this.message); this도 가능
            Console.WriteLine(message); 
        }
    }

    public class Person
    {
        private string name = "richie";
        private const int m_age = 20;
        private readonly string _Nickname = "Bbung";
        private string[] dogs = { "choco", "vanilar" };

        public void ShowProfile() => Console.WriteLine($"{name} - {m_age} - {_Nickname} - " +
                                                       $"{string.Join(",", dogs)}");

    }
} 