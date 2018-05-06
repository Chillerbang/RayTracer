using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class _2DVector
    {
        public double x, y; // u,v


        public _2DVector(_2DVector v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        public _2DVector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
