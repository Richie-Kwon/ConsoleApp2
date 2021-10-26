using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Threading;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = null;
            s = "Hello";
            

            string empty = "";

            Nullable<bool> bln = null;
            Console.WriteLine(bln.HasValue);

            int? i = null;

            string s2 = null;

            empty = s2 ?? "change the value"; //if it is null >> change the value"
            Console.WriteLine(empty);

            double? d = 1.0;
            Console.WriteLine(d?.ToString());

            List<string> list22 = null;
            int? aa = list22?.Count;
            Console.WriteLine(aa);

            // int bb = list22?.Count ?? 0; 







        }
    }
}