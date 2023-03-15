using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_h
{
    internal class CarRadio
    {
        private Dictionary<int, double> Prefixes = new Dictionary<int, double>();
        public bool Power { get; set; }
        private double Frequncy { get; set; }

        public void SetPrefix(int number, double frequncy)
        {
            Prefixes.Add(number, frequncy);
        }

        public void PrefixTranslation(int number)
        {
            if (!(Prefixes.ContainsKey(number))) throw new ArgumentException("Wrong prefix");
            Frequncy = Prefixes[number];
        }

        public override string ToString()
        {
            if (Power)
            {
                return $"Radio is on\nCurrent frequency is {Frequncy} kHz\n";
            }
            return "Radio is off\n";
        }
    }
}
