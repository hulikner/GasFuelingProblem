using System;
namespace Garage{
public class Ram : Vehicle, IGasVehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public double CurrentTankPercentage {get;set;}

    public void RefuelTank()
    {
        FuelCapacity = 100;
        CurrentTankPercentage = 100;
    }
}
}