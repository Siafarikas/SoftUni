using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int j = 0; j < word.Length; j++)
                {
                    output += word;
                }
            }
            Console.WriteLine(output);
        }
    }
}
