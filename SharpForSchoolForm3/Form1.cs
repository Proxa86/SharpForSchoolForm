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
                label1.Click += new EventHandler(lable1_Click);

                panel1.Controls.Add(label1);
            }
            else if(e.Node.Text == "Button")
            {
                Button button1 = new Button();
                button1.Text = "Click me!";
                button1.Location = new Point(300, 20);
                button1.Width = 120;
                button1.Height = 40;

                button1.Click += new EventHandler(button1_Click);

                panel1.Controls.Add(button1);
            }
            else if(e.Node.Text == "CheckBox")
            {
                checkBox1 = new CheckBox();
                checkBox1.Text = "I OK!";
                checkBox1.Location = new Point(20, 40);
                checkBox1.Width = 150;
                checkBox1.CheckedChanged += new EventHandler(CheckBox_checkedChange);

                panel1.Controls.Add(checkBox1);

                checkBox2 = new CheckBox();
                checkBox2.Text = "I not OK!";
                checkBox2.Location = new Point(20, 80);
                checkBox2.Width = 150;
                checkBox2.CheckedChanged += new EventHandler(CheckBox_checkedChange);

                panel1.Controls.Add(checkBox2);
            }
            else if(e.Node.Text == "RadioButton")
            {
                radioButton1 = new RadioButton();
                radioButton1.Text = "I good!";
                radioButton1.Location = new Point(20, 120);
                radioButton1.Width = 150;
                radioButton1.Height = 30;
                radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChange);
                panel1.Controls.Add(radioButton1);

                radioButton2 = new RadioButton();
                radioButton2.Text = "I bad!";
                radioButton2.Location = new Point(20, 160);
                radioButton2.Width = 150;
                radioButton2.Height = 30;
                radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChange);

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

                listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChange);

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

                TabPage tabPage3 = new TabPage("Computer!");

                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = new Bitmap("C:\\Users\\user200\\Downloads\\image.gif");
                pictureBox3.Size = new Size(300, 200);
                tabPage3.Controls.Add(pictureBox3);

                Label labelT = new Label();
                labelT.Top = 200;
                labelT.Size = new Size(300, 50);
                labelT.Text = "This is warm wether!";
                tabPage3.Controls.Add(labelT);

                tabControl1.Controls.Add(tabPage3);
                panel1.Controls.Add(tabControl1);
            }
            else if (e.Node.Text == "DataGridView")
            {
                DataSet dataSet1 = new DataSet("Example DataSet");
                dataSet1.ReadXml("C:\\Users\\user200\\Downloads\\marks.xml");

                DataGridView dataGridView1= new DataGridView();
                dataGridView1.Width = 250;
                dataGridView1.Height = 150;
                dataGridView1.Location = new Point(20, 500);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "authors";
                panel1.Controls.Add(dataGridView1);
            }
            else if (e.Node.Text == "MainMenu")
            {
                MainMenu mainMenu1 = new MainMenu();
                MenuItem menuItem1 = new MenuItem("File");
                menuItem1.MenuItems.Add("Exit", new EventHandler(mainMenu1_Exit_Select));
                mainMenu1.MenuItems.Add(menuItem1);

                MenuItem menuItem2 = new MenuItem("Background");
                menuItem2.MenuItems.Add("Choose", new EventHandler(mainMenu1_ColorOwn_Select));
                menuItem2.MenuItems.Add("White", new EventHandler(mainMenu1_ColorWhite_Select));
                mainMenu1.MenuItems.Add(menuItem2);

                this.Menu = mainMenu1;

                MessageBox.Show("Main menu add in window. Try it");
            }
            else if (e.Node.Text == "ToolBar")
            {
                ToolBar toolBar1 = new ToolBar();
                toolBar1.Size = new Size(100, 100);
                toolBar1.Dock = DockStyle.Right;
                ImageList imageList1 = new ImageList();
                imageList1.Images.Add(new Bitmap("C:\\Users\\user200\\Downloads\\folderdocument.png"));
                imageList1.Images.Add(new Bitmap("C:\\Users\\user200\\Downloads\\documents.png"));
                imageList1.Images.Add(new Bitmap("C:\\Users\\user200\\Downloads\\256.png"));
                imageList1.Images.Add(new Bitmap("C:\\Users\\user200\\Downloads\\folder.png"));
                toolBar1.ImageList = imageList1;

                ToolBarButton toolBarButton1 = new ToolBarButton("New");
                toolBarButton1.ImageIndex = 0;
                toolBar1.Buttons.Add(toolBarButton1);

                ToolBarButton toolBarButton2 = new ToolBarButton("Open");
                toolBarButton2.ImageIndex = 1;
                toolBar1.Buttons.Add(toolBarButton2);

                ToolBarButton toolBarButton3 = new ToolBarButton("Copy");
                toolBarButton3.ImageIndex = 2;
                toolBar1.Buttons.Add(toolBarButton3);

                ToolBarButton toolBarButton4 = new ToolBarButton("Exit");
                toolBarButton4.ImageIndex = 3;
                toolBar1.Buttons.Add(toolBarButton4);

                toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(toolBar1_Click);

                panel1.Controls.Add(toolBar1);
            }
            else if (e.Node.Text == "PictureBox")
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = new Bitmap("C:\\Users\\user200\\Downloads\\folder.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Location = new Point(500, 250);
                pictureBox1.Size = new Size(250, 200);

                panel1.Controls.Add(pictureBox1);
            }
            else if (e.Node.Text == "RichTextBox")
            {
                RichTextBox richTextBox1 = new RichTextBox();
                richTextBox1.LoadFile("C:\\Users\\user200\\Downloads\\marks.xml", RichTextBoxStreamType.PlainText);
                richTextBox1.WordWrap = false;
                richTextBox1.BorderStyle = BorderStyle.Fixed3D;
                richTextBox1.BackColor = Color.Beige;
                richTextBox1.Size = new Size(250, 150);
                richTextBox1.Location = new Point(300, 500);

                panel1.Controls.Add(richTextBox1);

            }
        }
       

        private void toolBar1_Click(object sender, ToolBarButtonClickEventArgs e)
        {
            if(e.Button.Text == "Open")
            {
                MessageBox.Show("Here open new file");
            }
            else if(e.Button.Text == "New")
            {
                MessageBox.Show("Here create new file");
            }
            else if(e.Button.Text == "Copy")
            {
                MessageBox.Show("Here copy file");
            }
        }

        private void mainMenu1_ColorWhite_Select(object sender, EventArgs e)
        {
            treeView1.BackColor = Color.White;
        }

        private void mainMenu1_ColorOwn_Select(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = treeView1.BackColor;
            colorDialog1.ShowDialog();
            treeView1.BackColor = colorDialog1.Color;
        }

        private void mainMenu1_Exit_Select(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want end work?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();
        }

        private void listBox1_SelectedIndexChange(object sender, EventArgs e)
        {
            switch(listBox1.SelectedItem.ToString())
            {
                case "Green": treeView1.BackColor = Color.Green;
                    break;
                case "Yellow": treeView1.BackColor = Color.Yellow;
                    break;
                case "Blue": treeView1.BackColor = Color.Blue;
                    break;
                case "Gray": treeView1.BackColor = Color.Gray;
                    break;
            }
        }

        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("You choose radioButton1");
            else if (radioButton2.Checked)
                MessageBox.Show("You choose radioButton2");
        }

        private void CheckBox_checkedChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Good luck");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("You choose checkBox1");
            }
            else MessageBox.Show("You choose checkBox2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You put button :)");
        }

        private void lable1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, label have events on click.");
        }
    }
}
