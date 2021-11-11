using System;
using System.Linq;

namespace CondenseArrayToNum
{
    class CondenseArrayToNum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                int[] conNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    conNumbers[i] = numbers[i] + numbers[i + 1];
                }
                numbers = conNumbers;
                if (numbers.Length == 1)
                {
                    Console.WriteLine(string.Join(" ", conNumbers));
                    return;
                }
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
