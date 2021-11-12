using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, n];
            for (int row = 0; row < n; row++)
            {
                double[] arr = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            string input = Console.ReadLine();
            string[] bombs = input.Split(" ");

            for (int i = 0; i < bombs.Length; i++)
            {
                string[] coords = bombs[i]
                    .Split(",");
                int row = int.Parse(coords[0]);
                int col = int.Parse(coords[1]);

                if (matrix[row, col] > 0)
                {
                    double value = matrix[row, col];
                    matrix = BombExplodes(row, col, value, matrix);
                    matrix[row, col] = 0;
                }
            }
            int aliveCells = 0;
            double sum = 0;
            foreach (var element in matrix)
            {
                if (element > 0)
                {
                    aliveCells++;
                    sum += element;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static double[,] BombExplodes(int row, int col, double value, double[,] matrix)
        {
            if (ValidCoords(row - 1, col - 1, matrix))
            {
                if (matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }
            }
            if (ValidCoords(row - 1, col, matrix))
            {
                if (matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= value;
                }
            }
            if (ValidCoords(row - 1, col + 1, matrix))
            {
                if (matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= value;
                }
            }
            if (ValidCoords(row, col - 1, matrix))
            {
                if (matrix[row, col - 1] > 0)
                {
                    matrix[row, col - 1] -= value;
                }
            }

            if (ValidCoords(row, col + 1, matrix))
            {
                if (matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= value;
                }
            }
            if (ValidCoords(row + 1, col - 1, matrix))
            {
                if (matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }
            }
            if (ValidCoords(row + 1, col, matrix))
            {
                if (matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }
            }
            if (ValidCoords(row + 1, col + 1, matrix))
            {
                if (matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }
            }

            return matrix;

        }

        private static bool ValidCoords(int row, int col, double[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
