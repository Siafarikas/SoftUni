using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            int lastCupidPosition = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Love!")
                {
                    break;
                }

                string[] parts = command.Split();
                int jumpLength = int.Parse(parts[1]);

                int houseIndex = lastCupidPosition + jumpLength;
                lastCupidPosition = houseIndex;
                if (lastCupidPosition >= houses.Count)
                {
                    lastCupidPosition = 0;
                    houseIndex = 0;
                }
                if (houses[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                    continue;
                }
                houses[houseIndex] -= 2;
                if (houses[houseIndex] <= 0)
                {
                    Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                }
            }

            int failedHouses = 0;
            foreach (var house in houses)
            {
                if (house > 0)
                {
                    failedHouses++;
                }
            }
            Console.WriteLine($"Cupid's last position was {lastCupidPosition}.");
            if (failedHouses == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}
