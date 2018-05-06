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
        public Vector center;
        public double radius;
        public double radiusPwr2;
        public Colors surfaceColor, emmisionColor;
        public float transparency, reflect;
        public double r;

        public Sphere(Vector c, double rad, Vector shapeColor, double reflect, double trans, Vector emC)
        {
            center = c;
            radius = rad;
            radiusPwr2 = Math.Pow(rad,2);
            reflect = 0;
            trans = 0;
            emC = new Vector(0,0,0);

        }

        public override bool DoesIntersect(Vector origin, Vector Dest, double t0, double t1)
        {
            Vector vec = center - origin;
            double tca = vec * Dest;
            if (tca < 0)
            {
                return false;
            }
            double det = Math.Sqrt(d);
            double t = -b + det;
            if (t < 0) {
                return false;
            }
            Vector intersect = Dest*t + origin;
            intersect = intersect - positionShape;
            ret =  intersect.normalise();
            return true;

        }
    }
}
