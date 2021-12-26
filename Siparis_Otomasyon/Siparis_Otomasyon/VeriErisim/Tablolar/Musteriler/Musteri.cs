using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler

{
    [Table("Musteriler")]
    public class Musteri
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int MusteriID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public string IlAd { get; set; }
        public string IlceAD { get; set; }
        public string Adres { get; set; }
        public string Rol { get; set; }
    }
}
