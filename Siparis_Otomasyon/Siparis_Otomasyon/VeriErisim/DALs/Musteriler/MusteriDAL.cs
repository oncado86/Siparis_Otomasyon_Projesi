using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.DALs;
using Siparis_Otomasyon.VeriErisim;
using System.Linq.Expressions;

namespace Siparis_Otomasyon.VeriErisim.DALs.Musteriler
{
    public class MusteriDAL : DAL_Base<Musteri>, IDAL<Musteri>, IDeGoreGetir<Musteri>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(Musteri enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.Musteriler.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(Musteri enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var musteri = context.Entry(enti);
                musteri.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Hepsini Getirme İşlemi
        public List<Musteri> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.Musteriler.OrderBy(p => p.AD).ToList();
            }
        }
        #endregion

        #region ------------------> Ada Göre Arama İşlemi
        List<Musteri> HG(Expression<Func<Musteri, bool>> filter = null)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return filter == null ? cnt.Set<Musteri>().ToList() : cnt.Set<Musteri>().Where(filter).OrderBy(p => p.AD).ToList();
            }
        }
        public List<Musteri> Ada_Gore_Ara(string markaAD)
        {
            return HG(p => p.AD.ToLower().Contains(markaAD.ToLower()));
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public Musteri IDyeGoreGetir(int ID)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Musteriler.Where(p => p.MusteriID == ID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Maile Getirme İşmlemi
        public Musteri Maile_Gore_getir(string eposta)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Musteriler.Where(p => p.Eposta == eposta).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string eposta)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.Musteriler.Where(p => p.Eposta == eposta).Any();
            }
        }
        #endregion

        #region ------------------> Şifre Doğrulama İşlemi
        public bool SifreDogruMu(string eposta, string sifre)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                Musteri msr = new Musteri();
                msr = IDyeGoreGetir(ID_Getir(eposta));
                return sifre == msr.Sifre ? true : false;
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(Musteri enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var musteri = context.Entry(enti);
                musteri.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string veriAD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Musteriler.Where(p => p.Eposta == veriAD).Select(p => p.MusteriID).FirstOrDefault();
            }
        }
        #endregion
    }
}
