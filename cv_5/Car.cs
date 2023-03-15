using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_h
{
    abstract class Car
    {
        public enum FuelType { Gasoline, Diesel }

        protected double TankSize { get; set; }
        protected FuelType Fuel { get; set; }
        public double TankStatus { get; set; }
        public CarRadio Radio { get; set; }

        public Car()
        {
            Radio = new CarRadio();
        }
        
        public void Refuel(FuelType fuel, double amount)
        {
            if (fuel != Fuel) throw new ArgumentException("Wrong fuel");
            if (TankStatus + amount > TankSize) throw new ArgumentException("Tank is full");

            TankStatus += amount;
        }
    }
}   
