using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(carInfo[3]));
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(carInfo[3]));

            int nCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < nCommands; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string vehicleType = parts[1];
                double commandValue = double.Parse(parts[2]);
                Vehicle vehicle;
                if (vehicleType == "Car")
                {
                    vehicle = car;
                }
                else if (vehicleType == "Truck")
                {
                    vehicle = truck;
                }
                else
                {
                    vehicle = bus;
                }
                if (command == "Drive")
                {
                    if (vehicle.FuelQuantity >= commandValue * vehicle.FuelConsumption)
                    {
                        vehicle.Drive(commandValue);
                        Console.WriteLine($"{vehicleType} travelled {commandValue} km");
                    }
                    else
                    {
                        Console.WriteLine($"{vehicleType} needs refueling");
                    }
                }
                else if (command == "Refuel")
                {
                    vehicle.Refuel(commandValue);
                }
                else
                {
                    if (bus.FuelQuantity >= commandValue * vehicle.FuelConsumption)
                    {
                        bus.DriveEmpty(commandValue);
                        Console.WriteLine($"Bus travelled {commandValue} km");
                    }
                    else
                    {
                        Console.WriteLine($"Bus needs refueling");
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
