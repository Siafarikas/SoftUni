using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(input);
            int startIdx = 0;
            int endIdx = n;

            while (children.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    children.Enqueue(children.Dequeue());
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is: {children.Dequeue()}");

        }
    }
}
