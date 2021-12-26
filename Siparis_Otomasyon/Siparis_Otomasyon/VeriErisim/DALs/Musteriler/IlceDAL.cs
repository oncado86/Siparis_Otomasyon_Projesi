using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim;
using Siparis_Otomasyon.VeriErisim.DALs;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;

namespace Siparis_Otomasyon.VeriErisim.DALs.Musteriler
{
    public class IlceDAL : DAL_Base<Ilce>
    {

        #region ------------------> Hepsini Getir
        public List<Ilce> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.Ilceler.OrderBy(p => p.IlceAD).ToList();
            }
        }
        #endregion

        #region ------------------>  İl bilgisine göre getirme
        public List<Ilce> IleGoreGetir(int ilID)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Ilceler.Where(p => p.Il_ID == ilID).ToList();
            }
        }
        #endregion
    }
}
