using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Siparis_Otomasyon.VeriErisim.DALs
{
    public class DAL_Base<T> where T : class, new()
    {
        public Boolean Bos_Mu(string data)
        {
            return (!String.IsNullOrEmpty(data)) ? true : false;
        }
    }
}
