using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon.Odemeler
{
    public class TaksitleOdeme : Odeme
    {
        public int TaksitSayisi { get; set; }
        public override double OdemeYap(double tutar)
        {
            return OdemeMiktari = tutar + (tutar * 0.1) * TaksitSayisi;
        }
    }
}
