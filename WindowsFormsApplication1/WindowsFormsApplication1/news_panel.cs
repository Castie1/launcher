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
        string site1;
        string site2;
        string site3;
        string site4;
        string site5;

        //=========================================================//
        // Инициализация новостной панели,отправка post запроса... //
        //=========================================================//
        public news_panel()
        {
            InitializeComponent();
            ////////////////
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox2;
            label3.Parent = this.pictureBox3;
            label4.Parent = this.pictureBox4;
            label5.Parent = this.pictureBox5;
            label1.BackColor = Color.FromArgb(0, Color.White);
            label2.BackColor = Color.FromArgb(0, Color.White);
            label3.BackColor = Color.FromArgb(0, Color.White);
            label4.BackColor = Color.FromArgb(0, Color.White);
            label5.BackColor = Color.FromArgb(0, Color.White);
            /////////////////
            postquery postnews;
            postnews = new postquery();
            string newspost = postnews.post("http://5game.su/test.php", "");
            Newspost news = JsonConvert.DeserializeObject<Newspost>(newspost);
            pictureBox1.ImageLocation = news.answer[0].short_story;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = news.answer[1].short_story;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = news.answer[2].short_story;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = news.answer[3].short_story;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = news.answer[4].short_story;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            ///////////////////
            label1.Text = news.answer[0].title;
            label2.Text = news.answer[1].title;
            label3.Text = news.answer[2].title;
            label4.Text = news.answer[3].title;
            label5.Text = news.answer[4].title;
            //////////////////
             site1 = "http://5game.su/" + news.answer[0].id + "-" + news.answer[0].alt_name + ".html";
             site2 = "http://5game.su/" + news.answer[1].id + "-" + news.answer[1].alt_name + ".html";
             site3 = "http://5game.su/" + news.answer[2].id + "-" + news.answer[2].alt_name + ".html";
             site4 = "http://5game.su/" + news.answer[3].id + "-" + news.answer[3].alt_name + ".html";
             site5 = "http://5game.su/" + news.answer[4].id + "-" + news.answer[4].alt_name + ".html";
            /////////////////
        }

        //=========================================================//
        //           классы для принятия json строк                //
        //=========================================================//
        public class Answer
        {
            public string id { get; set; }
            public string title { get; set; }
            public string short_story { get; set; }
            public string alt_name { get; set; }
        }
        public class Newspost
        {
            public List<Answer> answer { get; set; }
        }

        //=========================================================//
        //       переход по ссылкам из картинки                    //
        //=========================================================//
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site5);
        }

        //=========================================================//
        //       переход по ссылкам из текста                      //
        //=========================================================//
        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site1);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site2);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site3);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site4);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site5);
        }

        //=========================================================//
        //     изменение цвета при наведении на картинки           //
        //=========================================================//
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }
        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        //=========================================================//
        //     изменение цвета при наведении на label              //
        //=========================================================//
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(132, 185, 41);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        //=========================================================//
        //               затемнение боксов                         //
        //=========================================================//
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            e.Graphics.FillRectangle(Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            e.Graphics.FillRectangle(Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            e.Graphics.FillRectangle(Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            e.Graphics.FillRectangle(Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            e.Graphics.FillRectangle(Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

    }
}
