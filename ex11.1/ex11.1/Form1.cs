using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x, y, k, tick, hear_beat, timer_lock;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) - 10);
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + 10);
            Form1_Load(sender, e);
        }
        int trigger;
        private void trigger_button_Click(object sender, EventArgs e)
        {
            if (trigger == 0)
            {
                timer1.Enabled = true;
                trigger++;
            }
            else
            {
                timer1.Enabled = false;
                trigger--;
            }
        }

        private Brush pen = new SolidBrush(Color.Red);

        
        private void Form1_Load(object sender, EventArgs e)
        {
            trigger = 1;
            Text = "Сердечко";

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            k = Convert.ToInt32(textBox3.Text);
            tick = timer_lock = k;
            hear_beat = k / 4;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(pen, x, y, k, k);
            g.FillEllipse(pen, x + (int)(k * 0.9), y, k, k);
            g.FillPolygon(pen, new Point[] { new Point(x + (int)(k * 0.04), y + (int)(k * 0.7)), new Point(x + (int)(k * 0.95), y + (int)(k * 1.7)), new Point(x + (int)((k + k * 0.9) - k * 0.04), y + (int)(k * 0.7)) });

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick < timer_lock + 20)
            {
                tick += 10;
            }
            else if (tick == timer_lock + 20)
            {
                k += hear_beat;
                x -= hear_beat;
                y -= hear_beat;
                tick += 10;
                Invalidate();
            }
            else if (tick == timer_lock + 30)
            {
                k -= hear_beat;
                x += hear_beat;
                y += hear_beat;
                tick += 10;
                Invalidate();
            }
            else if (tick == timer_lock + 40)
            {
                k += hear_beat;
                x -= hear_beat;
                y -= hear_beat;
                tick += 10;
                Invalidate();
            }
            else if (tick == timer_lock + 50)
            {
                k -= hear_beat;
                x += hear_beat;
                y += hear_beat;
                tick = timer_lock;
                Invalidate();
            }
        }
    }
}
