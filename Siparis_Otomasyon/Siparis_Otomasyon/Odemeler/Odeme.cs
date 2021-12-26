using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon.Odemeler
{
    public abstract class Odeme
    {
        public double OdemeMiktari { get; set; }
        public abstract double OdemeYap(double tutar);
    }
}
