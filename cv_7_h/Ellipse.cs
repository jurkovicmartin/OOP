using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_home
{
    internal class Ellipse : Object2D
    {
        private double a { get; set; }
        private double b { get; set; }

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return Math.PI * a * b;
        }

        public override string ToString()
        {
            return $"Area of Ellipse is: {Math.PI * a * b}";
        }
    }
}
