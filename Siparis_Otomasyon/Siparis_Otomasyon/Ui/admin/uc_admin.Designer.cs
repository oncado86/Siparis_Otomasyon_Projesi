
namespace Siparis_Otomasyon.Ui
{
    partial class uc_admin
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
            this.btn_arama = new FontAwesome.Sharp.IconButton();
            this.btn_arac_ekle = new FontAwesome.Sharp.IconButton();
            this.btn_kullanicilar = new FontAwesome.Sharp.IconButton();
            this.btn_siparisler = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_arama
            // 
            this.btn_arama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_arama.FlatAppearance.BorderSize = 0;
            this.btn_arama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arama.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btn_arama.IconColor = System.Drawing.Color.Black;
            this.btn_arama.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_arama.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_arama.Location = new System.Drawing.Point(0, 0);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(220, 60);
            this.btn_arama.TabIndex = 1;
            this.btn_arama.Text = "Arama";
            this.btn_arama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arama.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_arama.UseVisualStyleBackColor = true;
            // 
            // btn_arac_ekle
            // 
            this.btn_arac_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_arac_ekle.FlatAppearance.BorderSize = 0;
            this.btn_arac_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arac_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arac_ekle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_arac_ekle.IconColor = System.Drawing.Color.Black;
            this.btn_arac_ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_arac_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_arac_ekle.Location = new System.Drawing.Point(0, 60);
            this.btn_arac_ekle.Name = "btn_arac_ekle";
            this.btn_arac_ekle.Size = new System.Drawing.Size(220, 60);
            this.btn_arac_ekle.TabIndex = 2;
            this.btn_arac_ekle.Text = "Araç Ekle";
            this.btn_arac_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arac_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_arac_ekle.UseVisualStyleBackColor = true;
            // 
            // btn_kullanicilar
            // 
            this.btn_kullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kullanicilar.FlatAppearance.BorderSize = 0;
            this.btn_kullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanicilar.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_kullanicilar.IconColor = System.Drawing.Color.Black;
            this.btn_kullanicilar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_kullanicilar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kullanicilar.Location = new System.Drawing.Point(0, 120);
            this.btn_kullanicilar.Name = "btn_kullanicilar";
            this.btn_kullanicilar.Size = new System.Drawing.Size(220, 60);
            this.btn_kullanicilar.TabIndex = 3;
            this.btn_kullanicilar.Text = "Müşteriler";
            this.btn_kullanicilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kullanicilar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_kullanicilar.UseVisualStyleBackColor = true;
            // 
            // btn_siparisler
            // 
            this.btn_siparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siparisler.FlatAppearance.BorderSize = 0;
            this.btn_siparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparisler.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btn_siparisler.IconColor = System.Drawing.Color.Black;
            this.btn_siparisler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_siparisler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_siparisler.Location = new System.Drawing.Point(0, 180);
            this.btn_siparisler.Name = "btn_siparisler";
            this.btn_siparisler.Size = new System.Drawing.Size(220, 60);
            this.btn_siparisler.TabIndex = 4;
            this.btn_siparisler.Text = "Siparişler";
            this.btn_siparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_siparisler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_siparisler.UseVisualStyleBackColor = true;
            // 
            // uc_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_siparisler);
            this.Controls.Add(this.btn_kullanicilar);
            this.Controls.Add(this.btn_arac_ekle);
            this.Controls.Add(this.btn_arama);
            this.Name = "uc_admin";
            this.Size = new System.Drawing.Size(220, 500);
            this.ResumeLayout(false);

        }

        #endregion
        public FontAwesome.Sharp.IconButton btn_arama;
        public FontAwesome.Sharp.IconButton btn_arac_ekle;
        public FontAwesome.Sharp.IconButton btn_kullanicilar;
        public FontAwesome.Sharp.IconButton btn_siparisler;
    }
}
