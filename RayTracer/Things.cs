using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    interface Things
    {
        Colors GetColor();
        void SetPostion(int x, int y);
        void setRotation(double degree); // later to be implemented
        bool TestIntersection();         // will be true if rays touch
        double findIntersection(Ray r);
    }
}
