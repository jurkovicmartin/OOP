using cv_5_home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5_home
{
    internal class Passenger : Car
    {
        public Passenger(FuelType fuel, int tankCapacity, int maxPassengers)
        {
            Fuel = fuel;
            TankCapacity = tankCapacity;
            MaxPassengers = maxPassengers;
            TankStatus = 0;
            Passengers = 0;
        }
        private int MaxPassengers { get; set; }
        private int Passengers { get { return Passengers; } set { if (value > MaxPassengers) throw new ArgumentException("Error, the car is full"); } }

        public override string ToString()
        {
            return $"Tank capacity is {TankCapacity}\nStatus of tank is {TankStatus}\nFuel is {Fuel}\nPassengers capacity is {MaxPassengers}\nCurrent pasangers are {Passengers}";
        }
    }
}
