using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                string wordLowerCase = word.ToLower();
                if (words.ContainsKey(wordLowerCase))
                {
                    words[wordLowerCase]++;
                }
                else
                {
                    words.Add(wordLowerCase, 1);
                }
            }
            foreach (var word in words)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
