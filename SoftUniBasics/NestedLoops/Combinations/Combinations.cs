using System;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            int variations = 0;
            int currentResult = 0;
            for (int x = 0; x <= result; x++)
            {
                for (int y = 0; y <= result; y++)
                {
                    for (int z = 0; z <= result; z++)
                    {
                        currentResult = x + y + z;
                        if (currentResult == result)
                        {
                            variations++;
                        }
                    }
                }
            }
            Console.WriteLine(variations);
        }
    }
}
