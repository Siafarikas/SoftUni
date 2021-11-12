using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadArray();

            int[,] matrix = new int[size[0], size[1]];

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = ReadArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += arr[j];
                    matrix[i, j] = arr[j];
                }
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);

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
