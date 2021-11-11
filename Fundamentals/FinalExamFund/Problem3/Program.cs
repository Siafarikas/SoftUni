using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] commandSeperation = input
                    .Split();
                string command = commandSeperation[0];
                if (command == "EndDay")
                {
                    break;
                }
                string info = commandSeperation[1];
                string[] parts = info.Split("-");
                string animalName = parts[0];
                int food = int.Parse(parts[1]);

                if (command == "Add:")
                {
                    if (animals.ContainsKey(animalName))
                    {
                        animals[animalName] += food;
                        continue;
                    }
                    animals.Add(animalName, food);
                    string area = parts[2];
                    if (areaAnimals.ContainsKey(area))
                    {
                        areaAnimals[area].Add(animalName);
                    }
                    else
                    {
                        areaAnimals.Add(area, new List<string> { animalName });
                    }
                }
                else if (command == "Feed:")
                {
                    if (!animals.ContainsKey(animalName))
                    {
                        continue;
                    }
                    animals[animalName] -= food;
                    if (animals[animalName] <= 0)
                    {
                        Console.WriteLine($"{animalName} was successfully fed");
                        animals.Remove(animalName);
                        foreach (var list in areaAnimals.Values)
                        {
                            if (list.Contains(animalName))
                            {
                                list.Remove(animalName);
                                break;
                            }
                        }
                    }
                }
            }

            animals = animals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Animals:");
            foreach (var kvp in animals)
            {
                Console.WriteLine($" {kvp.Key} -> {kvp.Value}g");
            }

            areaAnimals = areaAnimals
                .Where(x=> x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Areas with hungry animals:");
            foreach (var kvp in areaAnimals)
            {
                Console.WriteLine($" {kvp.Key}: {kvp.Value.Count}");
            }
        }
    }
}
