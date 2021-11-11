using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] part = command.Split(" ");
                if (part[0] == "Add")
                {
                    numbers = AddNum(numbers, int.Parse(part[1]));
                }
                else if (part[0] == "Remove")
                {
                    numbers = RemoveNum(numbers, int.Parse(part[1]));
                }
                else if (part[0] == "RemoveAt")
                {
                    numbers = RemoveAtNum(numbers, int.Parse(part[1]));
                }
                else if (part[0] == "Insert")
                {
                    numbers = InsertNum(numbers, int.Parse(part[1]), int.Parse(part[2]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
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
    }
}
