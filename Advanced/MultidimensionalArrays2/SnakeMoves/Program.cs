using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];
            char[] arr = Console.ReadLine()
                .ToCharArray();
            int idxCounter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = arr[idxCounter];
                        idxCounter++;
                        if (idxCounter >= arr.Length)
                        {
                            idxCounter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = arr[idxCounter];
                        idxCounter++;
                        if (idxCounter >= arr.Length)
                        {
                            idxCounter = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
