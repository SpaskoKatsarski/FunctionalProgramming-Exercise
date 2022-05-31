using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine($"Sir {n}");

            List<string> names = Console.ReadLine().Split().ToList();

            names.ForEach(print);
        }
    }
}
