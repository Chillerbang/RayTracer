using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raytracer_v2
{
    public partial class UI : Form
    {
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
            int width = 1920;
            int height = 1080;
            ImgRender ir = new ImgRender(width, height);
            pictureBox1.Image =  ir.saveImage("imageTEst");
        }

        private void rayTrace(Bitmap img, Camera cam, Shape scene)
        {

        }
    }
}
