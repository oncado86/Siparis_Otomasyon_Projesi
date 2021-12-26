
namespace Siparis_Otomasyon.Ui
{
    partial class uc_cikis
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
            this.btn_cikis_yap = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_cikis_yap
            // 
            this.btn_cikis_yap.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis_yap.FlatAppearance.BorderSize = 0;
            this.btn_cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis_yap.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_cikis_yap.IconColor = System.Drawing.Color.Black;
            this.btn_cikis_yap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cikis_yap.IconSize = 40;
            this.btn_cikis_yap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis_yap.Location = new System.Drawing.Point(0, 0);
            this.btn_cikis_yap.Name = "btn_cikis_yap";
            this.btn_cikis_yap.Size = new System.Drawing.Size(220, 60);
            this.btn_cikis_yap.TabIndex = 3;
            this.btn_cikis_yap.Text = "Çıkış Yap";
            this.btn_cikis_yap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis_yap.UseVisualStyleBackColor = false;
            // 
            // uc_cikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_cikis_yap);
            this.Name = "uc_cikis";
            this.Size = new System.Drawing.Size(220, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btn_cikis_yap;
    }
}
