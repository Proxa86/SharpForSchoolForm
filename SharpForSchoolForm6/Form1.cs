using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpForSchoolForm6
{
    public partial class SimpleShapeMaker : Form
    {
        public SimpleShapeMaker()
        {
            InitializeComponent();

            this.BackColor = Color.White;

            Button button1 = new Button();
            button1.Text = "Will be drawing";
            button1.Location = new Point(110, 10);
            button1.Size = new Size(70, 40);
            button1.BackColor = Color.LightGray;
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSomeShapes();
        }

        private void DrawSomeShapes()
        {
            Graphics g = this.CreateGraphics();

            Pen redPen = new Pen(Color.Red, 3);

            g.DrawLine(redPen, 140, 170, 140, 240);
            g.DrawRectangle(redPen, 50, 60, 50, 60);
            g.DrawEllipse(redPen, 150, 100, 100, 60);

            g.Dispose();

        }
    }
}
