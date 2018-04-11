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

        public Colors(double Red, double Green, double Blue)
        {
            this.Red = Red;
            this.Blue = Blue;
            this.Green = Green;
        }

        //transparency will be added in multiplication
        public Colors multiply(double n, Colors c)
        {

            return new Colors(n*c.Red,n*c.Green,n*c.Blue );
        }

        public Colors combine(Colors c1, Colors c2)
        {
            return new Colors(c1.Red + c2.Red, c1.Green + c2.Green, c1.Blue + c2.Blue);
        }

        public Colors minus(Colors c1, Colors c2)
        {
            return new Colors(c1.Red - c2.Red, c1.Green - c2.Green, c1.Blue - c2.Blue);
        }
    }
}
