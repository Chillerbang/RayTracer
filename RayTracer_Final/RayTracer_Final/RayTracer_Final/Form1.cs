using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTracer_Final
{
    public partial class Form1 : Form
    {

        private ImageRender img;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rayTrace()
        {
            for (int x = 0; x < img.getWidth(); x++)
            {
                for (int y = 0; y < img.getHeight(); y++)
                {
                    Screen screen = new Screen((2.0 * x) / img.getWidth() - 1.0, (-2.0 * y) / img.getHeight() + 1.0);

                    Ray ray = new Ray(cam.ShootRay(ref screen));

                    Intersection inter = new Intersection(ref ray);
                    if (scene.intersectionInter(ref inter))
                    {
                        img.SetPixel(x, y, inter.c);
                    }
                    else
                    {
                        img.SetPixel(x, y, new Colors(0, 0, 0, 0));
                    }
                }
            }
        }

    }
}
