using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] initialArray = { 0, 1, 0 };

            for (int i = 0; i < rows; i++)
            {
                int[] nextRow = new int[initialArray.Length + 1];
                if (i == 0)
                {
                    Console.WriteLine(1);
                    continue;
                }
                for (int j = 0; j < nextRow.Length; j++)
                {
                    if (j == 0 || j == nextRow.Length - 1)
                    {
                        nextRow[j] = 0;
                    }
                    else
                    {
                        nextRow[j] = initialArray[j - 1] + initialArray[j];
                    }
                }
                for (int k = 1; k < nextRow.Length - 1; k++)
                {
                    Console.Write($"{nextRow[k]} ");
                }
                Console.WriteLine();
                initialArray = nextRow;
            }
        }
    }
}
