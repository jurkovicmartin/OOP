using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5_home
{
    internal class Car
    {
        public enum FuelType
        {
            Benzine,
            Oil
        }

        protected int TankCapacity { get; set; }
        protected int TankStatus { get; set; }
        protected FuelType Fuel { get; set; }

        Radio radio = new Radio();

        public void Refuel(FuelType fuel, int amount)
        {
            if (fuel != Fuel)
                throw new ArgumentException("Error, wrong fuel");
            if (TankStatus + amount > TankCapacity)
                throw new ArgumentException("Error, tank is full");
            TankStatus += amount;
        }

        public void AddPrefix(int number, double frequency)
        {
            radio.AddPrefix(number, frequency);
        }

        public void UsePrefix(int number)
        {
            radio.UsePrefix(number);
        }

        public void TurnOn()
        {

            radio.TurnOn();
        }

        public void WriteRadio(Radio radio)
        {
            Console.WriteLine(radio);
        }

    }
}
