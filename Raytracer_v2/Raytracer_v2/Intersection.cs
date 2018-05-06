﻿using RayTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class Intersection
    {
        Ray r;
        float t;
        Shape s;
        public Intersection()
        {
            // never used i guess
        }

        public Intersection(Intersection i)
        {
            r = i.r;
            t = i.t;
            s = i.s;
        }
        public Intersection(Ray r)
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
