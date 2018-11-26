using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpForSchoolForm3
{
    public partial class FormWithManyControls : Form
    {
        TreeView treeView1;
        Panel panel1;
        CheckBox checkBox1, checkBox2;
        RadioButton radioButton1, radioButton2;
        ListBox listBox1;

        public FormWithManyControls()
        {
            InitializeComponent();
            this.Text = "Anything form.";
            this.Height = 800;
            this.Width = 900;

            treeView1 = new TreeView();
            treeView1.BackColor = Color.BurlyWood;
            treeView1.Dock = DockStyle.Left; //Закрепление дерева
            treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);

            TreeNode tn = new TreeNode("Elements");
            tn.Expand();

            tn.Nodes.Add(new TreeNode("[Clear]"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("RadioButton"));
            tn.Nodes.Add(new TreeNode("ListBox"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("DataGridView"));
            tn.Nodes.Add(new TreeNode("MainMenu"));
            tn.Nodes.Add(new TreeNode("ToolBar"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("RichTextBox"));

            treeView1.Nodes.Add(tn);

            this.Controls.Add(treeView1);

            panel1 = new Panel();
            panel1.Dock = DockStyle.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Width = this.Width - treeView1.Width;

            this.Controls.Add(panel1);

        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "[Clear]")
                panel1.Controls.Clear();
            else if(e.Node.Text == "Label")
            {
                Label label1 = new Label();
                label1.Text = "This string use for otput test on screen!";

                label1.Location = new Point(180, 70);
                label1.Width = 400;
                //label1.Click += new EventHandler(lable1_Click);

                panel1.Controls.Add(label1);
            }
            else if(e.Node.Text == "Button")
            {
                Button button1 = new Button();
                button1.Text = "Click me!";
                button1.Location = new Point(300, 20);
                button1.Width = 120;
                button1.Height = 40;

                //button1.Click += new EventHandler(button1_Click);

                panel1.Controls.Add(button1);
            }
            else if(e.Node.Text == "CheckBox")
            {
                checkBox1 = new CheckBox();
                checkBox1.Text = "I OK!";
                checkBox1.Location = new Point(20, 40);
                checkBox1.Width = 150;
                //checkBox1.CheckedChanged += new EventHandler(CheckBox_checkedChange);

                panel1.Controls.Add(checkBox1);

                checkBox2 = new CheckBox();
                checkBox2.Text = "I not OK!";
                checkBox2.Location = new Point(20, 80);
                checkBox2.Width = 150;
                //checkBox2.CheckedChanged += new EventHandler(CheckBox_CheckedChange);

                panel1.Controls.Add(checkBox2);
            }
            else if(e.Node.Text == "RadioButton")
            {
                radioButton1 = new RadioButton();
                radioButton1.Text = "I good!";
                radioButton1.Location = new Point(20, 120);
                radioButton1.Width = 150;
                radioButton1.Height = 30;
                //radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChange);
                panel1.Controls.Add(radioButton1);

                radioButton2 = new RadioButton();
                radioButton2.Text = "I bad!";
                radioButton2.Location = new Point(20, 160);
                radioButton2.Width = 150;
                radioButton2.Height = 30;
                //radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChange);

                panel1.Controls.Add(radioButton2);
            }
            else if(e.Node.Text == "ListBox")
            {
                listBox1 = new ListBox();
                listBox1.Location = new Point(20, 250);
                listBox1.Width = 100;
                listBox1.Items.Add("Green");
                listBox1.Items.Add("Yellow");
                listBox1.Items.Add("Blue");
                listBox1.Items.Add("Gray");

                //listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChange);

                panel1.Controls.Add(listBox1);
            }
            else if(e.Node.Text == "TextBox")
            {
                TextBox textBox1 = new TextBox();
                textBox1.Multiline = true;
                textBox1.Text = "This is text window. You can enter text here.\r\nShow this text and enter your text";
                textBox1.Location = new Point(180, 100);
                textBox1.Width = 400;
                textBox1.Height = 40;

                panel1.Controls.Add(textBox1);
            }
            else if (e.Node.Text == "TabControl")
            {
                TabControl tabControl1 = new TabControl();
                tabControl1.Location = new Point(190, 150);
                tabControl1.Size = new Size(300, 300);

                TabPage tabPage1 = new TabPage("Vudic");

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
                pictureBox1.Size = new Size(300, 200);

                tabPage1.Controls.Add(pictureBox1);

                Label labelV = new Label();
                labelV.Top = 200;
                labelV.Size = new Size(300, 50);
                labelV.Text = "This tree. It is cool";
                tabPage1.Controls.Add(labelV);

                tabControl1.Controls.Add(tabPage1);

                TabPage tabPage2 = new TabPage("His computer!");

                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
                pictureBox2.Size = new Size(300, 200);

                tabPage2.Controls.Add(pictureBox2);

                Label labelC = new Label();
                labelC.Top = 200;
                labelC.Size = new Size(300, 50);
                labelC.Text = "This cool wether!";
                tabPage2.Controls.Add(labelC);


                tabControl1.Controls.Add(tabPage2);
                panel1.Controls.Add(tabControl1);
            }
            else if (e.Node.Text == "DataGridView")
            {

            }
            else if (e.Node.Text == "MainMenu")
            {

            }
            else if (e.Node.Text == "ToolBar")
            {

            }
            else if (e.Node.Text == "PictureBox")
            {

            }
            else if (e.Node.Text == "RichTextBox")
            {

            }
        }
    }
}
