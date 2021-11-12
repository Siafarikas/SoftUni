using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string cond = Console.ReadLine();
            Predicate<int> evenOdd = cond == "odd"
                ? num => num % 2 != 0
                : new Predicate<int>((num) => num % 2 == 0);

            List<int> nums = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (evenOdd(i))
                {
                    nums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
