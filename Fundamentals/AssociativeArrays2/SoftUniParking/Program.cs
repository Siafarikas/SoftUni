using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredCars = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split();
                string action = commandParts[0];
                string user = commandParts[1];

                if (action == "register")
                {
                    string licensePlate = commandParts[2];
                    if (registeredCars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        registeredCars.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }

                }
                else
                {
                    if (!registeredCars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        registeredCars.Remove(user);
                    }
                }
            }

            foreach (var registration in registeredCars)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
