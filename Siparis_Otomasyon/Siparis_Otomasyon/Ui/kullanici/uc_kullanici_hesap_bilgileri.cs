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
using Siparis_Otomasyon.VeriErisim.Tablolar.Musteriler;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_kullanici_hesap_bilgileri : UserControl
    {
        #region ------------------> DAL tanımlamaları
        IlDAL ilDAL = new IlDAL();
        IlceDAL ilceDAL = new IlceDAL();
        MusteriDAL mstrDAL = new MusteriDAL();
        Random rn_sayi = new Random();
        #endregion

        public uc_kullanici_hesap_bilgileri()
        {
            InitializeComponent();
        }

        #region ------------------> Form Yüklenirken
        private void uc_kullanici_hesap_bilgileri_Load(object sender, EventArgs e)
        {
            lbl_kayit_kod.Text = rn_sayi.Next(1000, 10000).ToString();
            cb_il.DataSource = ilDAL.Hepsini_Getir();
            cb_il.ValueMember = "Il_ID";
            cb_il.DisplayMember = "Il_AD";

            ilceAyarla();

            txt_guncel_ad.Text = uc_giris._kullanici.AD;
            txt_guncel_soyad.Text = uc_giris._kullanici.Soyad;
            txt_guncel_mail.Text = uc_giris._kullanici.Eposta;
            mtxt_guncel_telefon.Text = uc_giris._kullanici.Telefon;
            cb_il.SelectedIndex = cb_il.FindStringExact(uc_giris._kullanici.IlAd);
            cb_ilce.SelectedIndex = cb_ilce.FindStringExact(uc_giris._kullanici.IlceAD);
            txt_guncel_adres.Text = uc_giris._kullanici.Adres;
        }
        #endregion

        #region ------------------> İle göre ilçeyi ayarla
        private void ilceAyarla()
        {
            cb_ilce.DataSource = ilceDAL.IleGoreGetir(cb_il.SelectedIndex + 1);
            cb_ilce.ValueMember = "Ilce_ID";
            cb_ilce.DisplayMember = "IlceAD";
        }
        #endregion

        #region ------------------> Eposta kontrolü
        bool Eposta(string eposta)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(eposta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region ------------------> İl (CB) değiştirildiğinde İlçe'yi ayarla
        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceAyarla();
        }
        #endregion

        #region ------------------> Bilgileri Güncelle
        private void btn_bilgi_guncelle_Click(object sender, EventArgs e)
        {
            if (mstrDAL.Bos_Mu(txt_guncel_ad.Text)
                && mstrDAL.Bos_Mu(txt_guncel_soyad.Text)
                && mstrDAL.Bos_Mu(txt_guncel_mail.Text)
                && mstrDAL.Bos_Mu(txt_guncel_sifre.Text)
                && mstrDAL.Bos_Mu(txt_guncel_sifretekrar.Text)
                && mstrDAL.Bos_Mu(mtxt_guncel_telefon.Text)
                && mstrDAL.Bos_Mu(cb_il.Text)
                && mstrDAL.Bos_Mu(cb_ilce.Text)
                && mstrDAL.Bos_Mu(txt_guncel_adres.Text)
                && mstrDAL.Bos_Mu(txt_guncel__kod.Text)
                )
            {

                if (Eposta(txt_guncel_mail.Text)
                    && txt_guncel_sifre.Text == txt_guncel_sifretekrar.Text
                    && lbl_kayit_kod.Text == txt_guncel__kod.Text
                    /*&& mstrDAL.Kayit_Yok_Mu(txt_guncel_mail.Text.ToLower())*/)
                {
                    mstrDAL.Guncelle(new Musteri
                    {
                        MusteriID = uc_giris._kullanici.MusteriID,
                        AD = txt_guncel_ad.Text.ToUpper(),
                        Soyad = txt_guncel_soyad.Text.ToUpper(),
                        Eposta = txt_guncel_mail.Text.ToLower(),
                        Sifre = txt_guncel_sifre.Text,
                        Telefon = mtxt_guncel_telefon.Text,
                        IlAd = cb_il.Text,
                        IlceAD = cb_ilce.Text,
                        Adres = txt_guncel_adres.Text.ToUpper()
                    });

                    MessageBox.Show($"Güncelleme Başarılı");
                }
                else { MessageBox.Show("Bilgiler tutarsız!", "Hata"); }
                lbl_kayit_kod.Text = rn_sayi.Next(1000, 10000).ToString();
            }
            else
            {
                MessageBox.Show("Bilgiler EKSİK!");
                lbl_kayit_kod.Text = rn_sayi.Next(1000, 10000).ToString();
            }
        }
        #endregion
    }
}
