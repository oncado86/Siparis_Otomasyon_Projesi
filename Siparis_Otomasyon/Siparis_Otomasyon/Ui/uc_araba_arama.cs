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

namespace Siparis_Otomasyon.Ui
{
    public partial class uc_araba_arama : UserControl
    {
        ArabaDAL arabaDAL = new ArabaDAL();

        public uc_araba_arama()
        {
            InitializeComponent();
        }

        #region ------------------> Form Yüklenirken
        private void uc_araba_arama_Load(object sender, EventArgs e)
        {
            HepsiniYukle();
        }
        #endregion

        #region ------------------> Verileri Getirip Kullanıcıya Göster
        public void HepsiniYukle()
        {
            dgv_.DataSource = arabaDAL.Hepsini_Getir();
            dgv_.Columns[0].Visible = false;
            dgv_.Columns[4].Visible = false;
            dgv_.Columns[6].Visible = false;
            dgv_.Columns[8].Visible = false;
            dgv_.Columns[9].Visible = false;
            dgv_.Columns[11].Visible = false;
            dgv_.Columns[13].Visible = false;
            dgv_.Columns[1].HeaderText = "Araç Üretim Yılı";
            dgv_.Columns[2].HeaderText = "Marka";
            dgv_.Columns[3].HeaderText = "Model";
            dgv_.Columns[5].HeaderText = "Fiyat";
            dgv_.Columns[7].HeaderText = "Yakıt Türü";
            dgv_.Columns[10].HeaderText = "Araç Rengi";
            dgv_.Columns[12].HeaderText = "Motor Hacmi";
        }
        #endregion

        #region ------------------> Arabaların Markaya Göre Dinamik Aranması
        private void txt__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_.Text))
            {
                dgv_.DataSource = arabaDAL.Markaya_Gore_Ara(txt_.Text);
            }
            else { HepsiniYukle(); }
        }
        #endregion
    }
}
