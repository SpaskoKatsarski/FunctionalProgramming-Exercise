using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = n => Console.WriteLine(n);

            List<string> names = Console.ReadLine().Split().ToList();

            names.ForEach(printName);
        }
    }
}
