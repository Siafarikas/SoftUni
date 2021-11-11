using System;
using System.Linq;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstOutput = new int[n];
            int[] secondOutput = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] inputArr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstOutput[i] = inputArr[0];
                    secondOutput[i] = inputArr[1];
                }
                else
                {
                    firstOutput[i] = inputArr[1];
                    secondOutput[i] = inputArr[0];
                }

            }
            Console.WriteLine(string.Join(" ", firstOutput));
            Console.WriteLine(string.Join(" ", secondOutput));
        }
    }
}
