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
            /* postquery postauth;
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
             double thisversion = Convert.ToDouble(Application.ProductVersion.Replace(".", ""));
             XmlDocument doc;
             doc = new XmlDocument();
             doc.Load("http://dle.ru/launcher/version.xml");
             double newversion = Convert.ToDouble(doc.GetElementsByTagName("myprogram")[0].InnerText.Replace(".", ""));
             textBox3.Text = thisversion.ToString() + "/r/n" + newversion.ToString();*/
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                double thisversion = Convert.ToDouble(Application.ProductVersion.Replace(".", ""));
                XmlDocument doc;
                doc = new XmlDocument();
                doc.Load("http://dle.ru/launcher/version.xml");
                double newversion = Convert.ToDouble(doc.GetElementsByTagName("myprogram")[0].InnerText.Replace(".", ""));

                if (thisversion < newversion)
                {
                    MessageBox.Show("qwe");
                }
            }
            catch (Exception) { }
        }
    }
}
