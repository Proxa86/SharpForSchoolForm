using System;
using System.Windows.Forms;
using System.Drawing;

namespace SharpForSchoolForm
{
    public partial class MyButtonClass : Form
    {
        private Button mrButton;
        public MyButtonClass()
        {
            mrButton = new Button();
            mrButton.Text = "Click me";
            mrButton.Top = 100;
            mrButton.Left = 100;
            mrButton.Height = 50;
            mrButton.Width = 70;
            mrButton.Click += new System.EventHandler(MyButtonClickEventHandler);
            this.MouseDown += new MouseEventHandler(TheMouseIsDown);
            //this.MouseClick += new MouseEventHandler(TheMouseWasClicked);
            this.MouseMove += new MouseEventHandler(TheMouseMoved);

            this.Controls.Add(mrButton);
        }

        void MyButtonClickEventHandler(object sender, EventArgs e)
        {
            mrButton.Text = "You click me!";
        }

        void TheMouseIsDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Text = "Click left mouse button";
            }
        }

        void TheMouseWasClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Width = this.Width + 100;
            else if (e.Button == MouseButtons.Right)
                this.Width = this.Width - 100;
        }

        void TheMouseMoved(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 3);

            g.DrawEllipse(redPen, e.X, e.Y, 40, 40);

            g.Dispose();
        }
    }
}
