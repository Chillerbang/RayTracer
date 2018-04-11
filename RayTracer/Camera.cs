using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    
    class Camera
    {
        // seting up the view for output
        private int height = 500;
        private int width = 500;

        public Vector pos, dir, camwidth, camheight;

        public Camera() // default view
        {
            pos = new Vector(0, 0, 1);
            camwidth = new Vector(0, 0, 0);
            camheight  = new Vector(0, 0, 0);
            dir = new Vector(0, 0, 0);
        }

        public Camera(Vector pos, Vector dir, Vector camwidth, Vector camheight)
        {
            this.pos = pos;
            this.dir = dir;
            this.camheight = camheight;
            this.camwidth = camwidth;
        }

        private void createImage()
        {
           Bitmap bmp = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            { 
                for (int x = 0; x < width; x++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0)); // where we set the color for each intersection
                    // loop though object array and find what colors you see
                }
            }
            bmp.Save("RandomStuff");
        }
    }
}
