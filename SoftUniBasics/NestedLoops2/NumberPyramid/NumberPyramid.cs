using System;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int currNum = 1;
            for (int rows = 1; rows <= targetNum; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(currNum + " ");
                    currNum++;
                    if (currNum > targetNum)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
