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
        }

        int iFormX, iFormY, iMouseX, iMouseY;

        public bool news
        {
            get { return news_panel1.Visible; }
            set { news_panel1.Visible = value; }
        }
        public bool profile
        {
            get { return profile_panel1.Visible; }
            set { profile_panel1.Visible = value; }
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
