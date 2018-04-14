using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Ray // rays conist of 2 vectors
    {
        public Vector orgin, direction;
        
        public Ray(Vector o, Vector dir)
        {
            orgin = o;
            direction = dir;
        }

        // add new intersection
    }
}
