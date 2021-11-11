using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] parts = Console.ReadLine()
                    .Split(" - ");
                string command = parts[0];
                if (command == "Craft!")
                {
                    Console.WriteLine(String.Join(", ", inventory));
                    break;
                }
                string item = parts[1];

                if (command == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] oldNew = item.Split(":");
                    string oldItem = oldNew[0];
                    string newItem = oldNew[1];

                    if (inventory.Contains(oldItem))
                    {
                        int idx = inventory.IndexOf(oldItem);
                        inventory.Insert(idx + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
            }
        }
    }
}
