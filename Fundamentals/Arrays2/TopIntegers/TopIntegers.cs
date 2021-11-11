using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i== arr.Length - 1)
                {
                    Console.Write($"{arr[i]} ");
                    return;
                }
                for (index = i+1; index < arr.Length; index++)
                {
                    if (arr[i] > arr[index])
                    {
                        if (index == arr.Length - 1)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
