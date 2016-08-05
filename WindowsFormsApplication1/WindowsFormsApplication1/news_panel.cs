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
            postquery postnews;
            postnews = new postquery();
            string newspost = postnews.post("http://5game.su/test.php", "");
            Newspost news = JsonConvert.DeserializeObject<Newspost>(newspost);
            pictureBox1.ImageLocation = news.answer[0].short_story;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = news.answer[1].short_story;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = news.answer[2].short_story;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = news.answer[3].short_story;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.ImageLocation = news.answer[4].short_story;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
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
    }
}
