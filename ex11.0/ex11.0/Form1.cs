using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1, y1, x2, y2, r;

        private double a;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a -= 0.02; // Уменьшаем угол на 0,1 радиану
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }

        private Pen pen = new Pen(Color.DarkRed, 2);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            r = 300; // Радиус стрелки
            a = 0; // Угол поворота стрелки
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));

        }

    }
}
