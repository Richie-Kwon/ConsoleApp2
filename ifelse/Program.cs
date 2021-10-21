using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const int diff = 0;
            const int first = 5;
            const int second = 3;

            string[] names = {"C", "C++"};
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            int sum = 0;
            for (int i=1; i <=100; i++ )
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                sum += i ;
            }



        }
    }
}