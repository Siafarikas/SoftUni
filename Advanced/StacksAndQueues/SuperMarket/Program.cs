using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> line = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input == "Paid")
                {
                    foreach (var person in line)
                    {
                        Console.WriteLine(person);
                    }
                    line.Clear();
                    continue;
                }
                line.Enqueue(input);
            }
            Console.WriteLine($"{line.Count}");
        }
    }
}
