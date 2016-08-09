using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.Close_Move_;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Close;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.Close_Click_;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.Minimize_Move_;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Minimize;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.myForm.WindowState = FormWindowState.Minimized;
            if (Program.myForm.treee == 1)
            {
                if (Program.myForm.WindowState == FormWindowState.Minimized)
                {
                    Program.myForm.ShowInTaskbar = false;
                    Program.myForm.tree = true;
                }
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.Minimize_Click_;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {         
            Form2 form;
            form = new Form2();
            form.Show();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Setting_Move_;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Setting;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Setting_Click_;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
