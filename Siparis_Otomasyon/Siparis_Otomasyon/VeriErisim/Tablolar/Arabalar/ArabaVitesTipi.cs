using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar
{
    [Table("aVitesTipleri")]
    public class ArabaVitesTipi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int VitesTipID { get; set; }
        public string VitesTipAD { get; set; }
    }
}
