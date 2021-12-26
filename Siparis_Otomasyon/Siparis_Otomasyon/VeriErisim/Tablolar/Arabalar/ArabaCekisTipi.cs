using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar
{
    [Table("aCekisTipleri")]
    public class ArabaCekisTipi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CekisTipID { get; set; }
        public string CekisTipAD { get; set; }
    }
}
