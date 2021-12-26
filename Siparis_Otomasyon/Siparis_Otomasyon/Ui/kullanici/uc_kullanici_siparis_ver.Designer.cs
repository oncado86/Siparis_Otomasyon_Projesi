
namespace Siparis_Otomasyon.Ui
{
    partial class uc_kullanici_siparis_ver
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
            this.btn_siparis_ver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_siparis_ver
            // 
            this.btn_siparis_ver.FlatAppearance.BorderSize = 0;
            this.btn_siparis_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siparis_ver.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_siparis_ver.IconColor = System.Drawing.Color.Black;
            this.btn_siparis_ver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_siparis_ver.IconSize = 32;
            this.btn_siparis_ver.Location = new System.Drawing.Point(0, 0);
            this.btn_siparis_ver.Name = "btn_siparis_ver";
            this.btn_siparis_ver.Size = new System.Drawing.Size(220, 60);
            this.btn_siparis_ver.TabIndex = 2;
            this.btn_siparis_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_siparis_ver.UseVisualStyleBackColor = true;
            // 
            // uc_kullanici_siparis_ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_siparis_ver);
            this.Name = "uc_kullanici_siparis_ver";
            this.Size = new System.Drawing.Size(220, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btn_siparis_ver;
    }
}
