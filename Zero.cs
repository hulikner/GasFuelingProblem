using System;
namespace Garage{
public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage {get;set;}

    
    public void ChargeBattery()
    {
        BatteryKWh = 100;
        CurrentChargePercentage=100;
    }
}
}