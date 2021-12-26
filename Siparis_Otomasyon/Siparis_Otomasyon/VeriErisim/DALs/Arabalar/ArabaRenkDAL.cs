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
    public class ArabaRenkDAL : DAL_Base<ArabaRenk>, IDAL<ArabaRenk>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaRenk enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aRenkleri.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaRenk enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                var renk = cnt.Entry(enti);
                renk.State = EntityState.Modified;
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Hepsini Getirme İşlemi
        public List<ArabaRenk> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aRenkleri.OrderBy(p => p.RenkAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aRenkleri.Where(p => p.RenkAD == AD).Select(p => p.RenkID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aRenkleri.Where(p => p.RenkAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaRenk enti)
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
