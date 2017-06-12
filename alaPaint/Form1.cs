using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alaPaint
{
    public partial class Form1 : Form
    {

        Image Plik;
        string sciezka = "";
        Graphics g;
        Pen p = new Pen(Color.Black,1);
        Point pt = new Point();
        Point pt2 = new Point();
        

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }
        #region Kolory
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

        #endregion Kolory

        #region Rysowanie


        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            pt = e.Location;
            if (r1.Checked)
                p.Width = 1;
            else if (r2.Checked)
                p.Width = 2;
            else if (r3.Checked)
                p.Width = 3;
            else if (r4.Checked)
                p.Width = 4;
            else if (r5.Checked)
                p.Width = 5;
            else if (rg.Checked)
                p.Width = 30;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt2 = e.Location;
                g.DrawLine(p, pt, pt2);
                pt = pt2;
            }
        }

        #endregion Rysowanie

        #region Menu
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "plik graficzny(*.jpg)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                Plik = Image.FromFile(f.FileName);
                pictureBox1.Image = Plik;
            }
        }

        private void zapiszToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\Krystian\Desktop\test.jpg", ImageFormat.Jpeg);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion Menu

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void gumka_Click(object sender, EventArgs e)
        {
            p.Color = gumka.BackColor;
            wybrany.BackColor = gumka.BackColor;
            rg.Checked = true;
        }
    }
}
