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
        public double x, y, z, w;
        //*************************************************************************************************************************
        // constrcutor for standard vector
        public Vector(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 1.0;
        }

        public Vector(Vector v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        //*************************************************************************************************************************

        public static Vector operator +(Vector a, Vector v) {
            return new Vector(a.x + v.x, a.y + v.y, a.z + v.z, a.w);
        }

        public static Vector operator -(Vector a, Vector v)
        {
            return new Vector(a.x - v.x, a.y - v.y, a.z - v.z, a.w);
        }

        //returns a new scalar multiplied vector
        public static Vector operator *(double n, Vector v)
        {
            return new Vector(v.x * n, v.y * n, v.z * n, v.w);
        }

        public static Vector operator *(Vector v, double n)
        {
            return new Vector(v.x * n, v.y * n, v.z * n, v.w);
        }


        public static double operator *(Vector n, Vector v)
        {
            return n.x*v.x + n.y*v.y + n.z*v.z;
        }

        // cross product
        public static Vector operator^(Vector a, Vector b)
        {
            return new Vector(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x, a.w);
            
        }

        public static Vector reflect(Vector a, Vector b)
        {
            return 2.0 * (a * b) * a - b;
        }

        public Vector negate()
        {
            return new Vector(-x, -y, -z);
        }

        // componenetwise multiply
        public static Vector operator%(Vector a, Vector b)
        {
            return new Vector(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }

        public double norm()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public Vector crossproduct(Vector vect)
        {
            return new Vector(y * vect.z - z * vect.y, z * vect.x - x * vect.z, x * vect.y - y * vect.x);
        }

        public Vector normalise()
        {
            double mag = norm();
            return new Vector(x / mag, y / mag, z / mag);
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2},{3})",x,y,z,w);
        }


    }
}
