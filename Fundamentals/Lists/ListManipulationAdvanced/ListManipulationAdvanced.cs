using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            string command = Console.ReadLine();
            bool listChanged = false;
            while (command != "end")
            {
                string[] parts = command.Split(" ");
                if (parts[0] == "Add")
                {
                    numbers = AddNum(numbers, int.Parse(parts[1]));
                    listChanged = true;
                }
                else if (parts[0] == "Remove")
                {
                    numbers = RemoveNum(numbers, int.Parse(parts[1]));
                    listChanged = true;
                }
                else if (parts[0] == "RemoveAt")
                {
                    numbers = RemoveAtNum(numbers, int.Parse(parts[1]));
                    listChanged = true;
                }
                else if (parts[0] == "Insert")
                {
                    numbers = InsertNum(numbers, int.Parse(parts[1]), int.Parse(parts[2]));
                    listChanged = true;
                }
                else if (parts[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(parts[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (parts[0] == "PrintEven")
                {
                    List<int> evenNums = new List<int>();
                    foreach (var num in numbers)
                    {
                        if (num % 2 == 0)
                        {
                            evenNums.Add(num);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenNums));
                }
                else if (parts[0] == "PrintOdd")
                {
                    List<int> oddNums = new List<int>();
                    foreach (var num in numbers)
                    {
                        if (num % 2 == 1)
                        {
                            oddNums.Add(num);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNums));
                }
                else if (parts[0] == "GetSum")
                {
                    int sum = 0;
                    foreach (var num in numbers)
                    {
                        sum += num;
                    }
                    Console.WriteLine(sum);
                }
                else if (parts[0] == "Filter")
                {
                    Console.WriteLine(string.Join(" ", Filter(numbers, parts[1], int.Parse(parts[2]))));
                }
                command = Console.ReadLine();
            }
            if (listChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }


        static List<int> AddNum(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }
        static List<int> RemoveNum(List<int> numbers, int number)
        {
            numbers.Remove(number);
            return numbers;
        }
        static List<int> RemoveAtNum(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
            return numbers;
        }
        static List<int> InsertNum(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
            return numbers;
        }

        static List<int> Filter(List<int> numbers, string command, int number)
        {
            List<int> filteredNums = new List<int>();
            foreach (var num in numbers)
            {
                if (command == "<")
                {
                    if (num < number)
                    {
                        filteredNums.Add(num);
                    }
                }
                else if (command == ">")
                {
                    if (num > number)
                    {
                        filteredNums.Add(num);
                    }
                }
                else if (command == "<=")
                {
                    if (num <= number)
                    {
                        filteredNums.Add(num);
                    }
                }
                else if (command == ">=")
                {
                    if (num >= number)
                    {
                        filteredNums.Add(num);
                    }
                }
            }
            return filteredNums;
        }
    }
}
