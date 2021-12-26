
namespace Siparis_Otomasyon.Ui
{
    partial class uc_kullanici
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_siparislerim = new FontAwesome.Sharp.IconButton();
            this.btn_hesabim = new FontAwesome.Sharp.IconButton();
            this.btn_araba_arama_kullanici = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_siparislerim
            // 
            this.btn_siparislerim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siparislerim.FlatAppearance.BorderSize = 0;
            this.btn_siparislerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siparislerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparislerim.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btn_siparislerim.IconColor = System.Drawing.Color.Black;
            this.btn_siparislerim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_siparislerim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_siparislerim.Location = new System.Drawing.Point(0, 120);
            this.btn_siparislerim.Name = "btn_siparislerim";
            this.btn_siparislerim.Size = new System.Drawing.Size(220, 60);
            this.btn_siparislerim.TabIndex = 9;
            this.btn_siparislerim.Text = "Siparişlerim";
            this.btn_siparislerim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_siparislerim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_siparislerim.UseVisualStyleBackColor = true;
            // 
            // btn_hesabim
            // 
            this.btn_hesabim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hesabim.FlatAppearance.BorderSize = 0;
            this.btn_hesabim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesabim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesabim.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_hesabim.IconColor = System.Drawing.Color.Black;
            this.btn_hesabim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_hesabim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hesabim.Location = new System.Drawing.Point(0, 60);
            this.btn_hesabim.Name = "btn_hesabim";
            this.btn_hesabim.Size = new System.Drawing.Size(220, 60);
            this.btn_hesabim.TabIndex = 7;
            this.btn_hesabim.Text = "Hesabım";
            this.btn_hesabim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hesabim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_hesabim.UseVisualStyleBackColor = true;
            // 
            // btn_araba_arama_kullanici
            // 
            this.btn_araba_arama_kullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_araba_arama_kullanici.FlatAppearance.BorderSize = 0;
            this.btn_araba_arama_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_araba_arama_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_araba_arama_kullanici.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btn_araba_arama_kullanici.IconColor = System.Drawing.Color.Black;
            this.btn_araba_arama_kullanici.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_araba_arama_kullanici.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_araba_arama_kullanici.Location = new System.Drawing.Point(0, 0);
            this.btn_araba_arama_kullanici.Name = "btn_araba_arama_kullanici";
            this.btn_araba_arama_kullanici.Size = new System.Drawing.Size(220, 60);
            this.btn_araba_arama_kullanici.TabIndex = 6;
            this.btn_araba_arama_kullanici.Text = "Arama";
            this.btn_araba_arama_kullanici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_araba_arama_kullanici.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_araba_arama_kullanici.UseVisualStyleBackColor = true;
            // 
            // uc_kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_siparislerim);
            this.Controls.Add(this.btn_hesabim);
            this.Controls.Add(this.btn_araba_arama_kullanici);
            this.Name = "uc_kullanici";
            this.Size = new System.Drawing.Size(220, 500);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btn_siparislerim;
        public FontAwesome.Sharp.IconButton btn_hesabim;
        public FontAwesome.Sharp.IconButton btn_araba_arama_kullanici;
    }
}
