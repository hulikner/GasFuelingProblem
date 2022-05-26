using System;
namespace Garage{
public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method body omitted
    }
}
}