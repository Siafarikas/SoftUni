using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biscuits = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No More Money")
                {
                    break;
                }
                string[] parts = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string biscuit = parts[1];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < biscuits.Count; i++)
                    {
                        if (biscuits[i] == biscuit)
                        {
                            biscuits[i] = "None";  
                        };
                    }
                }
                else if (command == "Required")
                {
                    int index = int.Parse(parts[2]);
                    if (index >= biscuits.Count)
                    {
                        continue;
                    }
                    if (biscuits[index] != "None" && index >= 0)
                    {
                        biscuits[index] = biscuit;
                    }
                }
                else if (command == "Last")
                {
                    biscuits.Add(biscuit);
                }
            }
            biscuits = biscuits
                .Where(x => x != "None")
                .ToList();
            Console.WriteLine(String.Join(" ", biscuits));
        }
    }
}
