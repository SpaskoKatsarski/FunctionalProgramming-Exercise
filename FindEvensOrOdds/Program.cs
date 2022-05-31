using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string option = Console.ReadLine();

            List<int> outputNums = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (option == "even")
                {
                    if (isEven(i))
                    {
                        outputNums.Add(i);
                    }
                }
                else
                {
                    if (!isEven(i))
                    {
                        outputNums.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', outputNums));
        }
    }
}
