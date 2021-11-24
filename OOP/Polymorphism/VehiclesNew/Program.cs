using System;
using VehiclesNew.Core;
using VehiclesNew.Factories;
using VehiclesNew.IO;

namespace VehiclesNew
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory vehicleFactory = new VehicleFactory();
            IEngine engine = new Engine(reader, writer, vehicleFactory);
            engine.Run();
        }
    }
}
