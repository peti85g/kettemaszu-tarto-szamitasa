using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzilardsagTaniSzamitasok
{
    public partial class NyiroNormalFeszultseg : UserControl
    {
        public double T;
        public double M;
       
        public NyiroNormalFeszultseg()
        {
            InitializeComponent();
        }
        private void Kiiro(double a,double b)
        {
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
        }

        private void Selet(object sender, EventArgs e)
        {
            string tartoFajta = checkedListBox1.SelectedItem.ToString();
            if (tartoFajta=="I tarto")
            {
                ITarto i = new ITarto { M1 = M, T1 = T };
                i.Show();
            }
            else if (tartoFajta=="Cső")
            {
                HTarto h = new HTarto { M1 = M, T1 = T };
                h.Show();
            }
            else
            {
                ZartSzelveny z = new ZartSzelveny { M1 = M, T1 = T };
                z.Show();
            }
        }

        private void NyiroNormalFeszultseg_Load(object sender, EventArgs e)
        {
            
        }

        private void Frissites(object sender, EventArgs e)
        {
            Kiiro(M,T);
        }

        private void accidentalClick(object sender, EventArgs e)
        {
            MessageBox.Show("Ez nem input mezo, az a masik user controlleren van!");
        }
    }
}
