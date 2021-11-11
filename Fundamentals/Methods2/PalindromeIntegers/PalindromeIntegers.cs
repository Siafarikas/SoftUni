using System;
namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsNumberPalindrome(input));
                input = Console.ReadLine();
            }
        }

        static bool IsNumberPalindrome(string input)
        {
            bool isNumberPalindrome = false;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            
            if (reversed == input)
            {
                isNumberPalindrome = true;
            }
            return isNumberPalindrome;
        }
    }
}
