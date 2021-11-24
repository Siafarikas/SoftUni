using System;
using System.Collections.Generic;
using System.Text;
using VehiclesNew.Factories;
using VehiclesNew.IO;
using VehiclesNew.Models;

namespace VehiclesNew.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;

        public Engine(IReader  reader,  IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }


        public void Run()
        {
            string[] carData = reader.CustomReadLine().Split();
            IVehicle car = CreateVehicle(carData);

            string[] truckData = reader.CustomReadLine().Split();
            IVehicle truck = CreateVehicle(truckData);

            string[] busData = reader.CustomReadLine().Split();
            IVehicle bus = CreateVehicle(busData);

            int n = int.Parse(reader.CustomReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandParts = reader.CustomReadLine().Split();
                string command = commandParts[0];
                string vehicleType = commandParts[1];
                double arg = double.Parse(commandParts[2]);

                if (command == "Drive")
                {
                    DriveCommand(vehicleType, car, truck, bus, arg);
                }
                else if (command == "Refuel")
                {
                    RefuelCommand(vehicleType, car, truck, bus, arg);
                }
                else if (command == "DriveEmpty")
                {
                    (bus as Bus).DriveEmpty(arg);
                }
            }

            writer.CustomWriteLine(car.ToString());
            writer.CustomWriteLine(truck.ToString());
            writer.CustomWriteLine(bus.ToString());
        }

        private void RefuelCommand(string vehicleType, IVehicle car, IVehicle truck, IVehicle bus, double arg)
        {
            if (vehicleType == nameof(Car))
            {
                car.Refuel(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                truck.Refuel(arg);
            }
            else if (vehicleType == nameof(Bus))
            {
                bus.Refuel(arg);
            }
        }

        private IVehicle CreateVehicle(string[] data)
        {
            string type = data[0];
            double fuelQuantity = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);
            double tankCapacity = double.Parse(data[3]);
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }
            IVehicle vehicle = vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption, tankCapacity);
            return vehicle;
        }

        private void DriveCommand(string vehicleType, IVehicle car, IVehicle truck, IVehicle bus, double arg)
        {
            bool isDrive = false;
            if (vehicleType == nameof(Car))
            {
                isDrive = car.Drive(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                isDrive = truck.Drive(arg);
            }
            else if (vehicleType == nameof(Bus))
            {
                isDrive = bus.Drive(arg);
            }
            if (isDrive)
            {
                writer.CustomWriteLine($"{vehicleType} travelled {arg} km");
            }
            else
            {
                writer.CustomWriteLine($"{vehicleType} needs refueling");
            }
        }
    }
}
