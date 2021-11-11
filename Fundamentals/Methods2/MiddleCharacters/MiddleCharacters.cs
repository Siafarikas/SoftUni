using System;

namespace MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReturnsMiddleChar(input)); 
        }

        static string ReturnsMiddleChar(string input)
        {
            string result;
            if (input.Length % 2 == 0)
            {
                char char1 = input[input.Length / 2 - 1];
                char char2 = input[input.Length / 2];
                result = string.Concat(char1, char2);
            }
            else
            {
                char char1 = input[input.Length / 2];
                result = new string(char1, 1);
            }
            return result;
        }
    }
}
