
namespace Siparis_Otomasyon.Ui
{
    partial class uc_kullanici_hesap_bilgileri
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_hesap_bilgileri = new System.Windows.Forms.GroupBox();
            this.mtxt_guncel_telefon = new System.Windows.Forms.MaskedTextBox();
            this.cb_ilce = new System.Windows.Forms.ComboBox();
            this.cb_il = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_bilgi_guncelle = new FontAwesome.Sharp.IconButton();
            this.txt_guncel__kod = new System.Windows.Forms.TextBox();
            this.txt_guncel_sifretekrar = new System.Windows.Forms.TextBox();
            this.txt_guncel_sifre = new System.Windows.Forms.TextBox();
            this.txt_guncel_adres = new System.Windows.Forms.TextBox();
            this.txt_guncel_mail = new System.Windows.Forms.TextBox();
            this.txt_guncel_soyad = new System.Windows.Forms.TextBox();
            this.txt_guncel_ad = new System.Windows.Forms.TextBox();
            this.lbl_kayit_kod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_hesap_bilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gb_hesap_bilgileri, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 359);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gb_hesap_bilgileri
            // 
            this.gb_hesap_bilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_hesap_bilgileri.Controls.Add(this.mtxt_guncel_telefon);
            this.gb_hesap_bilgileri.Controls.Add(this.cb_ilce);
            this.gb_hesap_bilgileri.Controls.Add(this.cb_il);
            this.gb_hesap_bilgileri.Controls.Add(this.label10);
            this.gb_hesap_bilgileri.Controls.Add(this.label9);
            this.gb_hesap_bilgileri.Controls.Add(this.btn_bilgi_guncelle);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel__kod);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_sifretekrar);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_sifre);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_adres);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_mail);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_soyad);
            this.gb_hesap_bilgileri.Controls.Add(this.txt_guncel_ad);
            this.gb_hesap_bilgileri.Controls.Add(this.lbl_kayit_kod);
            this.gb_hesap_bilgileri.Controls.Add(this.label7);
            this.gb_hesap_bilgileri.Controls.Add(this.label6);
            this.gb_hesap_bilgileri.Controls.Add(this.label5);
            this.gb_hesap_bilgileri.Controls.Add(this.label4);
            this.gb_hesap_bilgileri.Controls.Add(this.label11);
            this.gb_hesap_bilgileri.Controls.Add(this.label3);
            this.gb_hesap_bilgileri.Controls.Add(this.label2);
            this.gb_hesap_bilgileri.Controls.Add(this.label1);
            this.gb_hesap_bilgileri.Location = new System.Drawing.Point(3, 3);
            this.gb_hesap_bilgileri.Name = "gb_hesap_bilgileri";
            this.gb_hesap_bilgileri.Size = new System.Drawing.Size(572, 353);
            this.gb_hesap_bilgileri.TabIndex = 0;
            this.gb_hesap_bilgileri.TabStop = false;
            this.gb_hesap_bilgileri.Text = "Hesap Bilgileri";
            // 
            // mtxt_guncel_telefon
            // 
            this.mtxt_guncel_telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxt_guncel_telefon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtxt_guncel_telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_guncel_telefon.Location = new System.Drawing.Point(187, 201);
            this.mtxt_guncel_telefon.Mask = "(999) 000-00-00";
            this.mtxt_guncel_telefon.Name = "mtxt_guncel_telefon";
            this.mtxt_guncel_telefon.Size = new System.Drawing.Size(100, 20);
            this.mtxt_guncel_telefon.TabIndex = 6;
            this.mtxt_guncel_telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_ilce
            // 
            this.cb_ilce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_ilce.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ilce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_ilce.FormattingEnabled = true;
            this.cb_ilce.ItemHeight = 13;
            this.cb_ilce.Location = new System.Drawing.Point(357, 65);
            this.cb_ilce.Name = "cb_ilce";
            this.cb_ilce.Size = new System.Drawing.Size(102, 21);
            this.cb_ilce.TabIndex = 8;
            // 
            // cb_il
            // 
            this.cb_il.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_il.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_il.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_il.FormattingEnabled = true;
            this.cb_il.ItemHeight = 13;
            this.cb_il.Location = new System.Drawing.Point(357, 36);
            this.cb_il.Name = "cb_il";
            this.cb_il.Size = new System.Drawing.Size(102, 21);
            this.cb_il.TabIndex = 7;
            this.cb_il.SelectedIndexChanged += new System.EventHandler(this.cb_il_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "İlçe";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "İl";
            // 
            // btn_bilgi_guncelle
            // 
            this.btn_bilgi_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bilgi_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bilgi_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgi_guncelle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_bilgi_guncelle.IconColor = System.Drawing.Color.Black;
            this.btn_bilgi_guncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_bilgi_guncelle.IconSize = 30;
            this.btn_bilgi_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bilgi_guncelle.Location = new System.Drawing.Point(115, 287);
            this.btn_bilgi_guncelle.Name = "btn_bilgi_guncelle";
            this.btn_bilgi_guncelle.Size = new System.Drawing.Size(342, 39);
            this.btn_bilgi_guncelle.TabIndex = 11;
            this.btn_bilgi_guncelle.Text = "Kaydet";
            this.btn_bilgi_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bilgi_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_bilgi_guncelle.UseVisualStyleBackColor = true;
            this.btn_bilgi_guncelle.Click += new System.EventHandler(this.btn_bilgi_guncelle_Click);
            // 
            // txt_guncel__kod
            // 
            this.txt_guncel__kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel__kod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel__kod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel__kod.Location = new System.Drawing.Point(305, 239);
            this.txt_guncel__kod.Name = "txt_guncel__kod";
            this.txt_guncel__kod.Size = new System.Drawing.Size(154, 20);
            this.txt_guncel__kod.TabIndex = 10;
            this.txt_guncel__kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_sifretekrar
            // 
            this.txt_guncel_sifretekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_sifretekrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_sifretekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_sifretekrar.Location = new System.Drawing.Point(187, 168);
            this.txt_guncel_sifretekrar.Name = "txt_guncel_sifretekrar";
            this.txt_guncel_sifretekrar.PasswordChar = '*';
            this.txt_guncel_sifretekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_sifretekrar.TabIndex = 5;
            this.txt_guncel_sifretekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_sifre
            // 
            this.txt_guncel_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_sifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_sifre.Location = new System.Drawing.Point(187, 135);
            this.txt_guncel_sifre.Name = "txt_guncel_sifre";
            this.txt_guncel_sifre.PasswordChar = '*';
            this.txt_guncel_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_sifre.TabIndex = 4;
            this.txt_guncel_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_adres
            // 
            this.txt_guncel_adres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_adres.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_adres.Location = new System.Drawing.Point(302, 134);
            this.txt_guncel_adres.Multiline = true;
            this.txt_guncel_adres.Name = "txt_guncel_adres";
            this.txt_guncel_adres.Size = new System.Drawing.Size(154, 84);
            this.txt_guncel_adres.TabIndex = 9;
            this.txt_guncel_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_mail
            // 
            this.txt_guncel_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_mail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_mail.Location = new System.Drawing.Point(187, 102);
            this.txt_guncel_mail.Name = "txt_guncel_mail";
            this.txt_guncel_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_mail.TabIndex = 3;
            this.txt_guncel_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_soyad
            // 
            this.txt_guncel_soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_soyad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_soyad.Location = new System.Drawing.Point(187, 69);
            this.txt_guncel_soyad.Name = "txt_guncel_soyad";
            this.txt_guncel_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_soyad.TabIndex = 2;
            this.txt_guncel_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_guncel_ad
            // 
            this.txt_guncel_ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_guncel_ad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_ad.Location = new System.Drawing.Point(187, 36);
            this.txt_guncel_ad.Name = "txt_guncel_ad";
            this.txt_guncel_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_ad.TabIndex = 1;
            this.txt_guncel_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_kayit_kod
            // 
            this.lbl_kayit_kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kayit_kod.AutoSize = true;
            this.lbl_kayit_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_kod.Location = new System.Drawing.Point(230, 242);
            this.lbl_kayit_kod.Name = "lbl_kayit_kod";
            this.lbl_kayit_kod.Size = new System.Drawing.Size(50, 16);
            this.lbl_kayit_kod.TabIndex = 0;
            this.lbl_kayit_kod.Text = "_kod_";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Kodu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre Tekrar";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adres";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eposta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // uc_kullanici_hesap_bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_kullanici_hesap_bilgileri";
            this.Size = new System.Drawing.Size(578, 359);
            this.Load += new System.EventHandler(this.uc_kullanici_hesap_bilgileri_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_hesap_bilgileri.ResumeLayout(false);
            this.gb_hesap_bilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_hesap_bilgileri;
        public System.Windows.Forms.ComboBox cb_ilce;
        public System.Windows.Forms.ComboBox cb_il;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public FontAwesome.Sharp.IconButton btn_bilgi_guncelle;
        public System.Windows.Forms.TextBox txt_guncel__kod;
        public System.Windows.Forms.TextBox txt_guncel_sifretekrar;
        public System.Windows.Forms.TextBox txt_guncel_sifre;
        public System.Windows.Forms.TextBox txt_guncel_adres;
        public System.Windows.Forms.TextBox txt_guncel_mail;
        public System.Windows.Forms.TextBox txt_guncel_soyad;
        public System.Windows.Forms.TextBox txt_guncel_ad;
        public System.Windows.Forms.Label lbl_kayit_kod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mtxt_guncel_telefon;
    }
}
