using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_home
{
    internal abstract class Object2D : I2D, IComparable
    {
        public int CompareTo(object obj)
        {
            if(((Object2D)obj).Area() > this.Area())
                return 0;
            return 1;
        }

        public abstract double Area();
    }
}
