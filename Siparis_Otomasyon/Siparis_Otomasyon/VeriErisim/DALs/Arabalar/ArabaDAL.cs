using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using System.Data.Entity;

namespace Siparis_Otomasyon.VeriErisim.DALs.Arabalar
{
    public class ArabaDAL : DAL_Base<Araba>, IDAL<Araba>, IDeGoreGetir<Araba>
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(Araba enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.Arabalar.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(Araba enti)
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
        public List<Araba> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.Arabalar.OrderBy(p => p.Model).ToList();
            }
        }
        #endregion

        #region ------------------> ID Bilgisine Göre Getirme
        public Araba IDyeGoreGetir(int arabaID)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Arabalar.Where(p => p.ArabaID == arabaID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Markaya Göre Arama
        List<Araba> HG(Expression<Func<Araba, bool>> filter = null)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return filter == null ? cnt.Set<Araba>().ToList() : cnt.Set<Araba>().Where(filter).OrderBy(p=>p.Model).ToList();
            }
        }
        public List<Araba> Markaya_Gore_Ara(string markaAD)
        {
            return HG(p => p.Model.ToLower().Contains(markaAD.ToLower()));
        }
        #endregion

        #region ------------------> Kayıt varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.Arabalar.Where(p => p.Model == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(Araba enti)
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
