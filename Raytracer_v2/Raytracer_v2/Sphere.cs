using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayTracer;

namespace Raytracer_v2
{
    class Sphere : Shape
    {
        double r;

        public Sphere(double r, Vector pos, Colors color) : base(pos, color)
        {
            this.r = r;
        }

        public override bool DoesIntersect(Vector orgin, Vector Dest, ref Vector ret)
        {
            Vector vec = orgin - positionShape;
            double b = Dest * vec;
            double c = vec * vec - r * r;
            double d = b * b - c;
            if (d < 0)
            {
                return false;
            }
            double det = Math.Sqrt(d);
            double t = -b + det;
            if (t < 0) {
                return false;
            }
            Vector intersect = Dest*t + orgin;
            intersect = intersect - positionShape;
            ret =  intersect.normalise();
            return true;

        }
    }
}
