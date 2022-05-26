using System;
namespace Garage{
public class Tesla : Vehicle, IElectricVehicle // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method body omitted
    }
}
}