using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> actualGuests = new HashSet<string>();

            string input = Console.ReadLine();
            bool over = false;
            while (true)
            {
                if (input == "PARTY")
                {
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (guests.Contains(input))
                        {
                            actualGuests.Add(input);
                            guests.Remove(input);
                        }
                        if (input == "END")
                        {
                            over = true;
                            break;
                        }
                    }
                    if (over == true)
                    {
                        break;
                    }
                }
                else if (input == "End")
                {
                    break;
                }
                else
                {
                    guests.Add(input);
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine(guests.Count);
            foreach (var res in guests)
            {
                if (char.IsDigit(res[0]))
                {
                    Console.WriteLine(res);
                }
            }
            foreach (var res in guests)
            {
                if (!char.IsDigit(res[0]))
                {
                    Console.WriteLine(res);
                }
            }
        }
    }
}
