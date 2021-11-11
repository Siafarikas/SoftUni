using System;
using System.Collections.Generic;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();

            string output = string.Empty;
            char lastCharacter = '\0';
            foreach (var character in input)
            {
                if (!(character == lastCharacter))
                {
                    output += character;
                    lastCharacter = character;
                }
            }
            Console.WriteLine(output);
        }
    }
}
