using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x1, y1, x1_2, y1_2, x1_3, y1_3, x1_4, y1_4, x2_2, y2_2, x2_3, y2_3, x2_4, y2_4, x3_2, y3_2, x3_3, y3_3, x3_4, y3_4, x4_2, y4_2, x4_3, y4_3, x4_4, y4_4, r;

        private double a, offset;
        private PointF vintMain, vint1_2, vint1_3, vint1_4, vint2_2, vint2_3, vint2_4, vint3_2, vint3_3, vint3_4, vint4_2, vint4_3, vint4_4;
        private Pen pen = new Pen(Color.Black);

        private void vint1()
        {
            x1_2 = x1 + (int)(r / 2 * Math.Cos(a + 0.2));
            y1_2 = y1 - (int)(r / 2 * Math.Sin(a + 0.2));
            x1_3 = x1 + (int)(r * Math.Cos(a));
            y1_3 = y1 - (int)(r * Math.Sin(a));
            x1_4 = x1 + (int)(r / 2 * Math.Cos(a - 0.2));
            y1_4 = y1 - (int)(r / 2 * Math.Sin(a - 0.2));
            vint1_2.X = x1_2;
            vint1_2.Y = y1_2;
            vint1_3.X = x1_3;
            vint1_3.Y = y1_3;
            vint1_4.X = x1_4;
            vint1_4.Y = y1_4;
        }

        private void vint2()
        {
            x2_2 = x1 + (int)(r / 2 * Math.Cos(a + 0.2 + 15.7));
            y2_2 = y1 - (int)(r / 2 * Math.Sin(a + 0.2 + 15.7));
            x2_3 = x1 + (int)(r * Math.Cos(a + 15.7));
            y2_3 = y1 - (int)(r * Math.Sin(a + 15.7));
            x2_4 = x1 + (int)(r / 2 * Math.Cos(a - 0.2 + 15.7));
            y2_4 = y1 - (int)(r / 2 * Math.Sin(a - 0.2 + 15.7));
            vint2_2.X = x2_2;
            vint2_2.Y = y2_2;
            vint2_3.X = x2_3;
            vint2_3.Y = y2_3;
            vint2_4.X = x2_4;
            vint2_4.Y = y2_4;
        }

        private void vint3()
        {
            x3_2 = x1 + (int)(r / 2 * Math.Cos(a + 0.2 + 7.85));
            y3_2 = y1 - (int)(r / 2 * Math.Sin(a + 0.2 + 7.85));
            x3_3 = x1 + (int)(r * Math.Cos(a + 7.85));
            y3_3 = y1 - (int)(r * Math.Sin(a + 7.85));
            x3_4 = x1 + (int)(r / 2 * Math.Cos(a - 0.2 + 7.85));
            y3_4 = y1 - (int)(r / 2 * Math.Sin(a - 0.2 + 7.85));
            vint3_2.X = x3_2;
            vint3_2.Y = y3_2;
            vint3_3.X = x3_3;
            vint3_3.Y = y3_3;
            vint3_4.X = x3_4;
            vint3_4.Y = y3_4;
        }

        private void vint4()
        {
            x4_2 = x1 + (int)(r / 2 * Math.Cos(a + 0.2 - 7.85));
            y4_2 = y1 - (int)(r / 2 * Math.Sin(a + 0.2 - 7.85));
            x4_3 = x1 + (int)(r * Math.Cos(a - 7.85));
            y4_3 = y1 - (int)(r * Math.Sin(a - 7.85));
            x4_4 = x1 + (int)(r / 2 * Math.Cos(a - 0.2 - 7.85));
            y4_4 = y1 - (int)(r / 2 * Math.Sin(a - 0.2 - 7.85));
            vint4_2.X = x4_2;
            vint4_2.Y = y4_2;
            vint4_3.X = x4_3;
            vint4_3.Y = y4_3;
            vint4_4.X = x4_4;
            vint4_4.Y = y4_4;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= offset;
            vint1();
            vint2();
            vint3();
            vint4();
            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawCurve(pen, new PointF[] { vintMain, vint1_2, vint1_3, vint1_4, vintMain, vint2_2, vint2_3, vint2_4, vintMain });
            g.DrawCurve(pen, new PointF[] { vintMain, vint3_2, vint3_3, vint3_4, vintMain, vint4_2, vint4_3, vint4_4, vintMain });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            offset = 0.08;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            a = 0;
            r = ClientSize.Height / 4;
            vintMain.X = x1;
            vintMain.Y = y1;
            vint1();
            vint2();
            vint3();
            vint4();
        }

        private void offsetPlus_Click(object sender, EventArgs e)
        {
            offset += 0.01;
        }

        private void offsetMinus_Click(object sender, EventArgs e)
        {
            offset -= 0.01;
        }
    }
}
