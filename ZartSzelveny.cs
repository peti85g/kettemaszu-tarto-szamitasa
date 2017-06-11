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
    public partial class ZartSzelveny : Form
    {
        public ZartSzelveny()
        {
            InitializeComponent();
        }
        public double T1;
        public double M1;

        private void Szamito()
        {
            double a;
            double.TryParse(textBox1.Text, out a);
            double b;
            double.TryParse(textBox6.Text, out b);
            double c;
            double.TryParse(textBox5.Text, out c);
            if (a==0||b==0||c==0)
            {
                MessageBox.Show("Invalid Input.");
            }
            if (c>a/2)
            {
                MessageBox.Show("c<a/2 !");
            }
            if (c>b/2)
            {
                MessageBox.Show("b<a/2 !");
            }
            double Ix = (a * a * a * b - (a - c - c) * (a - c - c) * (a - c - c)) / 12;
            textBox4.Text=Ix.ToString()+"mm4";

            double Tau = T1 / ((a * b) - (a - c - c) * (b - c - c));
            textBox3.Text = Tau.ToString()+"kN/mm2";

            double Sigma = M1 * b / Ix * 2;
            textBox2.Text = Sigma.ToString()+"kN/mm2";
        }

        private void Accidental(object sender, EventArgs e)
        {
            MessageBox.Show("Ez eredmeny mezo! Input megadasa az a,b es c jelu mezokon lehetseges.");
        }

        private void Count(object sender, EventArgs e)
        {
            Szamito();
        }

        private void Browse(object sender, EventArgs e)
        {
            Search t = new Search();
            t.Show();
        }
    }
}
