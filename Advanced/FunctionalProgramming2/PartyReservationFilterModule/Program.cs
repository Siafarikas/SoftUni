using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> filters = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }
                string[] parts = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == "Add filter")
                {
                    filters.Add(parts[1] + " " + parts[2]);
                }
                else if (parts[0] == "Remove filter")
                {
                    filters.Remove(parts[1] + " " + parts[2]);
                }
            }

            foreach (var filter in filters)
            {
                string[] parts = filter.Split(" ");
                if (parts[0] == "Starts")
                {
                    invites = invites.Where(p=> !p.StartsWith((parts[2]))).ToList();
                }
                else if (parts[0] == "Ends")
                {
                    invites = invites.Where(p => !p.EndsWith((parts[2]))).ToList();
                }
                else if (parts[0] == "Length")
                {
                    invites = invites.Where(p => p.Length != int.Parse(parts[1])).ToList();
                }
                else if (parts[0] == "Contains")
                {
                    invites = invites.Where(p => !p.Contains(parts[1])).ToList();
                }
            }

            if (invites.Any())
            {
                Console.WriteLine(string.Join(" ", invites));
            }
        }
    }
}
