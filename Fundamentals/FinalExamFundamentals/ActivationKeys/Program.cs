using System;
using System.Linq;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Generate")
                {
                    break;
                }

                string[] parts = command.Split(">>>");
                string commandName = parts[0];
                string commandAction = parts[1];

                if (commandName == "Contains")
                {
                    if (rawKey.Contains(commandAction))
                    {
                        Console.WriteLine($"{rawKey} contains {commandAction}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandName == "Flip")
                {
                    int startIdx = int.Parse(parts[2]);
                    int endIdx = int.Parse(parts[3]);

                    if (commandAction == "Upper")
                    {
                        string oldSubstring = rawKey.Substring(startIdx, endIdx - startIdx);
                        rawKey = rawKey.Replace(oldSubstring, oldSubstring.ToUpper());
                    }
                    else
                    {
                        string oldSubstring = rawKey.Substring(startIdx, endIdx - startIdx);
                        rawKey = rawKey.Replace(oldSubstring, oldSubstring.ToLower());
                    }
                    Console.WriteLine(rawKey);
                }
                else
                {
                    int startIdx = int.Parse(parts[1]);
                    int endIdx = int.Parse(parts[2]);

                    rawKey = rawKey.Remove(startIdx, endIdx - startIdx);
                    Console.WriteLine(rawKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
