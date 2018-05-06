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
        public Vector origin;
        public Vector direction; //f
        public Vector up;
        public Vector right;
        public double[] reso = { 400, 400 }; // default hw

        public Camera(ref Vector o,ref Vector dir,ref Vector vertical, double fov, double aspectRatio) // v == ug
        {
            origin      = o;
            Vector temp = new Vector(dir - o);
            direction = temp.normalisedVector();
            Vector temp2 = new Vector(dir ^ vertical);
            right = temp2.normalisedVector();
            up = new Vector( right ^ direction);
            reso = new double[2];
            reso[0] = Math.Tan(fov);
            reso[1] = reso[0] * aspectRatio;
        }

        public  Ray ShootRay(ref _2DVector point) // fish eye
        {
            Vector rayShot = new Vector  (direction + point.x * reso[1] * right + point.y * reso[0] * up);
            return new Ray(origin, rayShot.normalisedVector());
        }

        public Ray ShootRay(double x, double y, double vectU, double vectV)
        {
            return null;
        }



        //// functions to walk back the vector
        //public void GenerateImage()
        //{
        //    int[] image = new int[reso[0] * reso[1]];
        //    int count = 0;
        //    for (int i = 0; i < reso[0]; i++)
        //    {
        //        for (int h = 0; j < reso[0]; j++)
        //        {
        //            Ray r = newCameraRay(i, j);
        //            if (intersect(Ray, Shape[k])){
        //                image[count] = o
        //            }
        //            count++;
        //        }
        //    }
        //}
    }
}
