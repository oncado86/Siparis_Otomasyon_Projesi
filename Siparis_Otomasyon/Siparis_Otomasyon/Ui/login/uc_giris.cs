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
    public partial class uc_giris : UserControl
    {
        #region ------------------> Global Tanımlar
        IlDAL ilDAL = new IlDAL();
        IlceDAL ilceDAL = new IlceDAL();
        MusteriDAL mstrDAL = new MusteriDAL();

        public static Musteri _kullanici = new Musteri();
        public bool _giris_onayi = false;
        public bool _admin = false;
        #endregion

        public uc_giris()
        {
            InitializeComponent();
        }

        #region ------------------> Form Yüklenirke
        private void uc_giris_Load(object sender, EventArgs e)
        {
            RandomKod();
            cb_il.DataSource = ilDAL.Hepsini_Getir();
            cb_il.ValueMember = "Il_ID";
            cb_il.DisplayMember = "Il_AD";

            ilceAyarla();
        }
        #endregion

        #region ------------------> Güvenlik Kodu Üretme
        public void RandomKod()
        {
            Random rn_sayi = new Random();
            lbl_giris_kod.Text = rn_sayi.Next(1000, 10000).ToString();
            lbl_kayit_kod.Text = rn_sayi.Next(1000, 10000).ToString();
        }
        #endregion

        #region ------------------> Eposta doğrulama
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

        #region ------------------> Rol Kontrol
        bool rol(Musteri ms)
        {
            return ms.Rol == "1";
        }
        #endregion

        #region ------------------> İle göre İlçeyi ayarlama
        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceAyarla();
        }

        private void ilceAyarla()
        {
            cb_ilce.DataSource = ilceDAL.IleGoreGetir(cb_il.SelectedIndex + 1);
            cb_ilce.ValueMember = "Ilce_ID";
            cb_ilce.DisplayMember = "IlceAD";
        }
        #endregion

        #region ------------------> Kayıt Olma İşlemi
        private void btn_kayit_ol_Click(object sender, EventArgs e)
        {
            if (mstrDAL.Bos_Mu(txt_kayit_ad.Text)
                && mstrDAL.Bos_Mu(txt_kayit_soyad.Text)
                && mstrDAL.Bos_Mu(txt_kayit_mail.Text)
                && mstrDAL.Bos_Mu(txt_kayit_sifre.Text)
                && mstrDAL.Bos_Mu(txt_kayit_sifretekrar.Text)
                && mstrDAL.Bos_Mu(mtxt_kayit_telefon.Text)
                && mstrDAL.Bos_Mu(cb_il.Text)
                && mstrDAL.Bos_Mu(cb_ilce.Text)
                && mstrDAL.Bos_Mu(txt_kayit_adres.Text)
                && mstrDAL.Bos_Mu(txt_kayit_kod.Text)
                )
            {

                if (Eposta(txt_kayit_mail.Text)
                    && txt_kayit_sifre.Text == txt_kayit_sifretekrar.Text
                    && lbl_kayit_kod.Text == txt_kayit_kod.Text
                    && mstrDAL.Kayit_Yok_Mu(txt_kayit_mail.Text.ToLower()))
                {
                    mstrDAL.Ekle(new Musteri
                    {
                        AD = txt_kayit_ad.Text.ToUpper(),
                        Soyad = txt_kayit_soyad.Text.ToUpper(),
                        Eposta = txt_kayit_mail.Text.ToLower(),
                        Sifre = txt_kayit_sifre.Text,
                        Telefon = mtxt_kayit_telefon.Text,
                        IlAd = cb_il.Text,
                        IlceAD = cb_ilce.Text,
                        Adres = txt_kayit_adres.Text.ToUpper()
                    });
                    _kullanici = mstrDAL.Maile_Gore_getir(txt_kayit_mail.Text);
                    _giris_onayi = true;
                    _admin = rol(_kullanici);
                    MessageBox.Show($"Hoş geldin {_kullanici.AD}", "Kayıt Başarılı");
                }
                else { MessageBox.Show("Bilgiler tutarsız!"); }
                RandomKod();
            }
            else
            {
                MessageBox.Show("Bilgiler EKSİK!");
                RandomKod();
            }
        }
        #endregion

        #region ------------------> Hesaba Giriş İşlemi
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string posta, sifre;

            posta = txt_giris_posta.Text;
            sifre = txt_giris_sifre.Text;
            if (Eposta(posta) && !mstrDAL.Kayit_Yok_Mu(posta.ToLower()))
            {
                if (mstrDAL.SifreDogruMu(posta, sifre)
                    && lbl_giris_kod.Text == txt_giris_kod.Text)
                {
                    _kullanici = mstrDAL.Maile_Gore_getir(posta);
                    _admin = rol(_kullanici);
                    _giris_onayi = true;
                    MessageBox.Show($"Hoş geldin {_kullanici.AD}", "Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Bilgiler tutarsız!");
                    RandomKod();
                }
            }
            else
            {
                MessageBox.Show("Bilgiler hatalı lütfen tekrar deneyiniz!");
                RandomKod();
            }
        }
        #endregion
    }
}

