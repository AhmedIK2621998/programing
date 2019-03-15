using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDa1
{
    
    public partial class Form1 : Form
    {
             public void DDA1(Point p1,Point p2)
            {
                Bitmap p = new Bitmap(show.Width, show.Height);
                int dx = p2.X - p1.X;
                int dy = p2.Y - p1.Y;
                int steps = (Math.Abs(dx) > Math.Abs(dy)) ? Math.Abs(dx) : Math.Abs(dy);
                float Incx = dx / (float)steps;
                float Incy = dy / (float)steps;
                float x = p1.X;
                float y = p2.Y;
                for (int i = 0; i <= steps; i++)
                {
                    p.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.DarkGreen);
                    x = x + Incx;
                    y = y + Incy;
                }
                show.Image = p;
            }
                public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drawline_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(int.Parse(p1x.Text),int.Parse(p1y.Text));
            Point p2 = new Point(int.Parse(p2x.Text), int.Parse(p2y.Text));
            DDA1(p1, p2);
        }
    }
}
