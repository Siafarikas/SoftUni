using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            GetMax(valueType, firstValue, secondValue);
        }

        static void GetMax(string valueType, string firstValue, string secondValue)
        {
            if (valueType == "int")
            {
                int a1 = int.Parse(firstValue);
                int a2 = int.Parse(secondValue);
                Console.WriteLine(Math.Max(a1, a2));

            }
            else if (valueType == "char")
            {
                char ch1 = char.Parse(firstValue);
                char ch2 = char.Parse(secondValue);
                if (ch1 > ch2)
                {
                    Console.WriteLine(ch1);
                }
                else if (ch2 > ch1)
                {
                    Console.WriteLine(ch2);
                }

            }
            else
            {
                if (firstValue.CompareTo(secondValue) >= 0)
                {
                    Console.WriteLine(firstValue);
                }
                else
                {
                    Console.WriteLine(secondValue);
                }
            }

        }

    }
}
