using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class plane : Things
    {
        Vector norm;
        double distance;
        Colors color;

        public plane()
        {
            norm = new Vector(1, 0, 0);
            distance = 0;
            color = new Colors(255, 0, 0, 0);
        }

        public plane(Vector v, double d, Colors c)
        {
            norm = v;
            distance = d;
            color = c;
        }

        // normal vector of the plane is the same everywhere
        public double findIntersection(Ray r)
        {
            Vector dir = r.direction;
            double a = dir.dotProduct(norm);
            if (a == 0)
            {
                // no intersection
                return -99;
            }
            else
            {
                Vector originToDir = r.orgin + r.direction.norm().ScalarMultiply(distance).negate();
                double b = originToDir.norm().dotProduct();
                return b;
            }
        }

        public Colors GetColor()
        {
            throw new NotImplementedException();
        }

        public void SetPostion(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void setRotation(double degree)
        {
            throw new NotImplementedException();
        }

        public bool TestIntersection()
        {
            throw new NotImplementedException();
        }
    }
}
