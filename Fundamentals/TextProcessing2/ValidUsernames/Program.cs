using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> validUsernames = new List<string>();

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16 && ContainsChars(username))
                {
                    validUsernames.Add(username);
                }
            }

            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }

        static bool ContainsChars(string username)
        {
            foreach (var letter in username)
            {
                if (!char.IsLetterOrDigit(letter) &&
                    letter != '-' &&
                    letter != '_')
                {
                    return false;
                }
            }
            return true;
        }

    }
}
