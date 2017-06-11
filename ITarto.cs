using StatikaiSzamitasok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzilardsagTaniSzamitasok
{
    public partial class ITarto : Form
    {
        public ITarto()
        {
            InitializeComponent();
        }
        public double M1;
        public double T1;

        private void SzilSzamito_Load(object sender, EventArgs e)
        {

        }

        private void textBox1Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBod9Click(object sender, EventArgs e)
        {
            textBox9.Text = string.Empty;
        }

        private void textBox8Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Empty;
        }

        private void textBox7Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Empty;
        }
        double a, b, c, d,Ix,Tau,Sigma;
        private void TauSigmaInertia()
        {
            double.TryParse(textBox1.Text, out a);
            double.TryParse(textBox9.Text, out b);
            double.TryParse(textBox8.Text, out c);
            double.TryParse(textBox7.Text, out d);
            if (a==0||b==0||c==0||d==0)
            {
                MessageBox.Show("Invalid input");
            }
            if (d>b/2)
            {
                MessageBox.Show("d<b/2 !");
            }
            if (c>a/2)
            {
                MessageBox.Show("c<a/2 !");
            }
            Ix = ((a * a * a * b) - ((b - d) * (b - d) * (b - d) * (a - c - c))) / 12;
            textBox4.Text = "Ix = " + Ix.ToString() + "mm4";

            Tau = T1 / ((a * b) - (a - c - c) * (b - d));
            textBox5.Text = Tau.ToString();

            Sigma = (M1*a)/(Ix*2);
            textBox6.Text = Sigma.ToString();
        }

        private void CountClick(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            TauSigmaInertia();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search s=new Search();

            s.Show();
        }

        private void AccidentalClick(object sender, EventArgs e)
        {
            MessageBox.Show("Ez eredmeny mezo. Erteket csak az a, b, c es d mezokon lehet megadni.");
        }
    }
}
