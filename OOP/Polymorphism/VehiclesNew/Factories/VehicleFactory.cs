using System;
using System.Collections.Generic;
using System.Text;
using VehiclesNew.Models;

namespace VehiclesNew.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirCond = true)
        {
            IVehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond);
            }

            return vehicle;
        }
    }
}
