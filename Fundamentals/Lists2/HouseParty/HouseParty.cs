using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int guestNumbers = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < guestNumbers; i++)
            {
                string message = Console.ReadLine();
                string[] parts = message.Split();

                if (parts[2] == "not")
                {
                    if (ChecksIfOnList(guests, parts[0]))
                    {
                        guests.Remove(parts[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{parts[0]} is not in the list!");
                    }
                }
                else
                {
                    if (ChecksIfOnList(guests, parts[0]))
                    {
                        Console.WriteLine($"{parts[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(parts[0]);
                    }
                }
            }
            foreach (var name in guests)
            {
                Console.WriteLine(name);
            }
        }

        static bool ChecksIfOnList(List<string> guests, string guest)
        {
            bool isOnTheList = false;
            foreach (var name in guests)
            {
                if (name == guest)
                {
                    isOnTheList = true;
                }
            }
            return isOnTheList;
        }
    }
}
