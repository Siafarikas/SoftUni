using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            IsSumOfDigitsDividibleBy8(range);
        }

        static void IsSumOfDigitsDividibleBy8(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                int currentNum = i;
                int sum = 0;
                while (currentNum != 0)
                {
                    int currentDigit = currentNum % 10;
                    sum += currentDigit;
                    currentNum = currentNum / 10;
                }
                currentNum = i;

                if (sum % 8 == 0 && currentNum > 9)
                {
                    for (int j = 1; j < currentNum; j++)
                    {
                        int currentDigit = currentNum % 10;
                        if (currentDigit % 2 == 1)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                        {
                            currentNum = currentNum / 10;
                            continue;
                        }
                    }


                }
            }
        }
    }
}
