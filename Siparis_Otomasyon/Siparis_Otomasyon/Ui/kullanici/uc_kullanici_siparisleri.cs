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
    public partial class uc_kullanici_siparisleri : UserControl
    {
        SiparisDAL siparisDAL = new SiparisDAL();
        public uc_kullanici_siparisleri()
        {
            InitializeComponent();
        }

        #region ------------------> Siparişleri Getir ve Göster
        public void HepsiniYukle()
        {
            var gelenListe = siparisDAL.Siparisleri_Goster(uc_giris._kullanici.MusteriID);
            List<Goster> filtreli = new List<Goster>();
            if (!string.IsNullOrEmpty(txt_.Text))
            {
                foreach (var item in gelenListe)
                {
                    if (item.Model.ToLower().Contains(txt_.Text.ToLower()))
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

            dgv_.Columns[1].Visible = false;
            dgv_.Columns[2].Visible = false;
        }
        #endregion

        #region ------------------> Form yüklenirken Siperişleri doldur
        private void uc_kullanici_siparisleri_Load(object sender, EventArgs e)
        {
            dgv_.DataSource = siparisDAL.Siparisleri_Goster(uc_giris._kullanici.MusteriID);
        }
        #endregion

        #region ------------------> Model Adına Adına Göre Dinamik Aranması
        private void txt__TextChanged(object sender, EventArgs e)
        {
            HepsiniYukle();
        }
        #endregion
    }
}
