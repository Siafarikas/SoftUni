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

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIdx = row;
                        colIdx = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[rowIdx, colIdx]} {matrix[rowIdx, colIdx + 1]}"); 
            Console.WriteLine($"{matrix[rowIdx + 1, colIdx]} {matrix[rowIdx + 1, colIdx + 1]}");
            Console.WriteLine(maxSum);

        }

        private static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
        }
    }
}
