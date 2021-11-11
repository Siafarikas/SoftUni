using System;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                PrintLine(i);
            }

            for (int i = input - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
