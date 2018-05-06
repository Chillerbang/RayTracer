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
        public abstract bool intersectionInter(ref Intersection i); // for intersection tesnt
        public abstract bool RayInter(ref Ray r);      // for ray intersection
    }
}
