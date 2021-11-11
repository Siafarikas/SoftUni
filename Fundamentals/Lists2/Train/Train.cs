using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacityWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] parts = command.Split();
                if (parts[0] == "Add")
                {
                    wagons.Add(int.Parse(parts[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(parts[0]) <= capacityWagon)
                        {
                            wagons[i] += int.Parse(parts[0]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
