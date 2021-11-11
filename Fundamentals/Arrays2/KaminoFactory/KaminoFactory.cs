using System;
using System.Linq;

namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int inputLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int BestSequence = 0;
            int bestDnaSum = 0;
            int bestDnaIndex = 0;
            int bestSample = 0;
            int[] bestSeq = new int[inputLength];

            int sample = 0;
            while (input != "Clone them!")
            {
                sample++;
                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentSum = 0;
                foreach (var number in arr)
                {
                    currentSum += number;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    int currentNum = arr[i];
                    int sequenceSize = 1;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int rightNum = arr[j];
                        if (currentNum == 0)
                        {
                            break;
                        }
                        if (currentNum == rightNum)
                        {
                            sequenceSize++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (sequenceSize > BestSequence)
                    {
                        BestSequence = sequenceSize;
                        bestDnaIndex = i;
                        bestDnaSum = currentSum;
                        bestSeq = arr;
                        bestSample = sample;
                    }
                    else if (sequenceSize == BestSequence)
                    {
                        if (i < bestDnaIndex)
                        {
                            BestSequence = sequenceSize;
                            bestDnaIndex = i;
                            bestDnaSum = currentSum;
                            bestSeq = arr;
                            bestSample = sample;
                        }
                        else if (i == bestDnaIndex && currentSum > bestDnaSum)
                        {
                            BestSequence = sequenceSize;
                            bestDnaIndex = i;
                            bestDnaSum = currentSum;
                            bestSeq = arr;
                            bestSample = sample;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(" ", bestSeq));
        }
    }
}
