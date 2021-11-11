using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerals = new Dictionary<string, int>();

            while (true)
            {
                string mineral = Console.ReadLine();
                if (mineral == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!minerals.ContainsKey(mineral))
                {
                    minerals.Add(mineral, quantity);
                }
                else
                {
                    minerals[mineral] += quantity;
                }
            }
            foreach (var mineral in minerals)
            {
                Console.WriteLine($"{mineral.Key} -> {mineral.Value}");
            }
        }
    }
}
