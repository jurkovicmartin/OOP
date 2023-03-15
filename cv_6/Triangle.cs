using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
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

        public override double CountArea()
        {
            return (a * v) / 2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle (a = {a}, v = {v})\t\t\tS = {CountArea():N3}");
        }
    }
}
