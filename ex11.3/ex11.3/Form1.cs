using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int offset, buffer, body_X, body_Y, left_leg_x, left_leg_y, right_leg_x, right_leg_y, neck_X, neck_Y, head_X, head_Y, left_hand_X, left_hand_Y, right_hand_X, right_hand_Y;

        private void offsetPlus_Click(object sender, EventArgs e)
        {
            offset += 3;
        }

        private void offsetMinus_Click(object sender, EventArgs e)
        {
            offset -= 3;
        }

        private Pen pen = new Pen(Color.FromArgb(0xFF, 0xCE, 0x85), 4);
        private Brush brush = new SolidBrush(Color.FromArgb(0xFF, 0xCE, 0x85));
        private Brush eyeBrush = new SolidBrush(Color.White);
        private Brush hatBrush = new SolidBrush(Color.FromArgb(0xF5, 0xDD, 0x14));
        private Rectangle head = new Rectangle(85, 135, 30, 45);
        private Rectangle eye = new Rectangle(107, 150, 6, 6);
        private Rectangle hat = new Rectangle(80, 130, 40, 40);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            pen.Color = Color.FromArgb(0xFF, 0xCE, 0x85);
            g.DrawLine(pen, body_X, body_Y, left_leg_x, left_leg_y);
            g.DrawLine(pen, body_X, body_Y, right_leg_x, right_leg_y);
            g.DrawLine(pen, body_X, body_Y, neck_X, neck_Y);
            g.FillEllipse(brush, head);
            g.DrawLine(pen, neck_X, neck_Y, left_hand_X, left_hand_Y);
            g.DrawLine(pen, neck_X, neck_Y, right_hand_X, right_hand_Y);
            g.FillEllipse(eyeBrush, eye);
            g.FillPie(hatBrush, hat, 0, -180);
            pen.Color = Color.FromArgb(0xEA, 0xD2, 0x0B);
            //g.DrawLine(pen,);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            offset = 2;
            body_X = 100;
            body_Y = 240;
            neck_X = 100;
            neck_Y = 180;
            left_leg_x = 70;
            left_leg_y = 300;
            right_leg_x = 130;
            right_leg_y = 300;
            left_hand_X = 70;
            left_hand_Y = 240;
            right_hand_X = 130;
            right_hand_Y = 240;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            head.X += offset;
            eye.X += offset;
            hat.X += offset;
            body_X += offset;
            neck_X += offset;
            left_leg_x += offset;
            right_leg_x += offset;
            head_X += offset;
            left_hand_X += offset;
            right_hand_X += offset;
            buffer = offset;
            if (right_hand_X > Width)
            {
                Form1_Load(sender, e);
                head.X = 85;
                eye.X = 107;
                hat.X = 80;
                offset = buffer;
            }
            Invalidate();
        }
    }
}
