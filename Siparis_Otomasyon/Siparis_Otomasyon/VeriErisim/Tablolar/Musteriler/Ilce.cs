using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler
{
    [Table("Ilceler")]
    public class Ilce
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Ilce_ID { get; set; }
        public int Il_ID { get; set; }
        public string IlceAD { get; set; }
    }
}
