using System;
namespace Garage{
public class Ram : Vehicle, IGasVehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method body omitted
    }
}
}