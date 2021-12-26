using System;
using System.Windows.Forms;
using Siparis_Otomasyon.VeriErisim.DALs.Arabalar;
using Siparis_Otomasyon.VeriErisim.DALs.Musteriler;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;
using Siparis_Otomasyon.Ui;

namespace Siparis_Otomasyon
{
    public partial class Form1 : Form
    {
        #region ------------------------------------>> Global Tanımlamalar

        #region ------------------> UC Tanımlamaları
        uc_araba_arama uc_arabaArama = new uc_araba_arama();
        uc_admin uc_Admin = new uc_admin();
        public static uc_kullanici uc_Kullanici = new uc_kullanici();
        uc_giris uc_Giris = new uc_giris();
        uc_islemleri uc_Islemleri = new uc_islemleri();
        uc_araba_detay uc_Araba_Detay = new uc_araba_detay();
        uc_admin_araba_guncelle_sil uc_admin_ArabaGuncelleSil = new uc_admin_araba_guncelle_sil();
        uc_admin_araba_ekle uc_Admin_Araba_Ekle = new uc_admin_araba_ekle();
        uc_admin_musteri_arama uc_Admin_Musteri_Arama = new uc_admin_musteri_arama();
        uc_admin_siparisler uc_Admin_Siparisler = new uc_admin_siparisler();
        uc_kullanici_hesap_bilgileri uc_Kullanici_Hesap_Bilgileri = new uc_kullanici_hesap_bilgileri();
        uc_kullanici_siparis_ver uc_Kullanici_Siparis_Ver = new uc_kullanici_siparis_ver();
        uc_kullanici_siparisleri uc_Kullanici_Siparisleri = new uc_kullanici_siparisleri();
        uc_kullanici_siparis_ekrani uc_Kullanici_Siparis_Ekrani = new uc_kullanici_siparis_ekrani();
        uc_cikis uc_Cikis = new uc_cikis();
        #endregion

        #region ------------------> DAL tanımlamaları
        Araba araba = new Araba();
        ArabaDAL arabaDAL = new ArabaDAL();
        MusteriDAL musteriDAL = new MusteriDAL();
        #endregion

        #endregion

        public Form1()
        {
            InitializeComponent();
            #region ------------------------------------>> UC'daki butonlara Click Event'leri

            #region ------------------> UC_giriş işlemleri
            uc_Giris.btn_giris.Click += Btn_giris_Click;
            uc_Giris.btn_kayit_ol.Click += Btn_kayit_ol_Click;
            #endregion

            #region ------------------> UC_admin islemleri
            uc_Admin.btn_arama.Click += Btn_arama_Click;
            uc_admin_ArabaGuncelleSil.btn_guncelle.Click += Btn_guncelle_Click;
            uc_admin_ArabaGuncelleSil.btn_sil.Click += Btn_sil_Click;
            uc_Admin.btn_arac_ekle.Click += Btn_arac_ekle_Click;
            uc_Admin.btn_kullanicilar.Click += Btn_kullanicilar_Click;
            uc_Admin.btn_siparisler.Click += Btn_siparisler_Click;
            #endregion

            #region ------------------> UC_kullanıcı islemleri
            uc_Kullanici.btn_araba_arama_kullanici.Click += Btn_araba_arama_kullanici_Click;
            uc_Kullanici.btn_hesabim.Click += Btn_hesabim_Click;
            uc_Kullanici.btn_siparislerim.Click += Btn_siparislerim_Click;
            uc_Kullanici_Siparis_Ver.btn_siparis_ver.Click += Btn_siparis_ver_Click;
            #endregion

            #region ------------------> UC_araba_arama
            uc_arabaArama.dgv_.CellClick += Dgv__CellClick;
            #endregion

            #region ------------------> çıkış işlemi
            uc_Cikis.btn_cikis_yap.Click += Btn_cikis_yap_Click;
            #endregion

            #endregion
        }

