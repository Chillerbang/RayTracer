using System;
using RayTracer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class Ray
    { 
        public Vector o, d;

        public float MIN = 0.0001f;
        public float MAX = 1.0e20f;

        public Ray(Vector o, Vector d)
        {
            this.o = o;
            this.d = d;
        }

        public Ray(Ray r)
        {
            this.o = r.o;
            this.d = r.d;
        }


        public Vector Intersect(double t)
        {

            return o + d * t;
        }

    }
}
