using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\B\+359( |-)2(\1)[0-9]{3}(\1)[0-9]{4}\b";
            string input = Console.ReadLine();

            MatchCollection validNumbers = Regex.Matches(input, pattern);

            var matchedNumbers = validNumbers
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();


            Console.WriteLine(string.Join(", ", matchedNumbers));
        }
    }
}
