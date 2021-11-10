using System;

namespace ReadText
{
    class ReadText
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(input);

                }
            }
        }
    }
}
