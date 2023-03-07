using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5_h
{
    internal class Car
    {
        public enum FuelType{
            Benzine,
            Oil
        }

        protected int TankCapacity { get; set; }
        protected int TankStatus { get { return TankStatus; } set { TankStatus = value; } }
        protected FuelType Fuel { get; set; }

        public void Refuel(FuelType fuel, int amount)
        {
            if (fuel != Fuel)
                throw new ArgumentException("Error, wrong fuel");
            if(TankStatus + amount > TankCapacity)
                throw new ArgumentException("Error, tank is full");
            TankStatus += amount;
        }
    }
}
