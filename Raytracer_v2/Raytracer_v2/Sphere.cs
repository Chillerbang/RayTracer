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
        public float MIN = 0.0001f;
        public float MAX = 1.0e20f;
        public Colors col;

        public Sphere(ref Vector center, ref double radius, Colors c)
        {
            this.center = center;
            this.radius = radius;
            this.col = c;
        }

        public override bool intersectionInter(ref Intersection i)
        {
            Ray Test = new Ray(i.r);
            Test.o = Test.o - center;

            // quadratic number a,b,c

            double c = Test.d.normSqr2();
            double b = 2 * Test.d * Test.o;
            double a = Test.o.normSqr2() - Math.Pow(radius, 2);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                return false;
            }
            // else its made a hit
            //!!!!!! optimise later
            double t1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
            double t2 = ((-b) + Math.Sqrt(delta)) / (2 * a);

            if ((t1 > MIN) && (t1 < i.t))
            {
                i.t = t1;
            }else if ((t2 > MIN) && (t2 < i.t))
            {
                i.t = t2;
            }
            else
            {
                return false;
            }
            i.s = this;
            i.c = col;

            return true;

        }

        public override bool RayInter(ref Ray r) // early exits
        {
            Ray Test = new Ray(r);
            Test.o = Test.o - center;

            // quadratic number a,b,c

            double c = Test.d.normSqr2();
            double b = 2 * Test.d * Test.o;
            double a = Test.o.normSqr2() - Math.Pow(radius, 2);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                return false;
            }

            double t1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
            
            if ((t1 > MIN) && (t1 < r.MAX))
            {
                return true;
            }
            double t2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            if ((t2 > MIN) && (t2 < r.MAX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public double radiusPwr2;
        //public Colors surfaceColor, emmisionColor;
        //public float transparency, reflect;


        /*
        public Sphere(Vector c, double rad, Vector shapeColor, double reflect, double trans, Vector emC)
        {
            center = c;
            radius = rad;
            radiusPwr2 = Math.Pow(rad,2);
            reflect = 0;
            trans = 0;
            emC = new Vector(0,0,0);

        }*/
        /*
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

        }*/
    }
}
