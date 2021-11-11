using System;

namespace RepeatString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeat(input, repetitions)); 
        }

        static string Repeat(string input, int repetitions)
        {
            string result = "";
            for (int i = 1; i <= repetitions; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
