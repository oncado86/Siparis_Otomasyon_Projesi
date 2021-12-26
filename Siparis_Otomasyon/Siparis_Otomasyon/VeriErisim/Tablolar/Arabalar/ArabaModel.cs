using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar
{
    [Table("aModeller")]
    public class ArabaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ModelID { get; set; }
        public int MarkaID { get; set; }
        public string ModelAD { get; set; }
    }
}
