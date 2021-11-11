using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Go Shopping!")
                {
                    Console.WriteLine(String.Join(", ", shoppingList));
                    break;
                }
                string[] parts = input
                    .Split(" ");
                string command = parts[0];
                string item = parts[1];

                if (command == "Urgent")
                {
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string oldItem = parts[1];
                    string newItem = parts[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        int idx = shoppingList.IndexOf(oldItem);
                        shoppingList.Remove(oldItem);
                        shoppingList.Insert(idx, newItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }
            }
        }
    }
}
