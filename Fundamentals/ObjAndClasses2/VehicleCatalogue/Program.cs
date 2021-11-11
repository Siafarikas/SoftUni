using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double carsHP = 0;
            double cars = 0;
            double trucksHP = 0;
            double trucks = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] commandParts = command.Split(" ");
                string type = commandParts[0];
                string model = commandParts[1];
                string color = commandParts[2];
                double horsePower = double.Parse(commandParts[3]);
                if (type == "car")
                {
                    type = "Car";
                    cars++;
                    carsHP += horsePower;
                }
                else if (type == "truck")
                {
                    type = "Truck";
                    trucks++;
                    trucksHP += horsePower;
                }
                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };
                vehicles.Add(vehicle);
            }
            double averageCarsHp = carsHP / cars;
            double averageTrucksHp = trucksHP / trucks;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    if (averageCarsHp > 0 && averageTrucksHp > 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:f2}.");
                        break;
                    }
                    else if (cars == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:f2}.");
                        break;
                    }
                    else if (trucks == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                        break;
                    }
                }
                string model = input;
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        continue;
                    }
                }
            }
        }
    }


    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

    }

}
