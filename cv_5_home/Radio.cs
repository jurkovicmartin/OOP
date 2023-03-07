using cv_5_home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv_5_home
{
    internal class Radio
    {
        private Dictionary<int, double> prefix = new Dictionary<int, double>();

        private double frequency { get; set; }
        public bool power = false;

        public void TurnOn()
        {
            power = true;
        }
        public void AddPrefix(int number, double frequency)
        {
            prefix.Add(number, frequency);
        }
        public void UsePrefix(int number)
        {
            frequency = prefix[number];
        }

        public override string ToString()
        {
            if (power)
            {
                return $"Radio is on\n Frequency is {frequency} Hz\n";
            }
            else return "Radio is off\n";

        }
    }
}
