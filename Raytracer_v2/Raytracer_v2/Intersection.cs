using RayTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class Intersection
    {
        public Ray r;
        public double t;
        public Shape s;
        public Colors c;


        public Intersection()
        {
            // never used i guess
        }

        public Intersection(ref Intersection i)
        {
            r = i.r;
            t = i.t;
            s = i.s;
        }
        public Intersection(ref Ray r)
        {
            this.r = r;
            t = r.MAX;
            s = null;
        }

        public bool Collision()
        {
            bool test = (s != null);
            return test;
        }

        public Vector HitAt()
        {
            return r.Intersect(t);
        }
    }
}
