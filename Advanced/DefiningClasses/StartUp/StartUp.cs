using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] currentSetTires = new Tire[4];
                int tireIdx = 0;
                for (int i = 0; i <= 6; i += 2)
                {
                    int tireYear = int.Parse(info[i]);
                    double tirePressure = double.Parse(info[i + 1]);
                    Tire currentTire = new Tire(tireYear, tirePressure);
                    currentSetTires[tireIdx] = currentTire;
                    tireIdx++;
                }
                tires.Add(currentSetTires);
            }

            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int engineHP = int.Parse(info[0]);
                double engineCubicCap = double.Parse(info[1]);
                Engine currentEngine = new Engine(engineHP, engineCubicCap);
                engines.Add(currentEngine);
            }

            List<Car> cars = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var currentCar = new Car(info[0], info[1], int.Parse(info[2]), double.Parse(info[3]),
                    double.Parse(info[4]), engines[int.Parse(info[5])], tires[int.Parse(info[6])]);

                cars.Add(currentCar);
            }

            cars = cars
                .Where(x => x.Year >= 2017 &&
                x.Engine.HorsePower > 330 &&
                (x.Tires[0].Pressure + x.Tires[1].Pressure + x.Tires[2].Pressure + x.Tires[3].Pressure) >= 9 &&
                (x.Tires[0].Pressure + x.Tires[1].Pressure + x.Tires[2].Pressure + x.Tires[3].Pressure) <= 10)
                .ToList();
            foreach (var car in cars)
            {
                car.Drive(20);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.WhoAmI());
            }


        }
    }
}
