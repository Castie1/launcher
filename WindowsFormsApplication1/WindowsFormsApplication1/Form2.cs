using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            TopMost = true;
            InitializeComponent();
        }

        //=========================================================//
        //                    Кнопка закрыть                       //
        //=========================================================//
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close_Click_;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Close();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Close_Move_;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //=========================================================//
        //         Перемещение окна за верхнюю панель              //
        //=========================================================//
        int iFormX, iFormY, iMouseX, iMouseY;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.myForm.treee = 1;
        }

        private void panel_mov_setting_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        private void panel_mov_setting_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
