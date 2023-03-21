using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_home
{
    internal class Square : Object2D
    {
        private double a { get; set; }

        public Square(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }

        public override string ToString()
        {
            return $"Area of square is: {a * a}";
        }
    }
}
