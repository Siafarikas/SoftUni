using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            ListyIterator<string> listy = null;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comm = info[0];
                if (comm == "Create")
                {
                    listy = new ListyIterator<string>(info.Skip(1).ToArray());
                }
                else if (comm == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (comm == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (comm == "PrintAll")
                {
                    listy.PrintAll();
                }
                else if(comm == "Print")
                {
                    listy.Print();
                }
               
            }

        }
    }
}
