using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < numEngines; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                engines.Add(CreateEngine(info));
            }
            int numCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numCars; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(CreateCar(info, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static Car CreateCar(string[] info, List<Engine> engines)
        {
            string carModel = info[0];
            string engineModel = info[1];
            Engine engine = engines.Find(e => e.Model == engineModel);
            Car car = new Car(carModel, engine);
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = info[2];
                }
            }
            if (info.Length > 3)
            {
                car.Color = info[3];
            }

            return car;
        }

        public static Engine CreateEngine(string[] info)
        {
            Engine engine = new Engine(info[0], int.Parse(info[1]));
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = info[2];
                }
            }
            if (info.Length > 3)
            {
                engine.Efficiency = info[3];
            }

            return engine;
        }
    }
}
