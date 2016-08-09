using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class profile_panel : UserControl
    {
        public profile_panel()
        {
            InitializeComponent();
        }

        public class Root
        {
            public string email { get; set; }
            public string user_group { get; set; }
            public string fullname { get; set; }
            public string foto { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             postquery postauth;
             postauth = new postquery();
             string auth = postauth.post("http://dle.ru/profile.php", "login=" + textBox1.Text + "&password=" + textBox2.Text);

             if(auth == "false")
             {
                 MessageBox.Show("Неверное имя пользователя или пароль!");
             }
             else
             {
                 panel1.Visible = false;
                 Root q = JsonConvert.DeserializeObject<Root>(auth);
                 label3.Text = q.fullname;
                 label4.Text = q.email;
                 pictureBox1.ImageLocation = q.foto;
                 pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                 if(q.user_group == "1")
                 {
                     label6.Text = "Администратор";
                 }
             }
        }

        int iFormX, iFormY, iMouseX, iMouseY;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                panel1.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = panel1.Location.X;
            iFormY = panel1.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

    }
}
