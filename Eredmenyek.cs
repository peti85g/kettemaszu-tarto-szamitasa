using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikaiSzamitasok
{
    public class Eredmenyek:EventArgs 
    {
        private double nyomatek;
        private double nyiroero;
        public double Nyomatek { get { return nyomatek; } set { nyomatek = value; } }
        public double Nyiroero { get { return nyiroero; } set { nyiroero = value; } }
    }
}
