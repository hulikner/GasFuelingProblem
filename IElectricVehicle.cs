using System;
namespace Garage{
        public interface IElectricVehicle
        {
           
            public double CurrentChargePercentage {get;set;}

            public void ChargeBattery();
            
        }
}