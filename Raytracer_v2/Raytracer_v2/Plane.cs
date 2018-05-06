using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayTracer;

namespace Raytracer_v2
{
    class Plane : Shape
    {
        protected Vector Position;
        protected Vector Normal;
        public float MIN = 0.0001f;
        public float MAX = 1.0e20f;
        public Colors c;

        public Plane(ref Vector p, ref Vector n)
        {
            Position = p; Normal = n;
        }



        public override bool intersectionInter(ref Intersection i)
        {
            double dIntersect = i.r.d * Normal;
            if (dIntersect == 0)
            {
                return false;
            }
            Vector v1 =new Vector( Position - i.r.o);
            Vector v2 = new Vector(Normal);
            double t = v1 * v2 / dIntersect;
            if (t <= MIN || t > i.t)
            {
                return false;
            }
            i.t = t;
            i.s = this;
            return true;
        }

        public override bool RayInter(ref Ray r)
        {
            double dIntersect = r.d * Normal;
            if (dIntersect == 0)
            {
                return false;
            }
            Vector v1 = new Vector(Position - r.o);
            Vector v2 = new Vector(Normal);
            double t = v1 * v2 / dIntersect;
            if (t <= MIN || t > r.MAX)
            {
                return false;
            }
            return true;
        }
    }
}
