using System;

namespace NxNMatrix
{
    class NxNMatrix
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintsMatrix(number);
        }

        static void PrintsMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
