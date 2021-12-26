using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon.VeriErisim.Interface
{
    interface IDeGoreGetir<T> where T : class, new()
    {
        T IDyeGoreGetir(int ID);
    }
}
