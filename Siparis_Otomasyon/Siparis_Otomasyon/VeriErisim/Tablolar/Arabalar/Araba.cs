using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;
using Siparis_Otomasyon.VeriErisim.Tablolar.Siparisler;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar
{
    [Table("Arabalar")]
    public class Araba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ArabaID { get; set; }
        public int UretimYili { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string VitesTipi { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
        public string YakitTipi { get; set; }
        public int KM { get; set; }
        public string KasaTipi { get; set; }
        public string Renk { get; set; }
        public string CekisTipi { get; set; }
        public string MotorHacmi { get; set; }
        public string MotorGucu { get; set; }
    }
}
