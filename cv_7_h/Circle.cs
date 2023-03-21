using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_home
{
    internal class Circle : Object2D
    {
        private double r { get; set; }

        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
        public override string ToString()
        {
            return $"Area of circle is: {Math.PI * r * r}";
        }
    }
}
