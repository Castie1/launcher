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
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            label1.Parent = this.pictureBox2;
            label2.Parent = this.pictureBox3;
            label3.Parent = this.pictureBox4;
            label4.Parent = this.pictureBox5;
            label5.Parent = this.pictureBox6;
            label1.BackColor = Color.FromArgb(100, Color.White);
            label2.BackColor = Color.FromArgb(100, Color.White);
            label3.BackColor = Color.FromArgb(100, Color.White);
            label4.BackColor = Color.FromArgb(100, Color.White);
            label5.BackColor = Color.FromArgb(100, Color.White);


            postquery postnews;
            postnews = new postquery();
            string newspost = postnews.post("http://5game.su/test.php", "");
            Newspost news = JsonConvert.DeserializeObject<Newspost>(newspost);
            pictureBox2.ImageLocation = news.answer[0].short_story;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = news.answer[1].short_story;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = news.answer[2].short_story;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = news.answer[3].short_story;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.ImageLocation = news.answer[4].short_story;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        int iFormX, iFormY, iMouseX, iMouseY;

        public class Answer
        {
            public string title { get; set; }
            public string short_story { get; set; }
        }

        public class Newspost
        {
            public List<Answer> answer { get; set; }
        }

        /*public bool news
        {
            get { return news_panel1.Visible; }
            set { news_panel1.Visible = value; }
        }
        public bool profile
        {
            get { return profile_panel1.Visible; }
            set { profile_panel1.Visible = value; }
        }*/

        private void panel_moving_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
            
        }

        private void panel_moving_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
        
    }
}
