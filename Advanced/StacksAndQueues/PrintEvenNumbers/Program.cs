using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenNums = new Queue<int>();
            foreach (var integer in input)
            {
                if (integer % 2 == 0)
                {
                    evenNums.Enqueue(integer);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
