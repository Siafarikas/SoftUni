using System;
using System.Text;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int remainder = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                if (num == 0)
                {
                    result.Append(0);
                    break;
                }
                int currentNum = bigNum[i] - '0';
                int currentResult = currentNum * num + remainder;
                remainder = 0;
                if (currentResult < 10)
                {
                    result.Append(currentResult);
                }
                else
                {
                    result.Append(currentResult % 10);
                    remainder = remainder + currentResult / 10;
                }
            }
            if (remainder > 0)
            {
                result.Append(remainder);
            }
            char[] number = result.ToString().ToCharArray();
            Array.Reverse(number);
            string output = new string(number);
            Console.WriteLine(output);
        }
    }
}
