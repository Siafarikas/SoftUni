using System;
using System.Linq;

namespace EvenOddSubstraction
{
    class EvenOddSubstraction
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
