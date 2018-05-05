using RayTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class Camera
    {
        public Vector postion;
        public Vector dir;
        public int[] reso = { 400, 400 };

        public Camera(Vector postion, Vector dir)
        {
            this.postion = postion;
            this.dir = dir;
        }

        // functions to walk back the vector
        public void GenerateImage()
        {
            int[] image = new int[reso[0] * reso[1]];
            int count = 0;
            for (int i = 0; i < reso[0]; i++)
            {
                for (int h = 0; j < reso[0]; j++)
                {
                    Ray r = newCameraRay(i, j);
                    if (intersect(Ray, Shape[k])){
                        image[count] = o
                    }
                    count++;
                }
            }
        }
    }
}
