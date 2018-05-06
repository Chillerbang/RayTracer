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

        }

        public void AddShape(Shape s)
        {
            shapeList.Add(s);
        }

        public override bool RayInter(Ray r)
        {
            bool ret = false;

            foreach (Shape s in shapeList)
            {
                if (s.RayInter(r))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public override bool intersectionInter(Intersection i)
        {
            bool ret = false;

            foreach (Shape s in shapeList)
            {
                if (s.intersectionInter(i))
                {
                    ret = true;
                }
            }
            return ret;
        }
    }
}
