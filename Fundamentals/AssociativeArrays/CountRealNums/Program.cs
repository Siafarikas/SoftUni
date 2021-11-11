using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            foreach (var number in input)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
