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
    public class ArabaModelDAL : DAL_Base<ArabaModel>, IDAL<ArabaModel>,ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaModel enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aModeller.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaModel enti)
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
        public List<ArabaModel> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aModeller.OrderBy(p => p.ModelAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aModeller.Where(p => p.ModelAD == AD).Select(p => p.ModelID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aModeller.Where(p => p.ModelAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Markaya Göre Getirme İşlemi
        public List<ArabaModel> MarkayaGoreGetir(int markaID)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aModeller.Where(p => p.MarkaID == markaID).ToList();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaModel enti)
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
