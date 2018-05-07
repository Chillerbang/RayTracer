using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer_Final
{
    class Sphere : Shape
    {
        public double radius;
        public Vector center;
        public RayColor c;

        public Sphere(Vector center, double radius, RayColor color)
        {
            this.center = center;
            this.radius = radius;
            c = color;
        }

        public override bool IntersectionTest(Vector v)
        {
            throw new NotImplementedException();
        }

        public override Vector IntersectionVector(Vector v)
        {
            throw new NotImplementedException();
        }
    }
}
