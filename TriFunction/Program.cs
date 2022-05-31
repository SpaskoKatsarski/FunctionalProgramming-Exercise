using System;
using System.Linq;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isGreater = (name, sum) => name.ToCharArray().Select(ch => (int)ch).Sum() >= sum;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, sum, func) => arr.FirstOrDefault(str => func(str, sum));

            string result = firstValidName(names, charSum, isGreater);
            Console.WriteLine(result);
        }
    }
}
