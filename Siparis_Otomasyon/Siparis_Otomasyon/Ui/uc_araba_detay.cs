using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siparis_Otomasyon.VeriErisim.DALs.Arabalar;
using Siparis_Otomasyon.VeriErisim.Tablolar.Arabalar;

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_araba_detay : UserControl
    {
        public uc_araba_detay()
        {
            InitializeComponent();
        }

        #region ------------------> DAL tanımlamaları
        ArabaCekisTipDAL arabaCekisTipDAL = new ArabaCekisTipDAL();
        ArabaRenkDAL arabaRenkDAL = new ArabaRenkDAL();
        ArabaKasaTipiDAL arabaKasaTipiDAL = new ArabaKasaTipiDAL();
        ArabaYakitTipiDAL arabaYakitTipiDAL = new ArabaYakitTipiDAL();
        ArabaVitesTipiDAL arabaVitesTipiDAL = new ArabaVitesTipiDAL();
        ArabaMarkaDAL arabaMarkaDAL = new ArabaMarkaDAL();
        ArabaModelDAL arabaModelDAL = new ArabaModelDAL();
        #endregion

        #region ------------------> Verileri Doldur
        public void VerileriDoldur(Araba araba)
        {
            #region ------------------> ÜRETİM YILI
            txt_uretim_yili.Text = araba.UretimYili.ToString();
            #endregion

            #region ------------------> MARKA 
            cb_marka.DataSource = arabaMarkaDAL.Hepsini_Getir();
            cb_marka.ValueMember = "MarkaID";
            cb_marka.DisplayMember = "MarkaAD";
            cb_marka.SelectedIndex = cb_marka.FindStringExact(araba.Marka);
            #endregion

            #region ------------------> MODEL
            cb_model.DataSource = arabaModelDAL.MarkayaGoreGetir(arabaMarkaDAL.ID_Getir(cb_marka.Text));
            cb_model.ValueMember = "ModelID";
            cb_model.DisplayMember = "ModelAD";
            cb_model.SelectedIndex = cb_model.FindStringExact(araba.Model);
            #endregion,

            #region ------------------> VİTES TİPİ
            cb_vites_tipi.DataSource = arabaVitesTipiDAL.Hepsini_Getir();
            cb_vites_tipi.ValueMember = "VitesTipID";
            cb_vites_tipi.DisplayMember = "VitesTipAD";
            cb_vites_tipi.SelectedIndex = cb_vites_tipi.FindStringExact(araba.VitesTipi);
            #endregion

            #region ------------------> FİYAT
            txt_fiyat.Text = araba.Fiyat.ToString();
            #endregion

            #region  ------------------> STOK
            txt_stok.Text = araba.Stok.ToString();
            #endregion

            #region ------------------> YAKIT TİPİ
            cb_yakit_tipi.DataSource = arabaYakitTipiDAL.Hepsini_Getir();
            cb_yakit_tipi.ValueMember = "YakitTipID";
            cb_yakit_tipi.DisplayMember = "YakitTipAD";
            cb_yakit_tipi.SelectedIndex = cb_yakit_tipi.FindStringExact(araba.YakitTipi);
            #endregion

            #region ------------------> Araç KM
            txt_KM.Text = araba.KM.ToString();
            #endregion

            #region ------------------> KASA TİPİ
            cb_kasa_tipi.DataSource = arabaKasaTipiDAL.Hepsini_Getir();
            cb_kasa_tipi.ValueMember = "KasaTipID";
            cb_kasa_tipi.DisplayMember = "KasaTipAD";
            cb_kasa_tipi.SelectedIndex = cb_kasa_tipi.FindStringExact(araba.KasaTipi);
            #endregion

            #region ------------------> RENK
            cb_renk.DataSource = arabaRenkDAL.Hepsini_Getir();
            cb_renk.ValueMember = "RenkID";
            cb_renk.DisplayMember = "RenkAD";
            cb_renk.SelectedIndex = cb_renk.FindStringExact(araba.Renk);
            #endregion

            #region ------------------> ÇEKİŞ TİPİ
            cb_cekis_tipi.DataSource = arabaCekisTipDAL.Hepsini_Getir();
            cb_cekis_tipi.ValueMember = "CekisTipID";
            cb_cekis_tipi.DisplayMember = "CekisTipAD";
            cb_cekis_tipi.SelectedIndex = cb_cekis_tipi.FindStringExact(araba.CekisTipi);
            #endregion

            #region ------------------> MOTOR HACMİ
            txt_motor_hacmi.Text = araba.MotorHacmi;
            #endregion

            #region ------------------>  MOTOR GÜCÜ
            txt_motor_gucu.Text = araba.MotorGucu;
            #endregion
        }
        #endregion

        #region ------------------> Markaya göre Modelleri getir
        private void cb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_model.DataSource = arabaModelDAL.MarkayaGoreGetir(arabaMarkaDAL.ID_Getir(cb_marka.Text));
        }
        #endregion
    }
}
