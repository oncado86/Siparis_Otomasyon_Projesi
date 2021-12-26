using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Siparis_Otomasyon.VeriErisim.Tablolar.Siparisler
{
    [Table("Siparisler")]
    public class Siparis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SiparisID { get; set; }
        public int MusteriID { get; set; }
        public int ArabaID { get; set; }
        public string OdemeTuru { get; set; }
        public int Taksit { get; set; }
        public int AracFiyat { get; set; }
        public double ToplamFiyat { get; set; }
    }
}
