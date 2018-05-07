using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer_Final
{
    abstract class Shape
    {
        public abstract bool IntersectionTest(Vector v);
        public abstract Vector IntersectionVector(Vector v);

    }
}
