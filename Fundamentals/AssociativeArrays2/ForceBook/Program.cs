using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (input.Contains(" | "))
                {
                    string[] parts = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    forceSide = parts[0];
                    forceUser = parts[1];

                    if (!UserExists(forceUser, forceBook))
                    {
                        forceBook.Add(forceSide, new List<string> { forceUser });
                    }
                }
                else
                {
                    string[] parts = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    forceSide = parts[1];
                    forceUser = parts[0];
                    if (UserExists(forceUser, forceBook))
                    {
                        foreach (var member in forceBook)
                        {
                            if (member.Value.Contains(forceUser))
                            {
                                member.Value.Remove(forceUser);
                            }
                        }
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            forceBook = forceBook
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            if (forceBook.Any())
            {
                foreach (var item in forceBook)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    item.Value.Sort();
                    foreach (var member in item.Value)
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }

        static bool UserExists(string user, Dictionary<string, List<string>> forceBook)
        {
            foreach (var item in forceBook)
            {
                if (item.Value.Contains(user))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
