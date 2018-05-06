using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class Scene : Shape
    {
        protected List<Shape> shapeList = new List<Shape>();

        public Scene()
        {
            shapeList.Clear();
        }

        public void AddShape(ref Shape s)
        {
            shapeList.Add(s);
        }

        public override bool RayInter(ref Ray r)
        {
            bool ret = false;

            foreach (Shape s in shapeList)
            {
                if (s.RayInter(ref r))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public override bool intersectionInter(ref Intersection i)
        {
            bool ret = false;

            foreach (Shape s in shapeList)
            {
                if (s.intersectionInter(ref i))
                {
                    return true;
                }
            }
            return ret;
        }
    }
}
