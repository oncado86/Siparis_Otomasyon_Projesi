using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siparis_Otomasyon.VeriErisim.DALs.Siparisler;
using static Siparis_Otomasyon.VeriErisim.DALs.Siparisler.SiparisDAL;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_admin_siparisler : UserControl
    {
        SiparisDAL siparisDAL = new SiparisDAL();

        public uc_admin_siparisler()
        {
            InitializeComponent();
        }

        #region ------------------> Siparişlerin Gösterilmesi
        public void HepsiniYukle()
        {
            var gelenListe = siparisDAL.Siparisleri_Goster();
            List<Goster> filtreli = new List<Goster>();
            if (!string.IsNullOrEmpty(txt_.Text))
            {
                foreach (var item in gelenListe)
                {
                    if (item.Ad.ToLower().Contains(txt_.Text.ToLower()))
                    {
                        filtreli.Add(new Goster
                        {
                            ID = item.ID,
                            Ad = item.Ad,
                            Soyad = item.Soyad,
                            Marka = item.Marka,
                            Model = item.Model,
                            OdemeTuru = item.OdemeTuru,
                            Taksit = item.Taksit,
                            AracFiyat = item.AracFiyat,
                            ToplamFiyat = item.ToplamFiyat
                        });
                    }
                }
                dgv_.DataSource = filtreli;
            }
            else
            {
                dgv_.DataSource = gelenListe;
            }

            dgv_.Columns[0].HeaderText = "Sipariş kodu";
            dgv_.Columns[1].HeaderText = "Müşteri Adı";
            dgv_.Columns[2].HeaderText = "Müşteri Soyadı";
            dgv_.Columns[3].HeaderText = "Araba Markası";
            dgv_.Columns[4].HeaderText = "Araba Modeli";
            dgv_.Columns[5].HeaderText = "Ödeme Türü";
            dgv_.Columns[6].HeaderText = "Taksit Adedi";
            dgv_.Columns[7].HeaderText = "Araba Fiyatı";
            dgv_.Columns[8].HeaderText = "Toplam Ücret";
        }
        #endregion

        #region ------------------> From Yüklenirken Sipariş Bilgilerinin Yüklenmesi
        private void uc_admin_siparisler_Load(object sender, EventArgs e)
        {
            dgv_.DataSource = siparisDAL.Siparisleri_Goster();
        }
        #endregion

        #region ------------------> Müşterilerin Adına Adına Göre Dinamik Aranması
        private void txt__TextChanged(object sender, EventArgs e)
        {
            HepsiniYukle();
        }
        #endregion
    }
}
