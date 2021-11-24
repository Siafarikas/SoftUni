using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.IO
{
    public class ConsoleReader : IReader
    {
        public string CustomReadLine()
        {
           return Console.ReadLine();
        }
    }
}
