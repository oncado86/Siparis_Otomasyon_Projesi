
namespace Siparis_Otomasyon.Ui
{
    partial class uc_admin_araba_guncelle_sil
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
            this.btn_guncelle = new FontAwesome.Sharp.IconButton();
            this.btn_sil = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_guncelle.IconColor = System.Drawing.Color.Black;
            this.btn_guncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guncelle.Location = new System.Drawing.Point(0, 0);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 60);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_sil.IconColor = System.Drawing.Color.Black;
            this.btn_sil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sil.Location = new System.Drawing.Point(120, 0);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 60);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // uc_admin_araba_guncelle_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Name = "uc_admin_araba_guncelle_sil";
            this.Size = new System.Drawing.Size(220, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btn_guncelle;
        public FontAwesome.Sharp.IconButton btn_sil;
    }
}
