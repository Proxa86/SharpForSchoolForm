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
            pictureBox1.Image = new Bitmap("C:\\Users\\user200\\Downloads\\more.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Dock = DockStyle.Fill;

            this.Controls.Add(pictureBox1);

            label1 = new Label();
            label1.BackColor = Color.Wheat;
            label1.Dock = DockStyle.Bottom;
            label1.Text = "If put left button mouse then drawing rectangle.\n" +
                "If put right button mouse then change bright rectangle.\n" +
                "If put button SHIFT and move mouse then drawing yellow circle.";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(label1);

            pictureBox1.MouseDown += new MouseEventHandler(MouseButtonIsDown);
            pictureBox1.MouseUp += new MouseEventHandler(MouseButtonIsUp);
            pictureBox1.MouseMove += new MouseEventHandler(MouseMoved);
            
        }

        private void MouseMoved(object sender, MouseEventArgs e)
        {
            if((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Graphics g = pictureBox1.CreateGraphics();
                Pen yellowPen = new Pen(Color.Yellow, 3);
                g.DrawEllipse(yellowPen, e.X, e.Y, 40, 40);
                g.Dispose();
            }
        }

        private void MouseButtonIsUp(object sender, MouseEventArgs e)
        {
            Rectangle r = new Rectangle();
            r.X = spotClicked.X;
            r.Y = spotClicked.Y;

            r.Width = e.X - spotClicked.X;
            r.Height = e.Y - spotClicked.Y;

            if (e.Button == MouseButtons.Left)
            {
                Graphics g = pictureBox1.CreateGraphics();
                Pen redPen = new Pen(Color.Red, 2);
                g.DrawRectangle(redPen, r);
            }
            else ChangeLightness(r);
        }

        private void ChangeLightness(Rectangle rect)
        {
            int newRed, newGreen, newBlue;
            Color pixel;

            // Copy image
            Bitmap picture = new Bitmap(pictureBox1.Image);

            // If size picture more then write warrning

            if((rect.Width > 150) || rect.Height > 150)
            {
                DialogResult result = MessageBox.Show(
                    "You choose very big picture! " +
                    "Change light take some time!", "Warrning", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) return;
            }

            // Change pixel in picture
            for(int x = rect.X; x < rect.X + rect.Width; x++)
            {
                for(int y = rect.Y; y < rect.Y + rect.Height; y++)
                {
                    pixel = picture.GetPixel(x, y);

                    newRed = (int)Math.Round(pixel.R * 2.0, 0);
                    if (newRed > 255) newRed = 255;
                    newGreen = (int)Math.Round(pixel.R * 2.0, 0);
                    if (newGreen > 255) newGreen = 255;
                    newBlue = (int)Math.Round(pixel.B * 2.0, 0);
                    if (newBlue > 255) newBlue = 255;

                    picture.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                }
            }

            pictureBox1.Image = picture;

        }

        private void MouseButtonIsDown(object sender, MouseEventArgs e)
        {
            // Save coordinates point after put button
            spotClicked.Y = e.Y;
            spotClicked.X = e.X;
        }
    }
}
