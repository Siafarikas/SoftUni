using System;
using System.Text;
using System.Linq;
namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            char[] pass = username.ToCharArray();
            Array.Reverse(pass);
            string revPass = String.Empty;
            foreach (char character in pass)
            {
                revPass += character;
            }

            for (int i = 0; i <= 3; i++)
            {
                if (password == revPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                password = Console.ReadLine();
            }




        }
    }
}
