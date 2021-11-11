using System;
using System.Linq;
namespace MaxSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int longestSeq = 0;
            int bestNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int sequenceSize = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNum = arr[j];

                    if (currentNum == rightNum)
                    {
                        sequenceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceSize > longestSeq)
                {
                    longestSeq = sequenceSize;
                    bestNum = currentNum;
                }
            }
            for (int i = 0; i <= longestSeq; i++)
            {
                Console.Write($"{bestNum} ");
            }
        }
    }
}
