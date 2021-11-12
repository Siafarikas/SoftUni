using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" -> ");
                string color = parts[0];
                string[] items = parts[1]
                    .Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item]++;
                    }
                    else
                    {
                        wardrobe[color].Add(item, 1);
                    }
                }
            }
            string[] search = Console.ReadLine()
                .Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var kvp in color.Value)
                {
                    if (kvp.Key == search[1] && color.Key == search[0])
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
