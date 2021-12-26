using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siparis_Otomasyon.VeriErisim.DALs.Musteriler;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_admin_musteri_arama : UserControl
    {
        MusteriDAL musteriDAL = new MusteriDAL();
        public uc_admin_musteri_arama()
        {
            InitializeComponent();
        }

        #region ------------------> Müşteri Bilgilerinin Alınıp Gösterilmesi
        public void HepsiniYukle()
        {
            dgv_.DataSource = musteriDAL.Hepsini_Getir();
            dgv_.Columns[0].Visible = false;
            dgv_.Columns[4].Visible = false;
            dgv_.Columns[9].Visible = false;
            dgv_.Columns[1].HeaderText = "Müşteri Adı";
            dgv_.Columns[2].HeaderText = "Müşteri Soyadı";
            dgv_.Columns[3].HeaderText = "Müşteri Eposta";
            dgv_.Columns[5].HeaderText = "Telefon";
            dgv_.Columns[6].HeaderText = "İl";
            dgv_.Columns[7].HeaderText = "İlçe";
            dgv_.Columns[8].HeaderText = "Adres";
        }
        #endregion

        #region ------------------> Form Yüklenirken Müşteri Bilgilerinin Yüklenmesi
        private void uc_admin_musteri_arama_Load(object sender, EventArgs e)
        {
            HepsiniYukle();
        }
        #endregion

        #region ------------------> Müşterilerin Adına Adına Göre Dinamik Aranması
        private void txt__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_.Text))
            {
                dgv_.DataSource = musteriDAL.Ada_Gore_Ara(txt_.Text);
            }
            else { HepsiniYukle(); }
        }
        #endregion
    }
}
