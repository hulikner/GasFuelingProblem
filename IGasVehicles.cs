using System;
namespace Garage{
        public interface IGasVehicle
        {
           public double CurrentTankPercentage {get;set;}
            public void RefuelTank(double batteryKwh)
            {
                
            }
        }
}