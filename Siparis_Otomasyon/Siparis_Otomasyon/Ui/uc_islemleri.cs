using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Controls.Panel;
using UserControl = System.Windows.Forms.UserControl;

namespace Siparis_Otomasyon.Ui
{
    public class uc_islemleri
    {
        public void panel_kontrol_ekle(System.Windows.Forms.Panel pnl, UserControl usrcnt)
        {
            usrcnt.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            pnl.Controls.Add(usrcnt);
            usrcnt.BringToFront();
        }
    }
}
