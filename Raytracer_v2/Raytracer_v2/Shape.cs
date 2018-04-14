using RayTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    abstract class Shape
    {
        protected Vector positionShape;
        protected Colors colorShape;
        public Shape(Vector pos, Colors color)
        {
            positionShape = new Vector(pos);
            colorShape = new Colors(color);
        }

        public abstract bool DoesIntersect(Vector orgin, Vector Dest, ref Vector ret);
    }
}
