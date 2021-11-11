using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int output = CharacterMultiplier(input[0], input[1]);
            Console.WriteLine(output);
        }

        private static int CharacterMultiplier(string str1, string str2)
        {
            int sum = 0;
            int shorterStr = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < shorterStr; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (shorterStr == str1.Length)
            {
                for (int i = shorterStr; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            else
            {
                for (int i = shorterStr; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            return sum;
        }
    }
}
