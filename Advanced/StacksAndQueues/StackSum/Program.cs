using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> intStack = new Stack<int>();
            foreach (var integer in ints)
            {
                intStack.Push(integer);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                string[] parts = input.Split();
                string command = parts[0].ToLower();

                if (command == "add")
                {
                    int firstNum = int.Parse(parts[1]);
                    int secondNum = int.Parse(parts[2]);
                    intStack.Push(firstNum);
                    intStack.Push(secondNum);
                }
                else
                {
                    int count = int.Parse(parts[1]);
                    if (count > intStack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        intStack.Pop();
                    }
                }
            }

            int sum = 0;
            foreach (var integer in intStack)
            {
                sum += integer;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
