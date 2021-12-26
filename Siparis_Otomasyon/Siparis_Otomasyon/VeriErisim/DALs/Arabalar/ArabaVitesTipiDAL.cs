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
    public class ArabaVitesTipiDAL : DAL_Base<ArabaVitesTipi>, IDAL<ArabaVitesTipi>, ID_Getir
    {
        #region ------------------> Ekleme İşlemi
        public void Ekle(ArabaVitesTipi enti)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                cnt.aVitesTipleri.Add(enti);
                cnt.SaveChanges();
            }
        }
        #endregion

        #region ------------------> Güncelleme İşlemi
        public void Guncelle(ArabaVitesTipi enti)
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
        public List<ArabaVitesTipi> Hepsini_Getir()
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return context.aVitesTipleri.OrderBy(p => p.VitesTipAD).ToList();
            }
        }
        #endregion

        #region ------------------> ID Getirme İşlemi
        public int ID_Getir(string AD)
        {
            using (otomasyonContext cnt = new otomasyonContext())
            {
                return cnt.aVitesTipleri.Where(p => p.VitesTipAD == AD).Select(p => p.VitesTipID).FirstOrDefault();
            }
        }
        #endregion

        #region ------------------> Kayıt Varlık Kontrolü
        public bool Kayit_Yok_Mu(string kayitAD)
        {
            using (otomasyonContext context = new otomasyonContext())
            {
                return !context.aVitesTipleri.Where(p => p.VitesTipAD == kayitAD).Any();
            }
        }
        #endregion

        #region ------------------> Silme İşlemi
        public void Sil(ArabaVitesTipi enti)
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
