using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer_Final
{
    class ImageRender
    {
        protected int witdh = 0, height = 0;

        private RayColor[,] pixels;

        public ImageRender(int width, int height)
        {
            this.witdh = width;
            this.height = height;
            pixels = new RayColor[width, height];
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return witdh;
        }
        public RayColor getPixel(int x, int y)
        {
            return pixels[x, y];
        }

        public void SetPixel(int x, int y, RayColor val)
        {
            pixels[x, y] = val;
        }

        public Bitmap saveImage(string filename)
        {
            Bitmap bmp = new Bitmap(witdh, height);
            if ((witdh > 0) & (height > 0))
            {
                for (int x = 0; x < witdh; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb((int)(pixels[x, y].Alpha * 255), (int)(pixels[x, y].Red * 255), (int)(pixels[x, y].Green * 255), (int)(pixels[x, y].Blue * 255)));
                    }
                }
            }
            return bmp;
        }

    }
}
