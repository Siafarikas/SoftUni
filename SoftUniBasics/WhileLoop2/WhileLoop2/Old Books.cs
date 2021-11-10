using System;

namespace WhileLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string input = "";
            int booksChecked = 0;
            while (favBook != input)
            {
                input = Console.ReadLine();
                if (input == "No More Books")
                {
                    break;
                }
                booksChecked++;
                if (favBook == input)
                {
                    booksChecked--;
                }
            }
            if (favBook != input)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }
            else
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }
        }
    }
}
