using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> startsWith = (name, substring) => name.StartsWith(substring);
            Func<string, string, bool> endsWith = (name, substring) => name.EndsWith(substring);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!")
                {
                    break;
                }
                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string commandName = parts[1];
                string substring = parts[2];

                if (command == "Remove")
                {
                    switch (commandName)
                    {

                    }
                    for (int i = 0; i < people.Count; i++)
                    {

                    }
                }
                else if (command == "Double")
                {

                }

            }
        }
    }
}
