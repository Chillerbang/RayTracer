using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class sphere : Things
    {
        public Vector center;
        public double radius;
        public Colors color;

        sphere(Vector v, double r, Colors c)
        {
            center = v;
            radius = r;
            color = c;
        }

        public double findIntersection(Ray r)
        {
            throw new NotImplementedException();
        }

        public Colors GetColor()
        {
            // used to create color when trnsparent
            //TO-DO
            return color;
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
