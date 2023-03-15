using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Circle : Object2D
    {
        private double r { get; set; }
        public Circle(double r)
        {
            this.r = r;
        }

        public override double CountArea()
        {
            return Math.PI * r * r;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle (r = {r})\t\t\tS = {CountArea():N3}");
        }
    }
}
