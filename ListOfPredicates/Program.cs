using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> outputNums = new List<int>();

            for (int num = 1; num <= endOfRange; num++)
            {
                bool isDivisible = true;

                foreach (var divider in dividers)
                {
                    Predicate<int> predicate = n => n % divider == 0;

                    if (!predicate(num))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    outputNums.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", outputNums));
        }
    }
}
