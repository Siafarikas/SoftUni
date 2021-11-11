using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomWords
{
    class RandomWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rng = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int positon = rng.Next(words.Length);

                string word = words[i];
                words[i] = words[positon];
                words[positon] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
