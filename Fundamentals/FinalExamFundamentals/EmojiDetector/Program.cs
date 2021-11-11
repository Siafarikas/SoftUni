using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int coolThreshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (char.IsDigit(current))
                {
                    int digit = int.Parse(current.ToString());
                    coolThreshold *= digit;
                }
            }

            string pattern = @"([:]{2}|[*]{2})([A-Z][a-z]{2,})\1";


            MatchCollection validEmojis = Regex.Matches(input, pattern);

            var matchedEmojis = validEmojis
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            List<string> output = new List<string>(); 

            foreach (var emoji in matchedEmojis)
            {
                int coolness = 0;
                foreach (var letter in emoji)
                {
                    if (char.IsLetter(letter))
                    {
                        coolness += letter;
                    }
                }
                if (coolness > coolThreshold)
                {
                    output.Add(emoji);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", output));
        }
    }
}
