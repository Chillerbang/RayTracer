using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Colors
    {
        public double Red;
        public double Green;
        public double Blue;
        public double Alpha;

        public Colors(double Red, double Green, double Blue)
        {
            this.Red = Red;
            this.Blue = Blue;
            this.Green = Green;
            Alpha = 1.0;
        }

        public Colors(double Red, double Green, double Blue, double Alpha)
        {
            this.Red = Red;
            this.Blue = Blue;
            this.Green = Green;
            this.Alpha = Alpha;
        }

        public object Clone()
        {
            object o = new Colors(Red, Green, Blue, Alpha);
            return o;
        }

        //compoentent multiplication 
        public static Colors operator*(Colors c1, Colors c2)
        {
            return new Colors(c1.Red * c2.Red, c1.Green * c2.Green, c1.Blue * c2.Blue);
        }

        public static Colors operator *(Colors c1, double n)
        {
            return new Colors(c1.Red * n, c1.Green * n, c1.Blue * n);
        }

        public static Colors operator+(Colors c1, Colors c2)
        {
            return new Colors(c1.Red + c2.Red, c1.Green + c2.Green, c1.Blue + c2.Blue);
        }

        public static Colors operator-(Colors c1, Colors c2)
        {
            return new Colors(c1.Red - c2.Red, c1.Green - c2.Green, c1.Blue - c2.Blue);
        }
    }
}
