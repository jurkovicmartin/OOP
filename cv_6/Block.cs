using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Block : Object3D
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Block(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CountSurface()
        {
            return 2 * (a * b + a * c + b * c);
        }

        public override double CountVolume()
        {
            return a * b * c;
        }

        public override void Draw()
        {
            Console.WriteLine($"Block (a = {a}, b = {b}, c = {c})\t\t\tS = {CountSurface():N3}, V = {CountVolume():N3}");
        }
    }
}
