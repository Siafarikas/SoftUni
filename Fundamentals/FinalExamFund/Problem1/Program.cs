using System;
using System.Text;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Complete")
                {
                    break;
                }

                string[] parts = input.Split();

                if (input.Contains("Make Upper"))
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                else if (input.Contains("Make Lower"))
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                else if (input.Contains("GetDomain"))
                {
                    int count = int.Parse(parts[1]);

                    string domain = email.Substring(email.Length - count);
                    Console.WriteLine(domain);
                }
                else if (input.Contains("GetUsername"))
                {
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        int indexOf = email.IndexOf("@");
                        string username = email.Substring(0, indexOf);
                        Console.WriteLine(username);
                    }
                }
                else if (input.Contains("Replace"))
                {
                    char replacement = char.Parse(parts[1]);
                    email = email.Replace(replacement, '-');
                    Console.WriteLine(email);
                }
                else if (input.Contains("Encrypt"))
                {
                    StringBuilder encryption = new StringBuilder();
                    foreach (var character in email)
                    {
                        encryption.Append($"{(int)character} ");
                    }
                    Console.WriteLine(encryption.ToString());
                }
            }
        }
    }
}
