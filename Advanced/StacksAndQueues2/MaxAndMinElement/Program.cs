using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> intStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input
                    .Split();
                string command = tokens[0];

                if (command == "1")
                {
                    int x = int.Parse(tokens[1]);
                    intStack.Push(x);
                }
                else if (command == "2")
                {
                    if (intStack.Count < 1)
                    {
                        continue;
                    }
                    intStack.Pop();
                }
                else if (command == "3")
                {
                    if (intStack.Count < 1)
                    {
                        continue;
                    }
                    Console.WriteLine(intStack.Max());
                }
                else
                {
                    if (intStack.Count < 1)
                    {
                        continue;
                    }
                    Console.WriteLine(intStack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", intStack));
        }
    }
}
