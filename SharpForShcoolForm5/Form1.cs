using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpForShcoolForm5
{
    public partial class PictureFliper : Form
    {
        Button button1;
        Bitmap bitmap1;
        PictureBox pictureBox1;

        public PictureFliper()
        {
            InitializeComponent();
            this.Size = new Size(302, 240);
            this.Text = "Original picture";

            button1 = new Button();
            button1.Text = "Turn picture";
            button1.Location = new Point(100, 150);
            button1.Size = new Size(70, 40);
            button1.Click += new EventHandler(button1_Click);

            this.Controls.Add(button1);

            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = new Size(300, 196);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            bitmap1 = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
            pictureBox1.Image = bitmap1;

            this.Controls.Add(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap1;
            this.Text = "Turn picture";
        }
    }
}
