using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption,double tankCapacity, bool hasAirCond = true);
    }
}
