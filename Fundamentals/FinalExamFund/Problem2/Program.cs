using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"(.)+>[0-9]{3}\|[a-z]{3}\|[A-Z]{3}\|[^><]{3}<(\1)+";
                Match validPassword = Regex.Match(input, pattern);
                if (validPassword.Success)
                {
                    string substring = input.Substring(input.IndexOf('>') + 1, 15);
                    string[] parts = substring.Split("|");
                    StringBuilder encryption = new StringBuilder();
                    foreach (var item in parts)
                    {
                        encryption.Append(item);
                    }
                    Console.WriteLine($"Password: {encryption}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
