using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon.VeriErisim.Interface
{
    public interface IDAL<T> where T : class, new()
    {
        List<T> Hepsini_Getir();
        void Ekle(T enti);
        void Guncelle(T enti);
        void Sil(T enti);
        bool Kayit_Yok_Mu(string kayitAD);
    }
}
