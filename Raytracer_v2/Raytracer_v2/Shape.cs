using RayTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    abstract class Shape
    {
        public abstract bool DoesIntersect(Vector origin, Vector Dest, double t0, double t1);
    }
}
