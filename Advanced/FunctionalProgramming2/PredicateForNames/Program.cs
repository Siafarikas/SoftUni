using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Predicate<string> predicate = name => name.Length <= length;

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => predicate(x))
                .ToList()
                .ForEach(x=> Console.WriteLine(x));
        }
    }
}
