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
using SzilardsagTaniSzamitasok;

namespace petig.KettamaszuMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tamaszeroSzamito1.Szamitaskor+= TamaszeroKezelo;
        }
        public void TamaszeroKezelo(object sender, Eredmenyek e)
        {
            nyiroNormalFeszultseg2.T = e.Nyiroero;
            nyiroNormalFeszultseg2.M = e.Nyomatek;
        }
    }
}
