using System;
namespace Garage{
        public interface IGasVehicle
        {
                double CurrentTankPercentage {get;}
                void RefuelTank();
        }
}