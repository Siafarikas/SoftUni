using System;
using System.Linq;
namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIdx = 0;
            int colIdx = 0;

            for (int row = 0; row < sizes[0] - 2; row++)
            {
                for (int col = 0; col < sizes[1] - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIdx = row;
                        colIdx = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowIdx; i <= rowIdx + 2; i++)
            {
                for (int j = colIdx; j <= colIdx + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"{matrix[rowIdx, colIdx]} {matrix[rowIdx, colIdx + 1]} {matrix[rowIdx, colIdx + 2]}");
            //Console.WriteLine($"{matrix[rowIdx + 1, colIdx]} {matrix[rowIdx + 1, colIdx + 1]} {matrix[rowIdx + 1, colIdx + 2]}");
            //Console.WriteLine($"{matrix[rowIdx + 2, colIdx]} {matrix[rowIdx + 2, colIdx + 1]} {matrix[rowIdx + 2, colIdx + 2]}");
        }

        private static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
