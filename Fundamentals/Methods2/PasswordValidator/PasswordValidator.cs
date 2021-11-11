using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidation(password);
        }

        static bool LengthValidation(string password)
        {
            bool isValid = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isValid = true;
            }
            return isValid;
        }

        static bool OnlyLettersAndDigitsValidation(string password)
        {
            bool isValid = false;
            for (int i = 0; i < password.Length; i++)
            {
                char currentLetter = password[i];

                bool isDigit = false;
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    isDigit = true;
                }

                bool isLetter = false;
                if ((int)password[i] >= 65 && (int)password[i] <= 90 ||
                    (int)password[i] >= 97 && (int)password[i] <= 122)
                {
                    isLetter = true;
                }

                if (isDigit || isLetter)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        static bool HasAtLeast2DigitsValidation(string password)
        {
            bool isValid = false;
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currentLetter = password[i];
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    digitCounter++;
                }
                if (digitCounter == 2)
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;

        }

        static void PasswordValidation(string password)
        {
            bool lengthVal = LengthValidation(password);
            bool letterAndDigitVal = OnlyLettersAndDigitsValidation(password);
            bool digitVal = HasAtLeast2DigitsValidation(password);

            if (!lengthVal)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!letterAndDigitVal)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digitVal)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (lengthVal && letterAndDigitVal && digitVal)
            {
                Console.WriteLine("Password is valid");
            }
        }

    }
}
