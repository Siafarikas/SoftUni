using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] parts = command.Split();
                if (parts[0] == "Add")
                {
                    numbers.Add(int.Parse(parts[1]));
                }
                else if (parts[0] == "Insert")
                {
                    if (IndexOutOfBound(numbers, int.Parse(parts[2])))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(parts[2]), int.Parse(parts[1]));
                    }
                }
                else if (parts[0] == "Remove")
                {
                    if (IndexOutOfBound(numbers, int.Parse(parts[1])))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(parts[1]));
                    }
                }
                else if (parts[0] == "Shift")
                {
                    if (parts[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(parts[2]); i++)
                        {
                            int firstNum = numbers[0];
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                if (j == numbers.Count - 1)
                                {
                                    numbers[j] = firstNum;
                                }
                                else
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                            }
                        }
                    }
                    else if (parts[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(parts[2]); i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j >= 0; j--)
                            {
                                if (j == 0)
                                {
                                    numbers[j] = lastNum;
                                }
                                else
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool IndexOutOfBound(List<int> numbers, int index)
        {
            bool indexOutOfBound = false;
            if (index >= numbers.Count || index < 0)
            {
                indexOutOfBound = true;
            }
            return indexOutOfBound;
        }
    }
}
