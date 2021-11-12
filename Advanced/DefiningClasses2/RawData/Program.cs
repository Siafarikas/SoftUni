using System;
using System.Collections.Generic;
using System.Linq;
namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                Cargo cargo = new Cargo(int.Parse(info[3]), info[4]);
                Tire[] tires = new Tire[]
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))

                };
                Car currentCar = new Car(info[0], engine, cargo, tires);
                cars.Add(currentCar);
            }
            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                cars = cars
                    .Where(x => x.Cargo.CargoType == cargoType && x.Tires.Any(t => t.Pressure < 1))
                    .ToHashSet();
            }
            else if (cargoType == "flammable")
            {
                cars = cars
                   .Where(x => x.Cargo.CargoType == cargoType && x.Engine.EnginePower > 250)
                   .ToHashSet();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
