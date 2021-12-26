using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siparis_Otomasyon.Odemeler;
using Siparis_Otomasyon.VeriErisim.DALs.Arabalar;
using Siparis_Otomasyon.VeriErisim.DALs.Siparisler;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using Siparis_Otomasyon.VeriErisim.Tablolar.Siparisler;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_kullanici_siparis_ekrani : UserControl
    {
        #region ------------------> Global Tanımlamalar
        TaksitleOdeme taksitle = new TaksitleOdeme
        {
            TaksitSayisi = Convert.ToInt32(2)
        };
        KapidaOdeme kapida = new KapidaOdeme();
        NakitOdeme nakit = new NakitOdeme();
        ArabaDAL arabaDAL = new ArabaDAL();
        Araba araba = new Araba();
        SiparisDAL siparis = new SiparisDAL();
        double ek_masraf, toplam_ucret;
        string odemeturu;
        #endregion

        public uc_kullanici_siparis_ekrani()
        {
            InitializeComponent();
        }

        #region ------------------> Araba Bilgisi Alma işlemi
        public void ArabaBilgisiAl(Araba arb)
        {
            araba = arb;
            lbl_ekmasraf.Visible = false;
            lbl_ekmasraf_miktari.Visible = false;
            cb_taksit.Visible = false;
            lbl_taksit.Visible = false;

            lbl_ekmasraf_miktari.Text = $"{ek_masraf} ₺";
            lbl_toplam_ucret_miktari.Text = $"{nakit.OdemeYap(araba.Fiyat)} ₺";
            lbl_bilgi.Text = $"{araba.Marka} - {araba.Model} ({araba.Fiyat} ₺)  için bir ödeme türü seçiniz.";
        }
        #endregion

        #region ------------------> Taksit Sayıs Değişimi
        private void cb_taksit_SelectedIndexChanged(object sender, EventArgs e)
        {
            taksitle.TaksitSayisi = Convert.ToInt32(cb_taksit.Text);
            TakistleOde();
        }
        #endregion

        #region ------------------> Taksitle Ödeme İşlemi
        void TakistleOde()
        {
            lbl_taksit.Visible = true;
            lbl_ekmasraf.Visible = true;
            lbl_ekmasraf_miktari.Visible = true;
            cb_taksit.Visible = true;
            toplam_ucret = taksitle.OdemeYap(araba.Fiyat);
            ek_masraf = toplam_ucret - araba.Fiyat;
            lbl_ekmasraf_miktari.Text = $"{ek_masraf} ₺";
            lbl_toplam_ucret_miktari.Text = $"{toplam_ucret} ₺";
        }
        #endregion

        #region ------------------> Kapıda Ödeme Seçeneği
        private void btn_kapida_Click(object sender, EventArgs e)
        {
            taksitle.TaksitSayisi = 1;
            toplam_ucret = kapida.OdemeYap(araba.Fiyat);
            ek_masraf = toplam_ucret - araba.Fiyat;
            lbl_ekmasraf_miktari.Text = $"{ek_masraf} ₺";
            lbl_toplam_ucret_miktari.Text = $"{toplam_ucret} ₺";
            odemeturu = "Kapıda Ödeme";

            lbl_taksit.Visible = false;
            cb_taksit.Visible = false;
            lbl_ekmasraf.Visible = true;
            lbl_ekmasraf_miktari.Visible = true;
            OdemeGoster();
        }
        #endregion

        #region ------------------> Nakit Ödeme Seçeneği
        private void btn_nakit_Click(object sender, EventArgs e)
        {
            taksitle.TaksitSayisi = 1;
            lbl_ekmasraf_miktari.Text = $"{ek_masraf} ₺";
            toplam_ucret = nakit.OdemeYap(araba.Fiyat);
            lbl_toplam_ucret_miktari.Text = $"{nakit.OdemeYap(araba.Fiyat)} ₺";
            odemeturu = "Nakit Ödeme";

            lbl_taksit.Visible = false;
            cb_taksit.Visible = false;
            lbl_ekmasraf.Visible = false;
            lbl_ekmasraf_miktari.Visible = false;
            OdemeGoster();
        }
        #endregion

        #region ------------------> Taksitle Ödeme Seçeneği
        private void btn_taksitle_Click(object sender, EventArgs e)
        {
            cb_taksit.Text = 2.ToString();
            TakistleOde();
            odemeturu = "Taksitle Ödeme";
            OdemeGoster();
        }
        #endregion

        #region ------------------> Ödeme İşlemi
        private void btn_odeme_yap_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Ödenecek Tutar: {toplam_ucret}", "Ödeme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                siparis.Ekle(new Siparis
                {
                    MusteriID = uc_giris._kullanici.MusteriID,
                    ArabaID = araba.ArabaID,
                    OdemeTuru = odemeturu,
                    Taksit = taksitle.TaksitSayisi,
                    AracFiyat = araba.Fiyat,
                    ToplamFiyat = toplam_ucret
                });
                arabaDAL.Guncelle(new Araba
                {
                    ArabaID = araba.ArabaID,
                    UretimYili = araba.UretimYili,
                    Marka = araba.Marka,
                    Model = araba.Model,
                    VitesTipi = araba.VitesTipi,
                    Fiyat = araba.Fiyat,
                    Stok = araba.Stok - 1,
                    YakitTipi = araba.YakitTipi,
                    KM = araba.KM,
                    KasaTipi = araba.KasaTipi,
                    Renk = araba.Renk,
                    CekisTipi = araba.CekisTipi,
                    MotorHacmi = araba.MotorHacmi,
                    MotorGucu = araba.MotorGucu
                });
                MessageBox.Show($"{araba.Marka} - {araba.Model} araban oldu!", "Tebrikler!");
                Form1.uc_Kullanici.btn_siparislerim.PerformClick();
            }

        }
        #endregion

        #region ------------------> Ödeme Gösterme
        void OdemeGoster()
        {
            lbl_toplam_ucret_miktari.Visible = true;
            lbl_toplam_ucret.Visible = true;
            btn_odeme_yap.Visible = true;
        }
        #endregion
    }
}
