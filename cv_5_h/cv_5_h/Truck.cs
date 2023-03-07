using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5_h
{
    internal class Truck : Car
    {
        public Truck(FuelType fuel, int tankCapacity, int maxCargo)
        {
            Fuel = fuel;
            TankCapacity = tankCapacity;
            MaxCargo = maxCargo;
            TankStatus = 0;
            Cargo = 0;
        }
        private int MaxCargo { get; set; }
        private int Cargo { get; set; }

        public override string ToString()
        {
            return $"Tank capacity is {TankCapacity}\nStatus of tank is {TankStatus}\nFuel is {Fuel}\nMaximus cargo is {MaxCargo}\nCurrent cargo is {Cargo}";
        }
    }
}
