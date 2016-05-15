using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"E:\Lesson\C#\1050414_stu\pic\" + (i+1) + ".jpg");
            pictureBox1.Location = new Point(Location.X, Location.Y); 
            pictureBox1.Size = new Size(Size.Width, Size.Height-50);

            radioButton1.Text = "順時鐘輪圖";
            radioButton2.Text = "逆時鐘輪圖";
            button1.Text = "重置";

            radioButton1.Checked = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(radioButton1.Checked)
            {
                i = (i + 1) % 3;
            }
            else
            {
                i = i == 0 ? 3 : i;
                i = (i - 1) % 3;
            }
            pictureBox1.Image = Image.FromFile(@"E:\Lesson\C#\1050414_stu\pic\" + (i+1) + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            pictureBox1.Image = Image.FromFile(@"E:\Lesson\C#\1050414_stu\pic\" + (i + 1) + ".jpg");
        }
    }
}
