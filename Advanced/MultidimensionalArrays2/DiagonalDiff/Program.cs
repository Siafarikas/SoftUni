using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sum1 = 0;
            int sum2 = 0;
            int idx = n - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == idx)
                    {
                        sum2 += arr[col];
                        idx--;
                    }
                    if (row == col)
                    {
                        sum1 += arr[col];
                    }
                    matrix[row, col] = arr[col];
                }
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
