using System;
using RayTracer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raytracer_v2
{
    public partial class UI : Form
    {
        private ImgRender ir;
        int width = 400;
        int height = 200;

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.Text = "Ray Tracer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start Ray trace
            ////Camera c = new Camera();
            //ir = new ImgRender(width, height);
            //pictureBox1.Image =  ir.saveImage("imageTEst");
            //string filename = "TestImage";
            //pictureBox1.Image.Save(Application.StartupPath + filename + ".jpg", ImageFormat.Jpeg);

            ir = new ImgRender(width, height);

            Vector orgineCame = new Vector(-7.0, 1.0, 0.0);
            Vector dirCamera = new Vector(0.0, 1.0, 0.0);
            Vector verticCamera = new Vector(0.0, 0.0, 0.0);


            Camera came = new Camera(ref orgineCame,ref dirCamera, ref verticCamera, Math.PI, width/height * 1.0);

            Scene se = new Scene();
            Vector pOrgin1 = new Vector(0.0, 0.0, 0.0);
            Vector pDir1 = new Vector(0.0, 0.0, 1.0);
            Vector sOrgin1 = new Vector(0.0, 0.0, 0.0);
            double r1 = 1.0;
            Vector sOrgin2 = new  Vector(0.0, 0.0, 0.0);
            double r2 = 1.0;
            Plane p1 = new Plane(ref pOrgin1, ref pDir1);
            Sphere s1 = new Sphere(ref sOrgin1,ref r1);
            Sphere s2 = new Sphere(ref sOrgin2, ref r2);
            Shape sh1 = p1;
            Shape sh2 = s1;
            Shape sh3 = s2;

            //se.AddShape(ref sh1);
            se.AddShape(ref sh2);
            Shape s = se;

            rayTrace(ref ir,ref came,ref s);
            pictureBox1.Image = ir.saveImage("imageTEst");
            string filename = "TestImage";
            pictureBox1.Image.Save(Application.StartupPath + filename + ".jpg", ImageFormat.Jpeg);
        }

        private void rayTrace(ref ImgRender img, ref Camera cam, ref Shape scene)
        {
            for (int x = 0; x < img.getWidth(); x++)
            {
                for (int y =0; y < img.getHeight(); y++)
                {
                    _2DVector screen = new _2DVector((2.0 * x)/ img.getWidth() -1.0 , (-2.0 * y) / img.getHeight() + 1.0);

                    Ray ray = new Ray( cam.ShootRay(ref screen));

                    
                    Intersection inter = new Intersection(ref ray);
                    if (scene.intersectionInter(ref inter))
                    {
                        img.SetPixel(x, y, 0.0);
                    }
                    else
                    {
                        img.SetPixel(x, y, 1.0);
                    }
                }
            }
        }
    }
}
