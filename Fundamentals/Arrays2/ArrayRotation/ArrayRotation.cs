using System;
using System.Linq;
namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rotations; i++)
            {
                int[] outputArr = new int[arr.Length];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == arr.Length - 1)
                    {
                        outputArr[j] = arr[0];
                        arr = outputArr;
                    }
                    else
                    {
                        outputArr[j] = arr[j + 1];
                    }
                }

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
