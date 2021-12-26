using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;
using Siparis_Otomasyon.VeriErisim.Tablolar.Siparisler;


namespace Siparis_Otomasyon.VeriErisim
{
    public class otomasyonContext : DbContext
    {
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<ArabaCekisTipi> aCekisTipleri { get; set; }
        public DbSet<ArabaRenk> aRenkleri { get; set; }
        public DbSet<ArabaKasaTipi> aKasaTipleri { get; set; }
        public DbSet<ArabaVitesTipi> aVitesTipleri { get; set; }
        public DbSet<ArabaYakitTipi> aYakitTipleri { get; set; }
        public DbSet<ArabaMarka> aMarkalar { get; set; }
        public DbSet<ArabaModel> aModeller { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
    }
}
