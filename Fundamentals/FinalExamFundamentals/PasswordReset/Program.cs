using System;
using System.Linq;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }
                string[] parts = command.Split(" ");
                string commandName = parts[0];

                if (commandName == "TakeOdd")
                {
                    StringBuilder odd = new StringBuilder();

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        odd.Append(password[i]);
                    }
                    password = odd.ToString();
                    Console.WriteLine(password);
                }
                else if (commandName == "Cut")
                {
                    int startIdx = int.Parse(parts[1]);
                    int length = int.Parse(parts[2]);

                    password = password.Remove(startIdx, length);
                    Console.WriteLine(password);
                }
                else
                {
                    string substring = parts[1];
                    string substitute = parts[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

            }
                Console.WriteLine($"Your password is: {password}");
        }
    }
}
