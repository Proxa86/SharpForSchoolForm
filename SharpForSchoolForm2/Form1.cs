using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpForSchoolForm2
{
    public partial class Form1 : Form
    {
        ListBox listBox1;

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(400, 400);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = new Size(this.Width, 150);
            Bitmap image1 = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
            pictureBox1.Image = (Image)image1;
            this.Controls.Add(pictureBox1);

            Button button1 = new Button();
            button1.Location = new Point(150, 160);
            button1.Size = new Size(100, 30);
            button1.Text = "Click me!";
            button1.Click += new EventHandler(button1_Click);

            this.Controls.Add(button1);

            listBox1 = new ListBox();
            listBox1.Location = new Point(20, 200);
            listBox1.Size = new Size(100, 100);
            listBox1.Items.Add("Forest");
            listBox1.Items.Add("Steppe");
            listBox1.Items.Add("Lake");
            listBox1.Items.Add("Sea");
            listBox1.Items.Add("Ocean");
            listBox1.SelectedIndex = 2;
            this.Controls.Add(listBox1);
        }

        void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "You choice " + listBox1.SelectedItem, "Warning", MessageBoxButtons.OK);
        }

        void InInitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size(292, 273);
            this.Name = "MyForm";

            this.ResumeLayout(false);
        }
    }
}
