using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer_v2
{
    class ImgRender
    {
        protected int witdh = 0, height = 0;

        double[,] pixels;

        public ImgRender(int width, int height)
        {
            this.witdh = width;
            this.height = height;
            pixels = new double[width,height];
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return witdh;
        }
        public double getPixel(int x, int y)
        {
            return pixels[x,y];
        }

        public void SetPixel(int x, int y, double val)
        {
            pixels[x,y] = val ;
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
                        bmp.SetPixel(x, y, Color.FromArgb((int)(pixels[x,y]*255), (int)(pixels[x,y] * 255), (int)(pixels[x,y] * 255), (int)(pixels[x,y] * 255)));
                    }
                }
            }
            return bmp;
        }
    }
}
