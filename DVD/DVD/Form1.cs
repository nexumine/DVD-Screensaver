using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD
{
    public partial class CRT : Form
    {
        public CRT()
        {
            InitializeComponent();
        }
        int xspeed = 2;
        int yspeed = 2;
        Random rnd = new Random();
        string[] colours = { "red.png", "pink.png", "blue.png", "orange.png", "yellow.png", "blue.png", "purple.png", "white.png", "grey.png"};
        private void timer1_Tick(object sender, EventArgs e)
        {

            DVD.Top -= yspeed;
            DVD.Left -= xspeed;
            if (DVD.Left < 0)
            {
                xspeed = -xspeed;
                DVD.Image = Image.FromFile(colours[rnd.Next(0, 8)]);
                Console.WriteLine(colours[rnd.Next(0, 8)]);
            }
            if (DVD.Right > ClientSize.Width)
            {
                xspeed = -xspeed;
                DVD.Image = Image.FromFile(colours[rnd.Next(0, 8)]);
                Console.WriteLine(colours[rnd.Next(0, 8)]);
            }
            if (DVD.Top <= 0)
            {
                yspeed = -yspeed;
                DVD.Image = Image.FromFile(colours[rnd.Next(0, 8)]);
                Console.WriteLine(colours[rnd.Next(0, 8)]);
            }
            if (DVD.Bottom >= ClientSize.Height)
            {
                yspeed = -yspeed;
                DVD.Image = Image.FromFile(colours[rnd.Next(0, 8)]);
                Console.WriteLine(colours[rnd.Next(0, 8)]);
            }
        }
    }
}
