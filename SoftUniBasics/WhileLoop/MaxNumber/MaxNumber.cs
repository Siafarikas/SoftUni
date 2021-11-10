using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number >= maxNum)
                {
                    maxNum = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);

        }
    }
}
