using System;

namespace CharsInRange
{
    class CharsInRange
    {
        static void Main(string[] args)
        {
            char start = Console.ReadLine()[0];
            char end = Console.ReadLine()[0];

            PrintsAllCharsBetweenTwoChars(start, end);
        }

        static void PrintsAllCharsBetweenTwoChars(char start, char end)
        {
            if ((int)start < (int)end)
            {
                for (int i = (int)start + 1; i < (int)end; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = (int)end + 1; i < (int)start; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
