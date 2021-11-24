using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.IO
{
    public interface IWriter
    {
        void CustomWriteLine(string text);
        void CustomWrite(string text);
    }
}
