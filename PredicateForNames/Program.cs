using System;

namespace PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> predicate = n => n.Length <= length;

            foreach (var name in names)
            {
                if (predicate(name))
                    Console.WriteLine(name);
            }
        }
    }
}
