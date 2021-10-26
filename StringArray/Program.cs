using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "Hello" + "Sidney";
            string s2 = String.Concat("OK", "Good");
            Console.WriteLine($"{s1}, {s2}");
            
            Console.WriteLine($"{s1.Length}, {s2.Length}");

            char[] ch = s1.ToCharArray();
            
            // Console.WriteLine($"{ch}");
            
            for (int i =0; i < ch.Length ; i++)
            {
                Console.WriteLine(ch[i]);
            }

            string s3 = "hellosidney";

            if (string.Equals(s1,s3, StringComparison.InvariantCultureIgnoreCase) )
            { Console.WriteLine("identical");
            }

        } 
    }
    
    
}