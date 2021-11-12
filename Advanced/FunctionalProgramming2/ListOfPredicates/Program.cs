using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 1; i <= upperBound; i++)
            {
                nums.Add(i);
            }

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int, bool> divisible = n => CheckIfDivisibleBy(dividers, n);

            Console.WriteLine(string.Join(" ", nums.Where(x => divisible(x))));
        }

        private static bool CheckIfDivisibleBy(int[] dividers, int number)
        {
            foreach (var divider in dividers)
            {
                if (number % divider == 0)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
