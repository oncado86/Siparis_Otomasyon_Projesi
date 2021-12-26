using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;

namespace Siparis_Otomasyon.VeriErisim.DALs.Arabalar
{
    public class ArabaCekisTipDAL : DAL_Base<ArabaCekisTipi>, IDAL<ArabaCekisTipi>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaCekisTipi enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aCekisTipleri.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaCekisTipi enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var araba = context.Entry(enti);
                araba.State = EntityState.Modified;
            }
        }
        #endregion

        #region ------------------> Hepsini Getirme
        public List<ArabaCekisTipi> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aCekisTipleri.OrderBy(p => p.CekisTipAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID getirme
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aCekisTipleri.Where(p => p.CekisTipAD == AD).Select(p => p.CekisTipID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt varlığının kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aCekisTipleri.Where(p => p.CekisTipAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaCekisTipi enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var araba = context.Entry(enti);
                araba.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
