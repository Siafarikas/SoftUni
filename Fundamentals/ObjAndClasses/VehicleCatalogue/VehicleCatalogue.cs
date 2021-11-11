using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            Catalogue vehicleCatalogue = new Catalogue();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string vehicle = input;
                string[] parts = vehicle.Split("/");
                string type = parts[0];
                string brand = parts[1];
                string model = parts[2];
                if (type == "Car")
                {
                    string horsePower = parts[3];
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    vehicleCatalogue.Cars.Add(car);
                }
                else
                {
                    string weight = parts[3];
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    vehicleCatalogue.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (vehicleCatalogue.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car carList in vehicleCatalogue.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (vehicleCatalogue.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truckList in vehicleCatalogue.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }

        }
    }

    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
}
