using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class LightSource
    {
        public Vector postion, direction;
        public Colors colorSet;

        public LightSource() // postioned on origin
        {
            postion = new Vector(0, 0, 0);
            colorSet = new Colors(255, 255, 255, 1);
        }

        public LightSource(Vector postion, Vector direction, Colors color)
        {
            this.postion = postion;
            this.direction = direction;
            colorSet = color;
        }
    }
}
