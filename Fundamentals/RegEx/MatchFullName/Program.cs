using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\w\b";
            string input = Console.ReadLine();

            MatchCollection matchingNames = Regex.Matches(input, regex);

            foreach (Match name in matchingNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
