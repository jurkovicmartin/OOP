using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Rectangle : Object2D
    {
        private double a { get; set; }
        private double b { get; set; }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double CountArea()
        {
            return a * b;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle (a = {a}, b = {b})\t\t\tS = {CountArea():N3}");
        }
    }
}
