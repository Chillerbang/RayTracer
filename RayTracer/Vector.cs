using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Vector
    {
        // location of the vector location
        public double x, y, z;
        
        // constrcutor for standard vector
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //returns a new scalar multiplied vector
        public Vector ScalarMultiply(double n, Vector v)
        {
            return new Vector(v.x * n, v.y * n, v.z * n);
        }
    }
}
