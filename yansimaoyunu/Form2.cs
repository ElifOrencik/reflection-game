using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yansimaoyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int asagi = 15;
        int yukari = 15;
        int can = 3;
        int puan = 0;
        private void carpmadurumundayon()
        {
            if (ball.Top <= label3.Bottom)
            {
                yukari = yukari * -1;
            }
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
            {
                yukari = yukari * -1;
            }

            else if (ball.Right >= label2.Left)
            {
                asagi = asagi * -1;
            }
            else if (ball.Left <= label1.Right)
            {
                asagi = asagi * -1;
            }
        }
        private void bas()
        {
            ball.Location = new Point(152, 314);
            timer1.Start();
            puan = 0;
        }

        private void yanma()
        {
            if (ball.Top >= kontrol.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    if (can == 2)
                    { button10.Visible = false; }
                    if (can == 1)
                    { button10.Visible = false; button4.Visible = false; }
                    else if (can == 0)
                    { button4.Visible = false; button10.Visible = false; button5.Visible = false; }
                    MessageBox.Show("Yandınız kalan can >=" + can.ToString());
                    bas();
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun bitti");
                }
            }
        }
        private void puanlama()
        {
            if (ball.Bounds.IntersectsWith(button7.Bounds))
            {
                button7.Visible = false;
                button13.Visible = true;
            }
            if (ball.Bounds.IntersectsWith(button2.Bounds))
            {
                button2.Visible = false; button16.Visible = true;
            }
            if (ball.Bounds.IntersectsWith(button9.Bounds))
            {
                button9.Visible = false; button15.Visible = true;
            }
            if (ball.Bounds.IntersectsWith(button3.Bounds))
            {
                button3.Visible = false; button11.Visible = true;
            }
            if (ball.Bounds.IntersectsWith(button8.Bounds))
            {
                button8.Visible = false; button14.Visible = true;
            }
            if (ball.Bounds.IntersectsWith(button6.Bounds))
            {
                button6.Visible = false; button12.Visible = true;
            }

            if (button7.Visible == false && button2.Visible == false && button9.Visible == false && button3.Visible == false && button8.Visible == false && button6.Visible == false)
            {
                timer1.Stop();
                MessageBox.Show("OYUNU KAZANDINIZ");
                Form3 form = new Form3();
                form.Show();
                this.Hide();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            carpmadurumundayon();
            yanma();
            puanlama();
            ball.Location = new Point(ball.Location.X + asagi, ball.Location.Y + yukari);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            ball.BackColor = Color.DarkGreen;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            ball.BackColor = Color.Yellow;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            ball.BackColor = Color.Black;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            ball.BackColor = Color.Blue;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
