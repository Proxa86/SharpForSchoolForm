using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpForSchoolForm7
{
    public partial class FunWithTheMouce : Form
    {
        PictureBox pictureBox1;
        Label label1;
        Point spotClicked;

        public FunWithTheMouce()
        {
            InitializeComponent();
            this.Size = new Size(640, 480);

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            //pictureBox1.Dock = DockStyle.Fill;

            this.Controls.Add(pictureBox1);
        }
    }
}
