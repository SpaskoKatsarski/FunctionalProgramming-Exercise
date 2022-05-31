using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> getMinValue = x => x.Min();

            Console.WriteLine(getMinValue(numbers));
        }
    }
}
