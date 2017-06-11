using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatikaiSzamitasok
{
    public partial class TamaszeroSzamito : UserControl
    {
        public TamaszeroSzamito()
        {
            InitializeComponent();
        }
        private void LClick(object sender, EventArgs e)
        {
            double result;
            double.TryParse(textBox1.Text, out  result);
            if (result!=0)
            {
                DialogResult valasztas = MessageBox.Show("Biztos megvaltoztatod ezt az erteket?","Tarto meret valtoztatas", MessageBoxButtons.OKCancel);
                if (valasztas==DialogResult.OK)
                {
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                textBox1.Text = string.Empty;
            }
        }
        double F1, fL1, A, B;
        public double M, T;
        private void TamaszEroSzamito()
        {
            double L2;
            double.TryParse(textBox1.Text,out L2);
            double aL2;
            double.TryParse(textBox5.Text,out aL2);
            double bL2;
            double.TryParse(textBox4.Text,out bL2);
            double F2;
            double.TryParse(textBox3.Text,out F2);
            double fL2;
            double.TryParse(textBox2.Text,out fL2);
            double x = F1 + F2;
            double y = (F1 * fL1 + F2 * fL2) / (F1 + F2);
            F1 = x;
            fL1 = y;
            A = (fL1 - bL2) * F1 / (aL2 - bL2);
            B = (F1-A);
            textBox6.Text = "A = " + A.ToString() + "kN";
            textBox7.Text = "B = " + B.ToString() + "kN";
            M = A * (aL2-fL1);
            if (A > B)
                T = A;
            else
                T = B;
            textBox8.Text = "T = " + T.ToString() + "kN";
            textBox10.Text = "M = " + M.ToString() + "kNm";
            
        }

        private void alClick(object sender, EventArgs e)
        {
            double result;
            double.TryParse(textBox5.Text, out  result);
            if (result != 0)
            {
                DialogResult valasztas = MessageBox.Show("Biztos megvaltoztatod ezt az erteket?", "Tarto meret valtoztatas", MessageBoxButtons.OKCancel);
                if (valasztas == DialogResult.OK)
                {
                    textBox5.Text = string.Empty;
                }
            }
            else
            textBox5.Text = string.Empty;
        }

        private void bLClick(object sender, EventArgs e)
        {
            double result;
            double.TryParse(textBox4.Text, out  result);
            if (result != 0)
            {
                DialogResult valasztas = MessageBox.Show("Biztos megvaltoztatod ezt az erteket?", "Tarto meret valtoztatas", MessageBoxButtons.OKCancel);
                if (valasztas == DialogResult.OK)
                {
                    textBox4.Text = string.Empty;
                }
            }
            else
            textBox4.Text = string.Empty;
        }

        private void FClick(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }

        private void lFClick(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
        public delegate void TamaszeroSzamitoHandler(object myObject, Eredmenyek myArgs);
        public event TamaszeroSzamitoHandler Szamitaskor;

 
        public void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            label8.Text = "A most felallitott erorendszer tovabbi erokkel bovitheto!";
            TamaszEroSzamito();
            if (M != 0 && T != 0)
            {
                Szamitaskor(this, new Eredmenyek { Nyiroero = T, Nyomatek = M });
                return;
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fL1 = 0;
            F1 = 0;
            A = 0;
            B = 0;
            textBox1.Text = "L";
            textBox5.Text = "aL";
            textBox4.Text = "bL";
            textBox3.Text = "F";
            textBox2.Text = "fL";
            textBox6.Text = "Tamaszero A";
            textBox7.Text = "Tamaszero B";
            textBox8.Text = "T";
            textBox10.Text = "M";
            label8.Text = string.Empty;
        }

        private void accidentalClick(object sender, EventArgs e)
        {
            MessageBox.Show("A program nem fogad itt inputot, csak az L, aL, bL, F és fL mezokben!");
        }

        private void EnabeCount(object sender, EventArgs e)
        {
            double L2;
            double.TryParse(textBox1.Text, out L2);
            double aL2;
            double.TryParse(textBox5.Text, out aL2);
            double bL2;
            double.TryParse(textBox4.Text, out bL2);
            double F2;
            double.TryParse(textBox3.Text, out F2);
            double fL2;
            double.TryParse(textBox2.Text, out fL2);
            if (L2 != 0 && aL2 != 0 && bL2 != 0 && F2 != 0 && fL2 != 0)
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
        
    }
}