        #region ------------------------------------>> Form Yüklenirken
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_giris_yapan_kullanici_adi.Text = "";
            pnl_sag.Width = 0;
            pnl_sol.Width = 0;

            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Giris);
            tmr_acilis.Start();
        }
        #endregion

        #region ------------------------------------>> Login İşlemleri

        #region ------------------> Kullanıcı Kayıt İşlemi
        private void Btn_kayit_ol_Click(object sender, EventArgs e)
        {
            if (uc_Giris._giris_onayi)
            {
                uc_Islemleri.panel_kontrol_ekle(pnl_sol_menu, uc_Kullanici);
                uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_arabaArama);
                lbl_giris_yapan_kullanici_adi.Text = $"Hoş geldin, {uc_giris._kullanici.AD} {uc_giris._kullanici.Soyad}";
                uc_Islemleri.panel_kontrol_ekle(pnl_sol_alt, uc_Cikis);
            }
        }
        #endregion

        #region ------------------> Kullanıcı Giriş İşlemi
        private void Btn_giris_Click(object sender, EventArgs e)
        {
            if (uc_Giris._giris_onayi)
            {
                if (uc_Giris._admin)
                {
                    uc_Islemleri.panel_kontrol_ekle(pnl_sol_menu, uc_Admin);
                }
                else
                {
                    uc_Islemleri.panel_kontrol_ekle(pnl_sol_menu, uc_Kullanici);
                }


                lbl_giris_yapan_kullanici_adi.Text = $"Hoş geldin, {uc_giris._kullanici.AD} {uc_giris._kullanici.Soyad}";
                uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_arabaArama);
                uc_Islemleri.panel_kontrol_ekle(pnl_sol_alt, uc_Cikis);
                tmr_sol_ac.Start();
            }
        }
        #endregion

        #region ------------------> Kullanıcı Çıkış İşlemi
        private void Btn_cikis_yap_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                pnl_sag_alt.Controls.Clear();
                pnl_sag_menu.Controls.Clear();
                pnl_sol_alt.Controls.Clear();
                pnl_sol_menu.Controls.Clear();
                tmr_sag_kapat.Start();
                tmr_sol_kapat.Start();
                uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Giris);
                uc_Giris._giris_onayi = false;
                uc_Giris.txt_giris_kod.Clear();
                uc_Giris.txt_giris_sifre.Clear();
                uc_Giris.RandomKod();
                lbl_giris_yapan_kullanici_adi.Text = "";
                uc_giris._kullanici.AD = "";
                uc_giris._kullanici.Soyad = "";
                uc_giris._kullanici.Eposta = "";
                uc_giris._kullanici.Sifre = "";
                uc_giris._kullanici.Telefon = "";
                uc_giris._kullanici.IlAd = "";
                uc_giris._kullanici.IlceAD = "";
                uc_giris._kullanici.Adres = "";
                uc_Giris.txt_kayit_ad.Clear();
                uc_Giris.txt_kayit_soyad.Clear();
                uc_Giris.txt_kayit_mail.Clear();
                uc_Giris.txt_kayit_sifre.Clear();
                uc_Giris.txt_kayit_sifretekrar.Clear();
                uc_Giris.txt_kayit_kod.Clear();
                uc_Giris.mtxt_kayit_telefon.Clear();
                uc_Giris.txt_kayit_adres.Clear();
            }
        }
        #endregion

        #endregion

        #region ------------------------------------>> ADMIN İşlemleri

        #region ------------------> Araba Silme
        private void Btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "SİLİNECEK", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                arabaDAL.Sil(new Araba { ArabaID = araba.ArabaID });

                MessageBox.Show("Kayıt silindi!");
                uc_arabaArama.HepsiniYukle();
                tmr_sag_kapat.Start();
            }
            else { MessageBox.Show("İşlem iptal edildi"); }
        }
        #endregion

        #region ------------------> Araba Ekleme
        private void Btn_arac_ekle_Click(object sender, EventArgs e)
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Admin_Araba_Ekle);
            tmr_sag_kapat.Start();
        }
        #endregion

        #region ------------------> Araba Güncelleme
        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            string yil, marka, model, vites, fiyat, stok, yakit, km, kasa, renk, cekis, hacim, guc;
            yil = uc_Araba_Detay.txt_uretim_yili.Text;
            marka = uc_Araba_Detay.cb_marka.Text;
            model = uc_Araba_Detay.cb_model.Text;
            vites = uc_Araba_Detay.cb_vites_tipi.Text;
            fiyat = uc_Araba_Detay.txt_fiyat.Text;
            stok = uc_Araba_Detay.txt_stok.Text;
            yakit = uc_Araba_Detay.cb_yakit_tipi.Text;
            km = uc_Araba_Detay.txt_KM.Text;
            kasa = uc_Araba_Detay.cb_kasa_tipi.Text;
            renk = uc_Araba_Detay.cb_renk.Text;
            cekis = uc_Araba_Detay.cb_cekis_tipi.Text;
            guc = uc_Araba_Detay.txt_motor_gucu.Text;
            hacim = uc_Araba_Detay.txt_motor_hacmi.Text;

            if (arabaDAL.Bos_Mu(yil)
                    && arabaDAL.Bos_Mu(fiyat)
                    && arabaDAL.Bos_Mu(stok)
                    && arabaDAL.Bos_Mu(km)
                    && arabaDAL.Bos_Mu(guc)
                    && arabaDAL.Bos_Mu(hacim))
            {
                arabaDAL.Guncelle(new Araba
                {
                    ArabaID = araba.ArabaID,
                    UretimYili = Convert.ToInt32(yil),
                    Marka = marka,
                    Model = model,
                    VitesTipi = vites,
                    Fiyat = Convert.ToInt32(fiyat),
                    Stok = Convert.ToInt32(stok),
                    YakitTipi = yakit,
                    KM = Convert.ToInt32(km),
                    KasaTipi = kasa,
                    Renk = renk,
                    CekisTipi = cekis,
                    MotorHacmi = hacim,
                    MotorGucu = guc
                });

                araba = arabaDAL.IDyeGoreGetir(Convert.ToInt32(uc_arabaArama.dgv_.CurrentRow.Cells[0].Value));
                uc_Araba_Detay.VerileriDoldur(araba);
                ArabaDetayGosterimi();
                MessageBox.Show("Araç Bilgileri güncellendi");
            }
            else { MessageBox.Show("Bilgiler EKSİK!"); }
        }
        #endregion

        #region ------------------> Siparişleri Görüntüleme
        private void Btn_siparisler_Click(object sender, EventArgs e)
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Admin_Siparisler);
            uc_Admin_Siparisler.HepsiniYukle();
            tmr_sag_kapat.Start();
        }
        #endregion

        #region ------------------> Kullanıcıları Görüntüleme
        private void Btn_kullanicilar_Click(object sender, EventArgs e)
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Admin_Musteri_Arama);
            uc_Admin_Musteri_Arama.HepsiniYukle();
            tmr_sag_kapat.Start();
        }
        #endregion

        #region ------------------> Arabaları Görüntüleme
        private void Btn_arama_Click(object sender, EventArgs e)
        {
            ArabaArama();
        }
        #endregion

        #endregion

        #region ------------------------------------>> Kullanıcı İşlemleri

        #region ------------------> Kullanıcı Siparişleri
        private void Btn_siparislerim_Click(object sender, EventArgs e)
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Kullanici_Siparisleri);
            uc_Kullanici_Siparisleri.HepsiniYukle();
            tmr_sag_kapat.Start();
        }
        #endregion

        #region ------------------> Kullanıcı Hesap
        private void Btn_hesabim_Click(object sender, EventArgs e)
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Kullanici_Hesap_Bilgileri);
            tmr_sag_kapat.Start();
        }
        #endregion

        #region ------------------> Kullanıcı Araba Arama
        private void Btn_araba_arama_kullanici_Click(object sender, EventArgs e)
        {
            ArabaArama();
        }
        #endregion

        #region ------------------> Kullanıcı Sipariş Vermesi
        private void Btn_siparis_ver_Click(object sender, EventArgs e)
        {
            if (uc_Kullanici_Siparis_Ver.btn_siparis_ver.Visible)
            {
                if (araba.Stok > 0)
                {
                    uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_Kullanici_Siparis_Ekrani);
                    tmr_sol_kapat.Start();
                    uc_Kullanici_Siparis_Ver.btn_siparis_ver.Visible = false;
                }
                else { MessageBox.Show($"{araba.Marka}-{araba.Model} stokta kalmadı!", "Üzgünüm.."); }
            }


        }
        #endregion

        #endregion

        #region ------------------------------------>> Araba Arama ve Detayları

        #region ------------------> Listeye Tıklama
        private void Dgv__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArabaDetayGosterimi();
            if (!uc_Kullanici_Siparis_Ver.btn_siparis_ver.Visible)
            {
                uc_Kullanici_Siparis_Ver.btn_siparis_ver.Visible = true;
            }
        }
        #endregion

        #region ------------------> Araba Detay Gösterimi
        void ArabaDetayGosterimi()
        {
            tmr_sag_ac.Start();
            araba = arabaDAL.IDyeGoreGetir(Convert.ToInt32(uc_arabaArama.dgv_.CurrentRow.Cells[0].Value));
            uc_Islemleri.panel_kontrol_ekle(pnl_sag_menu, uc_Araba_Detay);
            uc_Araba_Detay.VerileriDoldur(araba);
            uc_Kullanici_Siparis_Ekrani.ArabaBilgisiAl(araba);

            if (uc_Giris._admin)
            {
                uc_Araba_Detay.txt_uretim_yili.Enabled = true;
                uc_Araba_Detay.cb_marka.Enabled = true;
                uc_Araba_Detay.cb_model.Enabled = true;
                uc_Araba_Detay.cb_vites_tipi.Enabled = true;
                uc_Araba_Detay.txt_fiyat.Enabled = true;
                uc_Araba_Detay.txt_stok.Enabled = true;
                uc_Araba_Detay.cb_yakit_tipi.Enabled = true;
                uc_Araba_Detay.txt_KM.Enabled = true;
                uc_Araba_Detay.cb_kasa_tipi.Enabled = true;
                uc_Araba_Detay.cb_renk.Enabled = true;
                uc_Araba_Detay.cb_cekis_tipi.Enabled = true;
                uc_Araba_Detay.txt_motor_hacmi.Enabled = true;
                uc_Araba_Detay.txt_motor_gucu.Enabled = true;
                uc_Islemleri.panel_kontrol_ekle(pnl_sag_alt, uc_admin_ArabaGuncelleSil);
            }
            else
            {
                uc_Islemleri.panel_kontrol_ekle(pnl_sag_alt, uc_Kullanici_Siparis_Ver);
                uc_Araba_Detay.txt_uretim_yili.Enabled = false;
                uc_Araba_Detay.cb_marka.Enabled = false;
                uc_Araba_Detay.cb_model.Enabled = false;
                uc_Araba_Detay.cb_vites_tipi.Enabled = false;
                uc_Araba_Detay.txt_fiyat.Enabled = false;
                uc_Araba_Detay.txt_stok.Enabled = false;
                uc_Araba_Detay.cb_yakit_tipi.Enabled = false;
                uc_Araba_Detay.txt_KM.Enabled = false;
                uc_Araba_Detay.cb_kasa_tipi.Enabled = false;
                uc_Araba_Detay.cb_renk.Enabled = false;
                uc_Araba_Detay.cb_cekis_tipi.Enabled = false;
                uc_Araba_Detay.txt_motor_hacmi.Enabled = false;
                uc_Araba_Detay.txt_motor_gucu.Enabled = false;
            }
        }
        #endregion

        #region ------------------> Araba Arama
        void ArabaArama()
        {
            uc_Islemleri.panel_kontrol_ekle(pnl_orta, uc_arabaArama);
            uc_arabaArama.HepsiniYukle();
            tmr_sag_kapat.Start();
        }
        #endregion

        #endregion

        #region ------------------------------------>> Zamanlayıcılar

        #region ------------------> Sol Panel
        private void tmr_acilis_Tick(object sender, EventArgs e)
        {
            if (pnl_sol.Width < 60)
            {
                pnl_sol.Width += 5;
                if (pnl_sol.Width == 60)
                {
                    tmr_acilis.Stop();
                }
            }
        }

        private void tmr_sol_kapat_Tick(object sender, EventArgs e)
        {
            if (pnl_sol.Width > 60)
            {
                pnl_sol.Width -= 5;
                if (pnl_sol.Width == 60)
                {
                    tmr_sol_kapat.Stop();
                }
            }
        }

        private void tmr_sol_ac_Tick(object sender, EventArgs e)
        {
            if (pnl_sol.Width < 220)
            {
                pnl_sol.Width += 5;
                if (pnl_sol.Width == 220)
                {
                    tmr_sol_ac.Stop();
                }
            }
        }
        #endregion

        #region ------------------> Sağ Panel
        private void btn_sol_panel_menu_Click(object sender, EventArgs e)
        {
            if (pnl_sol.Width == 60)
            {
                tmr_sol_ac.Start();
            }
            else
            {
                tmr_sol_kapat.Start();
            }
        }

        private void btn_sag_panel_menu_Click(object sender, EventArgs e)
        {
            tmr_sag_kapat.Start();
        }

        private void tmr_sag_ac_Tick(object sender, EventArgs e)
        {
            if (pnl_sag.Width < 220)
            {
                pnl_sag.Width += 5;
                if (pnl_sag.Width == 220)
                {
                    tmr_sag_ac.Stop();
                }
            }

        }

        private void tmr_sag_kapat_Tick(object sender, EventArgs e)
        {
            if (pnl_sag.Width > 0)
            {
                pnl_sag.Width -= 5;
                if (pnl_sag.Width == 0)
                {
                    tmr_sag_kapat.Stop();
                }
            }
        }



        #endregion

        #endregion
    }
}
