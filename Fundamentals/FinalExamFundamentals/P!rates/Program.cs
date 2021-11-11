using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();

            while (true)
            {
                if (input == "Sail")
                {
                    break;
                }
                string[] parts = input.Split("||");
                string townName = parts[0];
                int population = int.Parse(parts[1]);
                int gold = int.Parse(parts[2]);

                if (towns.ContainsKey(townName))
                {
                    towns[townName][0] += population;
                    towns[townName][1] += gold;
                    input = Console.ReadLine();
                    continue;
                }
                towns.Add(townName, new List<int> { population, gold });
                input = Console.ReadLine();
            }

            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split("=>");
                string action = parts[0];
                string townName = parts[1];

                if (action == "Plunder")
                {
                    int population = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);

                    towns[townName][0] -= population;
                    towns[townName][1] -= gold;

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {population} citizens killed.");
                    if (towns[townName][0] == 0 || towns[townName][1] == 0)
                    {
                        towns.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(parts[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    towns[townName][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {towns[townName][1]} gold.");
                }
            }

            if (towns.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                towns = towns
                    .OrderByDescending(x => x.Value[1])
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var kvp in towns)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
                }
            }


        }
    }
}
