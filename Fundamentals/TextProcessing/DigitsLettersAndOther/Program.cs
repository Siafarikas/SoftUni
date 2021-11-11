using System;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();
            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;
            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    digits += character;
                }
                else if (char.IsLetter(character))
                {
                    letters += character;
                }
                else
                {
                    other += character;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
