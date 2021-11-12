using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> uppercaseChecker = n => char.IsUpper(n[0]);

            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(uppercaseChecker)
                .ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }

        }
    }
}
