using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alaPaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black,1);
        Point pt = new Point(0, 0);
        Point pt2 = new Point(0, 0);
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void czerwony_Click(object sender, EventArgs e)
        {
            p.Color = czerwony.BackColor;
            wybrany.BackColor = czerwony.BackColor;

        }

        private void niebieski_Click(object sender, EventArgs e)
        {
            p.Color = niebieski.BackColor;
            wybrany.BackColor = niebieski.BackColor;
        }

        private void zielony_Click(object sender, EventArgs e)
        {
            p.Color = zielony.BackColor;
            wybrany.BackColor = zielony.BackColor;
        }

        private void zolty_Click(object sender, EventArgs e)
        {
            p.Color = zielony.BackColor;
            wybrany.BackColor = zielony.BackColor;
        }

        private void rozowy_Click(object sender, EventArgs e)
        {
            p.Color = rozowy.BackColor;
            wybrany.BackColor = rozowy.BackColor;
        }

        private void brozowy_Click(object sender, EventArgs e)
        {
            p.Color = brozowy.BackColor;
            wybrany.BackColor = brozowy.BackColor;
        }

        private void pomaranczowy_Click(object sender, EventArgs e)
        {
            p.Color = pomaranczowy.BackColor;
            wybrany.BackColor = pomaranczowy.BackColor;
        }

        private void fioletowy_Click(object sender, EventArgs e)
        {
            p.Color = fioletowy.BackColor;
            wybrany.BackColor = fioletowy.BackColor;
        }

        private void bialy_Click(object sender, EventArgs e)
        {
            p.Color = bialy.BackColor;
            wybrany.BackColor = bialy.BackColor;
        }

        private void czarny_Click(object sender, EventArgs e)
        {
            p.Color = czarny.BackColor;
            wybrany.BackColor = czarny.BackColor;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pt = e.Location;
            if (e.Button == MouseButtons.Left)
                i = 1;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            i = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (i == 1)
            {
                pt2 = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, pt, pt2);
            }

            pt = pt2;
        }
    }
}
