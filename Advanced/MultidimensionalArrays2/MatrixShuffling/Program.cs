using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arr = ReadArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] parts = input.Split();
                string command = parts[0];
                if (command != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = int.Parse(parts[1]);
                int col1 = int.Parse(parts[2]);
                int row2 = int.Parse(parts[3]);
                int col2 = int.Parse(parts[4]);
                bool validCoordinates = true;
                if (row1 < 0 || row1 > matrix.GetLength(0) || row2 < 0 || row2 > matrix.GetLength(0) || 
                    col1 < 0 || col1 > matrix.GetLength(1) || col2 < 0 || col2 > matrix.GetLength(1))
                {
                    validCoordinates = false;
                }
                if (parts.Length > 5 || parts.Length < 0 || validCoordinates == false)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string value = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = value;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static string[] ReadArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
