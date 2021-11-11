using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                char[] word = input.ToCharArray();
                char[] reversed = word.Reverse().ToArray();
                string reversedWord = new string(reversed);

                Console.WriteLine($"{input} = {reversedWord}");
                input = Console.ReadLine();
            }
        }
    }
}
