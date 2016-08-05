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
            //
            {
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

        int iFormX, iFormY, iMouseX, iMouseY;

        public bool news
        {
            get { return panel_news.Visible; }
            set { panel_news.Visible = value; }
        }

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
