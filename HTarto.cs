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
    public partial class HTarto : Form
    {
        public HTarto()
        {
            InitializeComponent();
        }
        public double M1;
        public double T1;

        private void Szamito()
        {
            double nagy;
            double.TryParse(textBox1.Text, out nagy);
            double kicsi;
            double.TryParse(textBox2.Text, out kicsi);
            if (nagy==0||kicsi==0)
            {
                MessageBox.Show("Invalid input!");
            }
            if (kicsi>nagy)
            {
                MessageBox.Show("A külsőatmero > belsoatmero");
            }
            double I = 3.14 * (nagy * nagy * nagy * nagy - kicsi * kicsi * kicsi * kicsi) / 4;
            textBox3.Text = I.ToString() + "mm4";

            double Tau = T1 / (nagy * 3.14 - kicsi * 3.14);
            textBox4.Text = Tau.ToString() + "kN/mm2";

            double Sigma = M1 * nagy / I * 2;
            textBox5.Text = Sigma.ToString() + "kN/mm2";


        }

        private void AccidentalClick(object sender, EventArgs e)
        {
            MessageBox.Show("Ez eredmeny mezo, eretket csak a nagy illetve kisatlo nevu mezokon lehet.");
        }

        private void Count(object sender, EventArgs e)
        {
            Szamito();
        }

        private void Browse(object sender, EventArgs e)
        {
            Search z = new Search();
            z.Show();
        }
    }
}
