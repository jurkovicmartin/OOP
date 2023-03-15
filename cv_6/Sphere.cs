using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Sphere : Object3D
    {
        private double r { get; set; }

        public Sphere(double r)
        {
            this.r = r;
        }

        public override double CountSurface()
        {
            return 4 * Math.PI * r * r;
        }

        public override double CountVolume()
        {
            return (4 * Math.PI * r * r * r) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine($"Sphere (r = {r})\t\t\tS = {CountSurface():N3}, V = {CountVolume():N3}");
        }
    }
}
