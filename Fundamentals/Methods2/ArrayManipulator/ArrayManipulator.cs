using System;
using System.Linq;
namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] startingArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] parts = input.Split();
                string command = parts[0];
                switch (command)
                {
                    case "exchange":
                        if (int.Parse(parts[1]) >= startingArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            startingArray = ExchangeCommand(startingArray, int.Parse(parts[1]));
                        }
                        break;
                    case "max":
                    case "min":
                        Console.WriteLine(MinMaxOfArray(startingArray, parts[0], parts[1]));
                        break;
                    case "first":
                    case "last":
                        if (int.Parse(parts[1]) > startingArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            bool firstNum = true;
                            Console.Write("[");
                            foreach (var number in FirstLastElements(startingArray, parts[0], int.Parse(parts[1]), parts[2]))
                            {
                                if (number != -1)
                                {
                                    if (firstNum)
                                    {
                                        Console.Write($"{number}");
                                        firstNum = false;
                                    }
                                    else
                                    {
                                        Console.Write($", {number}");
                                    }
                                }
                            }
                            Console.WriteLine("]");

                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", startingArray)}]");
        }
        static int[] ExchangeCommand(int[] array, int rotations)
        {
            for (int i = 0; i <= rotations; i++)
            {
                int[] outputArr = new int[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == array.Length - 1)
                    {
                        outputArr[j] = array[0];
                        array = outputArr;
                    }
                    else
                    {
                        outputArr[j] = array[j + 1];
                    }
                }

            }
            return array;
        }
        static string MinMaxOfArray(int[] array, string minMax, string oddEven)
        {
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            int bestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (minMax == "max")
                {
                    int currentNum = array[i];
                    if (oddEven == "even")
                    {
                        if (currentNum >= minValue && currentNum % 2 == 0)
                        {
                            minValue = currentNum;
                            bestIndex = i;
                        }
                    }
                    else
                    {
                        if (currentNum >= minValue && currentNum % 2 == 1)
                        {
                            minValue = currentNum;
                            bestIndex = i;
                        }
                    }

                }
                else if (minMax == "min")
                {
                    int currentNum = array[i];
                    if (oddEven == "even")
                    {
                        if (currentNum <= maxValue && currentNum % 2 == 0)
                        {
                            maxValue = currentNum;
                            bestIndex = i;
                        }
                    }
                    else
                    {
                        if (currentNum <= maxValue && currentNum % 2 == 1)
                        {
                            maxValue = currentNum;
                            bestIndex = i;
                        }
                    }
                }
            }
            if (maxValue == int.MaxValue && minValue == int.MinValue)
            {
                return "No matches";
            }
            else
            {
                return bestIndex.ToString();
            }
        }
        static int[] FirstLastElements(int[] array, string firstLast, int count, string oddEven)
        {
            int[] resultArray = new int[count];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = -1;
            }
            if (firstLast == "first")
            {
                int k = 0;
                for (int i = 0; i < array.Length && k < 2; i++)
                {
                    if (oddEven == "even" && array[i] % 2 == 0)
                    {
                        resultArray[k] = array[i];
                        k++;
                    }
                    else if (oddEven == "odd" && array[i] % 2 == 1)
                    {
                        resultArray[k] = array[i];
                        k++;
                    }
                }
            }
            else if (firstLast == "last")
            {
                int k = 0;
                for (int i = array.Length - 1; i >= 0 && k < 2; i--)
                {
                    if (oddEven == "even" && array[i] % 2 == 0)
                    {
                        resultArray[k] = array[i];
                        k++;
                    }
                    else if (oddEven == "odd" && array[i] % 2 == 1)
                    {
                        resultArray[k] = array[i];
                        k++;
                    }
                }
            }
            if (firstLast == "first")
            {
                return resultArray;
            }
            else
            {
                return resultArray.Reverse().ToArray();
            }
        }
    }
}

