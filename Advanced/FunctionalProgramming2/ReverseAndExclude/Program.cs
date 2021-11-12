using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> divisible = x => x % n != 0;

            Console.WriteLine(string.Join(" ",
                nums
                .Reverse()
                .Where(x => divisible(x))));
        }
    }
}
