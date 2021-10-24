using System;

namespace StructureType
{
    public struct Employee
    {
        public static string Name;
        public static int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee.Age = 5;
            Employee.Name = "Richie";
            TimeSpan ts = (DateTime.Now - (new DateTime(2020,1,1))
                );
            Console.WriteLine(ts.TotalDays);

        }
    }
    
   

}