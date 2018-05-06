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
        public abstract bool intersectionInter(Intersection i); // for intersection tesnt
        public abstract bool RayInter(Ray r);      // for ray intersection
    }
}
