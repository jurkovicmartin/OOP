using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_home
{
    internal class Triangle : Object2D
    {
        private double a { get; set; }
        private double v { get; set; }

        public Triangle(double a, double v)
        {
            this.a = a;
            this.v = v;
        }

        public override double Area()
        {
            return (a * v) / 2; 
        }

        public override string ToString()
        {
            return $"Area of triangle is: {(a * v) / 2}";
        }
    }
}
