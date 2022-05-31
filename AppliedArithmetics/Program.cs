using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, List<int>> add = l => l.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> multiply = l => l.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtract = l => l.Select(x => x - 1).ToList();

            Action<List<int>> print = l => Console.WriteLine(string.Join(" ", l));

            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
