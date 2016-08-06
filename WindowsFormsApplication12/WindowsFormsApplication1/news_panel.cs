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

namespace WindowsFormsApplication1
{
    public partial class news_panel : UserControl
    {
        public news_panel()
        {
            InitializeComponent();
            ///         
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            /*label3.Parent = this.pictureBox3;
            label4.Parent = this.pictureBox4;
            label5.Parent = this.pictureBox5;*/
            label1.BackColor = Color.FromArgb(100, Color.White);
            label2.BackColor = Color.FromArgb(100, Color.White);
            /*label3.BackColor = Color.FromArgb(100, Color.White);
            label4.BackColor = Color.FromArgb(100, Color.White);
            label5.BackColor = Color.FromArgb(100, Color.White);*/
            ///
            postquery postnews;
            postnews = new postquery();
            string newspost = postnews.post("http://5game.su/test.php", "");
            Newspost news = JsonConvert.DeserializeObject<Newspost>(newspost);
           /* pictureBox1.ImageLocation = news.answer[0].short_story;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = news.answer[1].short_story;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = news.answer[2].short_story;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = news.answer[3].short_story;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = news.answer[4].short_story;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;*/
            ///
            label1.Text = "kf,t1";
                label2.Text = "kf,t2";
           /* label3.Text = "1241241414";
            label4.Text = "1241241414";
            label5.Text = "1241241414";*/
        }

        public class Answer
        {
            public string title { get; set; }
            public string short_story { get; set; }
        }

        public class Newspost
        {
            public List<Answer> answer { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.ru/");
        }

    }
}
