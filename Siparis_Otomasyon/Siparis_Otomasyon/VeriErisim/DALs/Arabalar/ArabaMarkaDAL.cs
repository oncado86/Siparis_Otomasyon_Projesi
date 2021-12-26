using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using System.Data.Entity;

namespace Siparis_Otomasyon.VeriErisim.DALs.Arabalar
{
    public class ArabaMarkaDAL : DAL_Base<ArabaMarka>, IDAL<ArabaMarka>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaMarka enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aMarkalar.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaMarka enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var araba = context.Entry(enti);
                araba.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Hepsini Getirme İşlemi
        public List<ArabaMarka> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aMarkalar.OrderBy(p => p.MarkaAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aMarkalar.Where(p => p.MarkaAD == AD).Select(p => p.MarkaID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aMarkalar.Where(p => p.MarkaAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaMarka enti)
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
