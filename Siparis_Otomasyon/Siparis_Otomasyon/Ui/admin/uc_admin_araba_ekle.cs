using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siparis_Otomasyon.VeriErisim.DALs;
using Siparis_Otomasyon.VeriErisim.DALs.Arabalar;
using Siparis_Otomasyon.VeriErisim.Interface;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_admin_araba_ekle : UserControl
    {
        #region ------------------> Global Tanımlamalar
        ArabaDAL arabaDAL = new ArabaDAL();
        ArabaCekisTipDAL arabaCekisDAL = new ArabaCekisTipDAL();
        ArabaKasaTipiDAL arabaKasaDAL = new ArabaKasaTipiDAL();
        ArabaMarkaDAL arabaMarkaDAL = new ArabaMarkaDAL();
        ArabaModelDAL arabaModelDAL = new ArabaModelDAL();
        ArabaRenkDAL arabaRenkDAL = new ArabaRenkDAL();
        ArabaVitesTipiDAL arabaVitesDAL = new ArabaVitesTipiDAL();
        ArabaYakitTipiDAL arabaYakitDAL = new ArabaYakitTipiDAL();

        int cb_kodu;
        string yil, marka, model, vites, fiyat, stok, yakit, km, kasa, renk, cekis, hacim, guc;
        #endregion

        #region ------------------> Kullanılacak Araba Değişkenlerinin Tanımlanması
        void degiskenleriTanimla()
        {
            yil = txt_uretim_yili.Text;
            marka = cb_marka.Text;
            model = cb_model.Text;
            vites = cb_vites_tipi.Text;
            fiyat = txt_fiyat.Text;
            stok = txt_stok.Text;
            yakit = cb_yakit_tipi.Text;
            km = txt_KM.Text;
            kasa = cb_kasa_tipi.Text;
            renk = cb_renk.Text;
            cekis = cb_cekis_tipi.Text;
            guc = txt_motor_gucu.Text;
            hacim = txt_motor_hacmi.Text;
        }
        #endregion

        #region ------------------> Araba Ekleme İşlemi
        void EklemeIslemleri(int cbid, string veri)
        {
            if (!string.IsNullOrEmpty(veri))
            {
                switch (cbid)
                {
                    case 1:
                        //marka 
                        if (arabaMarkaDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaMarkaDAL.Ekle(new ArabaMarka { MarkaAD = veri });
                        }
                        break;
                    case 2:
                        // model
                        if (arabaModelDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaModelDAL.Ekle(new ArabaModel { ModelAD = veri, MarkaID = Convert.ToInt32(arabaMarkaDAL.ID_Getir(marka)) });
                        }
                        break;
                    case 3:
                        // vites
                        if (arabaVitesDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaVitesDAL.Ekle(new ArabaVitesTipi { VitesTipAD = veri });
                        }
                        break;
                    case 4:
                        //yakıt
                        if (arabaYakitDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaYakitDAL.Ekle(new ArabaYakitTipi { YakitTipAD = veri });
                        }
                        break;
                    case 5:
                        //kasa
                        if (arabaKasaDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaKasaDAL.Ekle(new ArabaKasaTipi { KasaTipAD = veri });
                        }
                        break;
                    case 6:
                        //renk
                        if (arabaRenkDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaRenkDAL.Ekle(new ArabaRenk { RenkAD = veri });
                        }
                        break;
                    case 7:
                        //cekis
                        if (arabaCekisDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaCekisDAL.Ekle(new ArabaCekisTipi { CekisTipAD = veri });
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion

        #region ------------------> Araba Güncelleme İşlemi
        void GuncellemeIslemleri(int cbid, string veri)
        {
            if (!string.IsNullOrEmpty(veri))
            {
                switch (cbid)
                {
                    case 1:
                        //marka 
                        if (arabaMarkaDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaMarkaDAL.Guncelle(new ArabaMarka { MarkaID = arabaMarkaDAL.ID_Getir(marka), MarkaAD = veri });
                        }
                        break;
                    case 2:
                        // model
                        if (arabaModelDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaModelDAL.Guncelle(new ArabaModel { ModelID = arabaModelDAL.ID_Getir(model), ModelAD = veri, MarkaID = Convert.ToInt32(arabaMarkaDAL.ID_Getir(marka)) });
                        }
                        break;
                    case 3:
                        // vites
                        if (arabaVitesDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaVitesDAL.Guncelle(new ArabaVitesTipi { VitesTipID = arabaVitesDAL.ID_Getir(vites), VitesTipAD = veri });
                        }
                        break;
                    case 4:
                        //yakıt
                        if (arabaYakitDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaYakitDAL.Guncelle(new ArabaYakitTipi { YakitTipID = arabaYakitDAL.ID_Getir(yakit), YakitTipAD = veri });
                        }
                        break;
                    case 5:
                        //kasa
                        if (arabaKasaDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaKasaDAL.Guncelle(new ArabaKasaTipi { KasaTipID = arabaKasaDAL.ID_Getir(kasa), KasaTipAD = veri });
                        }
                        break;
                    case 6:
                        //renk
                        if (arabaRenkDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaRenkDAL.Guncelle(new ArabaRenk { RenkID = arabaRenkDAL.ID_Getir(renk), RenkAD = veri });
                        }
                        break;
                    case 7:
                        //cekis
                        if (arabaCekisDAL.Kayit_Yok_Mu(veri))
                        {
                            arabaCekisDAL.Guncelle(new ArabaCekisTipi { CekisTipID = arabaCekisDAL.ID_Getir(cekis), CekisTipAD = veri });
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion

        #region ------------------> Araba Silme İşlemi
        void SilmeIslemleri(int cbid)
        {
            switch (cbid)
            {
                case 1:
                    //marka
                    arabaMarkaDAL.Sil(new ArabaMarka { MarkaID = arabaMarkaDAL.ID_Getir(marka) });
                    break;
                case 2:
                    // model
                    arabaModelDAL.Sil(new ArabaModel { ModelID = arabaModelDAL.ID_Getir(model), MarkaID = Convert.ToInt32(arabaMarkaDAL.ID_Getir(marka)) });
                    break;
                case 3:
                    // vites
                    arabaVitesDAL.Sil(new ArabaVitesTipi { VitesTipID = arabaVitesDAL.ID_Getir(vites) });
                    break;
                case 4:
                    //yakıt
                    arabaYakitDAL.Sil(new ArabaYakitTipi { YakitTipID = arabaYakitDAL.ID_Getir(yakit) });
                    break;
                case 5:
                    //kasa
                    arabaKasaDAL.Sil(new ArabaKasaTipi { KasaTipID = arabaKasaDAL.ID_Getir(kasa) });
                    break;
                case 6:
                    //renk
                    arabaRenkDAL.Sil(new ArabaRenk { RenkID = arabaRenkDAL.ID_Getir(renk) });
                    break;
                case 7:
                    //cekis
                    arabaCekisDAL.Sil(new ArabaCekisTipi { CekisTipID = arabaCekisDAL.ID_Getir(cekis) });
                    break;

                default:
                    break;
            }
        }
        #endregion

        public uc_admin_araba_ekle()
        {
            InitializeComponent();
        }

        #region ------------------> Verilerin Temizlenmesi
        public void VerileriTemizle()
        {
            txt_uretim_yili.Clear();
            cb_marka.Text = "";
            cb_model.Text = "";
            cb_vites_tipi.Text = "";
            txt_fiyat.Clear();
            txt_stok.Clear();
            cb_yakit_tipi.Text = "";
            txt_KM.Clear();
            cb_kasa_tipi.Text = "";
            cb_renk.Text = "";
            cb_cekis_tipi.Text = "";
            txt_motor_hacmi.Clear();
            txt_motor_gucu.Clear();
        }
        #endregion

        #region ------------------> ComboBox'ların Doldurulması
        private void CB_Doldur()
        {
            #region ------------------> ÇEKİŞ TİPİ
            cb_cekis_tipi.DataSource = arabaCekisDAL.Hepsini_Getir();
            cb_cekis_tipi.ValueMember = "CekisTipID";
            cb_cekis_tipi.DisplayMember = "CekisTipAD";
            #endregion

            #region ------------------> KASA TİPİ
            cb_kasa_tipi.DataSource = arabaKasaDAL.Hepsini_Getir();
            cb_kasa_tipi.ValueMember = "KasaTipID";
            cb_kasa_tipi.DisplayMember = "KasaTipAD";
            #endregion

            #region ------------------> MARKA 
            cb_marka.DataSource = arabaMarkaDAL.Hepsini_Getir();
            cb_marka.ValueMember = "MarkaID";
            cb_marka.DisplayMember = "MarkaAD";
            #endregion

            #region ------------------> MODEL
            cb_model.DataSource = arabaModelDAL.MarkayaGoreGetir(arabaMarkaDAL.ID_Getir(cb_marka.Text));
            cb_model.ValueMember = "ModelID";
            cb_model.DisplayMember = "ModelAD";
            #endregion,

            #region ------------------> RENK
            cb_renk.DataSource = arabaRenkDAL.Hepsini_Getir();
            cb_renk.ValueMember = "RenkID";
            cb_renk.DisplayMember = "RenkAD";
            #endregion

            #region ------------------> VİTES TİPİ
            cb_vites_tipi.DataSource = arabaVitesDAL.Hepsini_Getir();
            cb_vites_tipi.ValueMember = "VitesTipID";
            cb_vites_tipi.DisplayMember = "VitesTipAD";
            #endregion

            #region ------------------> YAKIT TİPİ
            cb_yakit_tipi.DataSource = arabaYakitDAL.Hepsini_Getir();
            cb_yakit_tipi.ValueMember = "YakitTipID";
            cb_yakit_tipi.DisplayMember = "YakitTipAD";
            #endregion


        }
        #endregion

        #region ------------------> Form Yüklenirken
        private void uc_admin_araba_ekle_Load(object sender, EventArgs e)
        {
            CB_Doldur();
            gb_egs.Enabled = false;
        }
        #endregion

        #region ------------------> Araba Silme Butonu
        private void btn_secimi_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "SİLİNECEK", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SilmeIslemleri(cb_kodu);
                MessageBox.Show("Kayıt başarıyla silindi!.");
            }
            else { MessageBox.Show("İşlem iptal edildi"); }
            CB_Doldur();
            CrudTemizle();
        }
        #endregion

        #region ------------------> Araba Ekleme Butonu
        private void btn_araba_ekle_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();

            if (arabaDAL.Bos_Mu(yil)
                    && arabaDAL.Bos_Mu(fiyat)
                    && arabaDAL.Bos_Mu(stok)
                    && arabaDAL.Bos_Mu(km)
                    && arabaDAL.Bos_Mu(guc)
                    && arabaDAL.Bos_Mu(hacim))
            {
                arabaDAL.Ekle(new Araba
                {
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
                }) ;

                MessageBox.Show($"{marka} - {model} araç başarıyla eklendi.");
                VerileriTemizle();
            }
            else { MessageBox.Show("Bilgiler EKSİK!"); }
        }
        #endregion

        #region ------------------> Markaya Göre Model Getirme
        private void cb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_model.DataSource = arabaModelDAL.MarkayaGoreGetir(arabaMarkaDAL.ID_Getir(cb_marka.Text));
        }
        #endregion

        #region ------------------> Araçarın Özelliklerinin CRUD İşlemleri (marka, model, renk..)

        #region ------------------> Marka
        private void btn_marka_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 1;
            txt_eski_bilgi.Text = cb_marka.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Model
        private void btn_model_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 2;
            txt_eski_bilgi.Text = cb_model.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Vites Tipi
        private void btn_vites_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 3;
            txt_eski_bilgi.Text = cb_vites_tipi.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Yakıt Tipi
        private void btn_yakit_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 4;
            txt_eski_bilgi.Text = cb_yakit_tipi.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Kasa Tipi
        private void btn_kasa_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 5;
            txt_eski_bilgi.Text = cb_kasa_tipi.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Renk
        private void btn_renk_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 6;
            txt_eski_bilgi.Text = cb_renk.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> Çekiş Tipi
        private void btn_cekis_Click(object sender, EventArgs e)
        {
            degiskenleriTanimla();
            cb_kodu = 7;
            txt_eski_bilgi.Text = cb_cekis_tipi.Text;
            gb_egs.Enabled = true;
        }
        #endregion

        #region ------------------> CRUD Kısmı

        #region ------------------> Crud Temizle
        void CrudTemizle()
        {
            txt_guncel_bilgi.Clear();
            txt_eski_bilgi.Clear();
            txt_yeni_bilgi.Clear();
            cb_kodu = 0;
            gb_egs.Enabled = false;
        }
        #endregion

        #region ------------------> Seçimi Ekle
        private void btn_secimi_ekle_Click(object sender, EventArgs e)
        {
            EklemeIslemleri(cb_kodu, txt_yeni_bilgi.Text);
            CB_Doldur();
            CrudTemizle();
        }
        #endregion

        #region ------------------> Seçimi Güncelle
        private void btn_secimi_guncelle_Click(object sender, EventArgs e)
        {
            GuncellemeIslemleri(cb_kodu, txt_guncel_bilgi.Text);
            CB_Doldur();
            CrudTemizle();
        }
        #endregion
        #endregion

        #endregion
    }
}
