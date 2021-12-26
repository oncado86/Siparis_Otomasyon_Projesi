using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;

namespace Siparis_Otomasyon.VeriErisim.DALs.Musteriler
{
    public class IlDAL : DAL_Base<Il>
    {
        #region ------------------> Hepsini Getir
        public List<Il> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.Iller.OrderBy(p => p.Il_ID).ToList();
            }
        }
        #endregion
    }
}
