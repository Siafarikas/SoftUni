using System;
using System.Linq;
namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] firstNumsArray = new int[inputArray.Length / 4];
            for (int i = 0; i < firstNumsArray.Length; i++)
            {
                firstNumsArray[i] = inputArray[i];
            }
            Array.Reverse(firstNumsArray);

            int[] lastNumsArray = new int[inputArray.Length / 4];
            for (int i = 0; i < lastNumsArray.Length; i++)
            {
                lastNumsArray[i] = inputArray[inputArray.Length - 1 - i];
            }

            int[] firstRow = firstNumsArray.Concat(lastNumsArray).ToArray();

            int[] secondRow = new int[inputArray.Length / 2];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = inputArray[inputArray.Length / 4 + i];
            }

            int[] result = new int[inputArray.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
