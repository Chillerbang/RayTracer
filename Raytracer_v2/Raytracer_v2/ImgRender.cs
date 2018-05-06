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

        double[][] pixels;

        public ImgRender(int width, int height)
        {
            this.witdh = width;
            this.height = height;
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
            return pixels[x][y];
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
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 0, 255));
                    }
                }
            }
            bmp.Save(filename+".bmp" ,ImageFormat.Bmp);

            return bmp;
        }
    }
}
