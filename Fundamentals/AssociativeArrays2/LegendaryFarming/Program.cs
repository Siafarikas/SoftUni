using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>()
            {
                { "shards", 0},
                { "fragments", 0},
                { "motes", 0}
            };

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            bool legendaryObtained = false;
            string legendaryItemObtained = string.Empty;
            while (!legendaryObtained)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();

                    if (legendaryMaterials.ContainsKey(item))
                    {
                        legendaryMaterials[item] += quantity;

                        if (legendaryMaterials[item] >= 250)
                        {
                            legendaryMaterials[item] -= 250;
                            legendaryObtained = true;
                            legendaryItemObtained = item;
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(item))
                        {
                            junkMaterials[item] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(item, quantity);
                        }
                    }
                }
            }

            if (legendaryItemObtained == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legendaryItemObtained == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (legendaryItemObtained == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            Dictionary<string, int> sortedLegendaries = legendaryMaterials
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var material in sortedLegendaries)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
