using System;
using System.Linq;
using System.Collections.Generic;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> rooms = input
                .Split('|')
                .ToList();

            int hp = 100;
            int bitcoins = 0;
            int roomCount = 0;
            foreach (var room in rooms)
            {
                roomCount++;
                string[] parts = room
                    .Split(" ")
                    .ToArray();
                string command = parts[0];
                int number = int.Parse(parts[1]);

                if (command == "potion")
                {
                    hp += number;
                    int hpHealed = number;
                    if (hp > 100)
                    {
                        hpHealed = number - (hp - 100);
                    }
                    if (hp > 100)
                    {
                        hp = 100;
                    }
                    Console.WriteLine($"You healed for {hpHealed} hp.");
                    Console.WriteLine($"Current health: {hp} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    hp -= number;
                    if (hp <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomCount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }
            }
            if (hp > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {hp}");
            }
        }
    }
}
