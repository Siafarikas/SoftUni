using System;
using System.Linq;
using System.Collections.Generic;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLootBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var secondLootBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var claimedItems = new List<int>();
            while (firstLootBox.Count > 0 && secondLootBox.Count > 0)
            {
                int sum = firstLootBox.Peek() + secondLootBox.Peek();
                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }

            if (firstLootBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }
        }
    }
}
