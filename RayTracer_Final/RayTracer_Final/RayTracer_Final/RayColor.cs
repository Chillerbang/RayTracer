using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer_Final
{
    class RayColor
    {
        public double Red;
        public double Green;
        public double Blue;
        public double Alpha;


        public RayColor(double Red, double Green, double Blue)
        {
            this.Red = Red;
            this.Blue = Blue;
            this.Green = Green;
            Alpha = 1.0;
        }

        public RayColor(RayColor c)
        {
            this.Red = c.Red;
            this.Blue = c.Blue;
            this.Green = c.Green;
            this.Alpha = c.Alpha;
        }

        public RayColor(double Red, double Green, double Blue, double Alpha)
        {
            this.Red = Red;
            this.Blue = Blue;
            this.Green = Green;
            this.Alpha = Alpha;
        }

        public object Clone()
        {
            object o = new RayColor(Red, Green, Blue, Alpha);
            return o;
        }

        //compoentent multiplication 
        public static RayColor operator *(RayColor c1, RayColor c2)
        {
            return new RayColor(c1.Red * c2.Red, c1.Green * c2.Green, c1.Blue * c2.Blue);
        }

        public static RayColor operator *(RayColor c1, double n)
        {
            return new RayColor(c1.Red * n, c1.Green * n, c1.Blue * n);
        }

        public static RayColor operator +(RayColor c1, RayColor c2)
        {
            return new RayColor(c1.Red + c2.Red, c1.Green + c2.Green, c1.Blue + c2.Blue);
        }

        public static RayColor operator -(RayColor c1, RayColor c2)
        {
            return new RayColor(c1.Red - c2.Red, c1.Green - c2.Green, c1.Blue - c2.Blue);
        }

        public override string ToString()
        {
            return String.Format("Color({0},{1},{2},{3})", Red, Green, Blue, Alpha);
        }
    }
}
}
