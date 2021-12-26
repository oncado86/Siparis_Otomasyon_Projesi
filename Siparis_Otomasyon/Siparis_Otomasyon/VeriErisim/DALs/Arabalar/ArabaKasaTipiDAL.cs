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
    public class ArabaKasaTipiDAL : DAL_Base<ArabaKasaTipi>, IDAL<ArabaKasaTipi>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaKasaTipi enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aKasaTipleri.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaKasaTipi enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                var araba = cnt.Entry(enti);
                araba.State = EntityState.Modified;
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Hepsini Getirme İşlemi
        public List<ArabaKasaTipi> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aKasaTipleri.OrderBy(p => p.KasaTipAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aKasaTipleri.Where(p => p.KasaTipAD == AD).Select(p => p.KasaTipID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aKasaTipleri.Where(p => p.KasaTipAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaKasaTipi enti)
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
