using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal abstract class Object3D : GrObject
    {
        public abstract double CountSurface();
        public abstract double CountVolume();
    }
}
