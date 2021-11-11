using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] characters = input
                .Where(x => x != ' ')
                .ToArray();

            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach (var chars in characters)
            {
                if (counter.ContainsKey(chars))
                {
                    counter[chars]++;
                }
                else
                {
                    counter.Add(chars, 1);
                }
            }
            foreach (var letter in counter)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
