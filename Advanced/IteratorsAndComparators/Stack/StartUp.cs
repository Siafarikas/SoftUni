using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comm = info[0];
                if (comm == "Push")
                {
                    stack.Push(info.Skip(1).Select(t => t.Split(',').First()).ToArray());
                }
                else if (comm == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
