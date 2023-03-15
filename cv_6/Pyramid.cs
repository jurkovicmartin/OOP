using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Pyramid : Object3D
    {
        private double a { get; set; }
        private double b { get; set; }
        private double v { get; set; }

        public Pyramid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.v = c;
        }

        public override double CountSurface()
        {
            double heightTriangleA = Math.Sqrt(Math.Pow(a/2,2) + Math.Pow(v,2));
            double heightTriangleB = Math.Sqrt(Math.Pow(b / 2, 2) + Math.Pow(v, 2));

            return a * b + a * heightTriangleA + b * heightTriangleB;
        }

        public override double CountVolume()
        {
            return (a * b * v) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine($"Pyramid (a = {a}, b = {b}, v = {v})\t\t\tS = {CountSurface():N3}, V = {CountVolume():N3}");
        }
    }
}
