using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis_Otomasyon.VeriErisim.Interface;
using System.Data.Entity;
using Siparis_Otomasyon.VeriErisim.Tablolar.Siparisler;
using System.Linq.Expressions;
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using Siparis_Otomasyon.VeriErisim.DALs.Arabalar;
using Siparis_Otomasyon.VeriErisim.DALs.Musteriler;

namespace Siparis_Otomasyon.VeriErisim.DALs.Siparisler
{
    public class SiparisDAL : DAL_Base<Siparis>, IDAL<Siparis>, IDeGoreGetir<Siparis>
    {
        #region ------------------> Siparişleri Formatlarken Kullanılacak Class
        public class Goster
        {
            public int ID { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string OdemeTuru { get; set; }
            public string Taksit { get; set; }
            public string AracFiyat { get; set; }
            public string ToplamFiyat { get; set; }
        }
        #endregion

        #region ------------------> Ekleme İşlemi
        public void Ekle(Siparis enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.Siparisler.Add(enti);
                cnt.SaveChanges();
            }
        }

        public void Guncelle(Siparis enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var siparis = context.Entry(enti);
                siparis.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Tüm Siparişlerin Getirilmesi
        public List<Siparis> Hepsini_Getir()

        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.Siparisler.OrderBy(p => p.MusteriID).ToList();
            }
        }
        #endregion

        #region ------------------> ID'ye Göre Getirilmesi
        public Siparis IDyeGoreGetir(int ID)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.Siparisler.Where(p => p.MusteriID == ID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Silme İŞlemi
        public void Sil(Siparis enti)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                var siparis = context.Entry(enti);
                siparis.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Tüm Sipiarişlerin Admin'e Gösterilmesi
        public List<Goster> Siparisleri_Goster()
        {
            List<Goster> siparis_listeri = new List<Goster>();

            ArabaDAL adl = new ArabaDAL();
            MusteriDAL mdl = new MusteriDAL();
            foreach (var siparis in Hepsini_Getir())
            {
                siparis_listeri.Add(new Goster
                {
                    ID = siparis.SiparisID,
                    Ad = mdl.IDyeGoreGetir(siparis.MusteriID).AD,
                    Soyad = mdl.IDyeGoreGetir(siparis.MusteriID).Soyad,
                    Marka = adl.IDyeGoreGetir(siparis.ArabaID).Marka,
                    Model = adl.IDyeGoreGetir(siparis.ArabaID).Model,
                    OdemeTuru = siparis.OdemeTuru,
                    Taksit = siparis.Taksit.ToString(),
                    AracFiyat = siparis.AracFiyat.ToString(),
                    ToplamFiyat = siparis.ToplamFiyat.ToString()
                });
            }
            return siparis_listeri;
        }
        #endregion

        #region ------------------> Müşteriye Siparişlerin Gösterilmesi
        public List<Goster> Siparisleri_Goster(int id)
        {
            List<Goster> siparis_listeri = new List<Goster>();

            ArabaDAL adl = new ArabaDAL();
            MusteriDAL mdl = new MusteriDAL();
            foreach (var siparis in Hepsini_Getir())
            {
                if (siparis.MusteriID == id)
                {
                    siparis_listeri.Add(new Goster
                    {
                        ID = siparis.SiparisID,
                        Ad = mdl.IDyeGoreGetir(siparis.MusteriID).AD,
                        Soyad = mdl.IDyeGoreGetir(siparis.MusteriID).Soyad,
                        Marka = adl.IDyeGoreGetir(siparis.ArabaID).Marka,
                        Model = adl.IDyeGoreGetir(siparis.ArabaID).Model,
                        OdemeTuru = siparis.OdemeTuru,
                        Taksit = siparis.Taksit.ToString(),
                        AracFiyat = siparis.AracFiyat.ToString(),
                        ToplamFiyat = siparis.ToplamFiyat.ToString()
                    });
                }
            }
            return siparis_listeri;
        }
        #endregion

        #region ------------------> ...
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
