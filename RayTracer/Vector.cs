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

        public static Vector operator +(Vector a, Vector v) {
            return new Vector(a.x + v.x, a.y + v.y, a.z + v.z);
        }

        public static Vector operator-(Vector a, Vector v)
        {
            return new Vector(a.x - v.x, a.y - v.y, a.z - v.z);
        }

        //returns a new scalar multiplied vector
        public Vector ScalarMultiply(double n)
        {
            return new Vector(x * n, y * n, z * n);
        }

        //returns a new scalar multiplied vector
        public Vector ScalarMultiply(double n, Vector v)
        {
            return new Vector(v.x * n, v.y * n, v.z * n);
        }

        public Vector negate()
        {
            return new Vector(-x, -y, -z);
        }

        public double dotProduct(Vector vect)
        {
            return vect.x * x + vect.y * y + vect.z * z;
        }

        public double magnitude()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public Vector crossproduct(Vector vect)
        {
            return new Vector(y * vect.z - z * vect.y, z * vect.x - x * vect.z, x * vect.y - y * vect.x);
        }

        public Vector norm()
        {
            double mag = magnitude();
            return new Vector(x / mag, y / mag, z / mag);
        }

        //public Vector GetColorIntersection()
        //{

        //}

        //public bool intersection()
        //{

        //}
    }
}
