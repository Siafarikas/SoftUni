using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double sum = 0;
            foreach (var part in input)
            {
                sum += LettersChangeNum(part);
            }
            Console.WriteLine($"{sum:f2}");
        }

        static double LettersChangeNum(string part)
        {
            char firstLetter = part[0];
            int indexFirst = char.ToUpper(firstLetter) - 64;
            char lastLetter = part[part.Length - 1];
            int indexLast = char.ToUpper(lastLetter) - 64;
            double number = double.Parse(part.Substring(1, part.Length - 2));
            
            if (char.IsUpper(firstLetter))
            {
                number /= indexFirst;
            }
            else
            {
                number *= indexFirst;

            }

            if (char.IsUpper(lastLetter))
            {
                number -= indexLast;
            }
            else
            {
                number += indexLast;
            }

            return number;
        }
    }
}
