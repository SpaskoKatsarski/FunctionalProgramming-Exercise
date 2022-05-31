using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int number = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % number == 0;

            Console.WriteLine(string.Join(' ', numbers.Where(x => !isDivisible(x))));
        }
    }
}
