using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Cylinder : Object3D
    {
        private double r { get; set; }
        private double v { get; set; }

        public Cylinder(double r, double v)
        {
            this.r = r;
            this.v = v;
        }

        public override double CountSurface()
        {
            return 2 * Math.PI * r * (r + v);
        }

        public override double CountVolume()
        {
            return Math.PI * r * r * v;
        }

        public override void Draw()
        {
            Console.WriteLine($"Cylinder (r = {r}, v = {r})\t\t\tS = {CountSurface():N3}, V = {CountVolume():N3}");
        }
    }
}
