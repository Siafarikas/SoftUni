using System;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= lines; i++)
            {
                char input = Console.ReadLine()[0];
                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
