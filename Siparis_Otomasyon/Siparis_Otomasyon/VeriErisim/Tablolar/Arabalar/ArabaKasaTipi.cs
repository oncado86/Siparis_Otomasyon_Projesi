using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar
{
    [Table("aKasaTipleri")]
    public class ArabaKasaTipi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int KasaTipID { get; set; }

        public string KasaTipAD { get; set; }
    }
}
