using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> intStack = new Stack<int>(nums);
            for (int i = 0; i < values[1]; i++)
            {
                intStack.Pop();
            }
            if (intStack.Count < 1)
            {
                Console.WriteLine("0");
                return;
            }
            if (intStack.Contains(values[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestNum = int.MaxValue;
                foreach (var integer in intStack)
                {
                    if (integer < smallestNum)
                    {
                        smallestNum = integer;
                    }
                }
                Console.WriteLine(smallestNum);
            }
        }
    }
}
