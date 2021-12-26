
namespace Siparis_Otomasyon.Ui
{
    partial class uc_giris
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
            this.gb_kayit_ol = new System.Windows.Forms.GroupBox();
            this.mtxt_kayit_telefon = new System.Windows.Forms.MaskedTextBox();
            this.cb_ilce = new System.Windows.Forms.ComboBox();
            this.cb_il = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kayit_ol = new FontAwesome.Sharp.IconButton();
            this.txt_kayit_kod = new System.Windows.Forms.TextBox();
            this.txt_kayit_sifretekrar = new System.Windows.Forms.TextBox();
            this.txt_kayit_sifre = new System.Windows.Forms.TextBox();
            this.txt_kayit_adres = new System.Windows.Forms.TextBox();
            this.txt_kayit_mail = new System.Windows.Forms.TextBox();
            this.txt_kayit_soyad = new System.Windows.Forms.TextBox();
            this.txt_kayit_ad = new System.Windows.Forms.TextBox();
            this.lbl_kayit_kod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_giris = new FontAwesome.Sharp.IconButton();
            this.txt_giris_kod = new System.Windows.Forms.TextBox();
            this.txt_giris_sifre = new System.Windows.Forms.TextBox();
            this.txt_giris_posta = new System.Windows.Forms.TextBox();
            this.lbl_giris_kod = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_kayit_ol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_kayit_ol
            // 
            this.gb_kayit_ol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_kayit_ol.Controls.Add(this.mtxt_kayit_telefon);
            this.gb_kayit_ol.Controls.Add(this.cb_ilce);
            this.gb_kayit_ol.Controls.Add(this.cb_il);
            this.gb_kayit_ol.Controls.Add(this.label10);
            this.gb_kayit_ol.Controls.Add(this.label9);
            this.gb_kayit_ol.Controls.Add(this.btn_kayit_ol);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_kod);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_sifretekrar);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_sifre);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_adres);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_mail);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_soyad);
            this.gb_kayit_ol.Controls.Add(this.txt_kayit_ad);
            this.gb_kayit_ol.Controls.Add(this.lbl_kayit_kod);
            this.gb_kayit_ol.Controls.Add(this.label7);
            this.gb_kayit_ol.Controls.Add(this.label6);
            this.gb_kayit_ol.Controls.Add(this.label5);
            this.gb_kayit_ol.Controls.Add(this.label4);
            this.gb_kayit_ol.Controls.Add(this.label11);
            this.gb_kayit_ol.Controls.Add(this.label3);
            this.gb_kayit_ol.Controls.Add(this.label2);
            this.gb_kayit_ol.Controls.Add(this.label1);
            this.gb_kayit_ol.Location = new System.Drawing.Point(3, 3);
            this.gb_kayit_ol.Name = "gb_kayit_ol";
            this.gb_kayit_ol.Size = new System.Drawing.Size(381, 347);
            this.gb_kayit_ol.TabIndex = 0;
            this.gb_kayit_ol.TabStop = false;
            this.gb_kayit_ol.Text = "Kayıt Ol";
            // 
            // mtxt_kayit_telefon
            // 
            this.mtxt_kayit_telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxt_kayit_telefon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtxt_kayit_telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_kayit_telefon.Location = new System.Drawing.Point(91, 198);
            this.mtxt_kayit_telefon.Mask = "(999) 000-00-00";
            this.mtxt_kayit_telefon.Name = "mtxt_kayit_telefon";
            this.mtxt_kayit_telefon.Size = new System.Drawing.Size(100, 20);
            this.mtxt_kayit_telefon.TabIndex = 10;
            this.mtxt_kayit_telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_ilce
            // 
            this.cb_ilce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_ilce.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ilce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_ilce.FormattingEnabled = true;
            this.cb_ilce.ItemHeight = 13;
            this.cb_ilce.Location = new System.Drawing.Point(261, 62);
            this.cb_ilce.Name = "cb_ilce";
            this.cb_ilce.Size = new System.Drawing.Size(102, 21);
            this.cb_ilce.TabIndex = 12;
            // 
            // cb_il
            // 
            this.cb_il.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_il.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_il.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_il.FormattingEnabled = true;
            this.cb_il.ItemHeight = 13;
            this.cb_il.Location = new System.Drawing.Point(261, 33);
            this.cb_il.Name = "cb_il";
            this.cb_il.Size = new System.Drawing.Size(102, 21);
            this.cb_il.TabIndex = 11;
            this.cb_il.SelectedIndexChanged += new System.EventHandler(this.cb_il_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "İlçe";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "İl";
            // 
            // btn_kayit_ol
            // 
            this.btn_kayit_ol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kayit_ol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit_ol.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_kayit_ol.IconColor = System.Drawing.Color.Black;
            this.btn_kayit_ol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_kayit_ol.IconSize = 30;
            this.btn_kayit_ol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayit_ol.Location = new System.Drawing.Point(18, 284);
            this.btn_kayit_ol.Name = "btn_kayit_ol";
            this.btn_kayit_ol.Size = new System.Drawing.Size(342, 39);
            this.btn_kayit_ol.TabIndex = 15;
            this.btn_kayit_ol.Text = "Kayıt Ol";
            this.btn_kayit_ol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayit_ol.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_kayit_ol.UseVisualStyleBackColor = true;
            this.btn_kayit_ol.Click += new System.EventHandler(this.btn_kayit_ol_Click);
            // 
            // txt_kayit_kod
            // 
            this.txt_kayit_kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_kod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_kod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_kod.Location = new System.Drawing.Point(209, 236);
            this.txt_kayit_kod.Name = "txt_kayit_kod";
            this.txt_kayit_kod.Size = new System.Drawing.Size(154, 20);
            this.txt_kayit_kod.TabIndex = 14;
            this.txt_kayit_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kayit_sifretekrar
            // 
            this.txt_kayit_sifretekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_sifretekrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_sifretekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_sifretekrar.Location = new System.Drawing.Point(91, 165);
            this.txt_kayit_sifretekrar.Name = "txt_kayit_sifretekrar";
            this.txt_kayit_sifretekrar.PasswordChar = '*';
            this.txt_kayit_sifretekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_kayit_sifretekrar.TabIndex = 9;
            this.txt_kayit_sifretekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kayit_sifre
            // 
            this.txt_kayit_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_sifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_sifre.Location = new System.Drawing.Point(91, 132);
            this.txt_kayit_sifre.Name = "txt_kayit_sifre";
            this.txt_kayit_sifre.PasswordChar = '*';
            this.txt_kayit_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_kayit_sifre.TabIndex = 8;
            this.txt_kayit_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kayit_adres
            // 
            this.txt_kayit_adres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_adres.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_adres.Location = new System.Drawing.Point(206, 131);
            this.txt_kayit_adres.Multiline = true;
            this.txt_kayit_adres.Name = "txt_kayit_adres";
            this.txt_kayit_adres.Size = new System.Drawing.Size(154, 84);
            this.txt_kayit_adres.TabIndex = 13;
            // 
            // txt_kayit_mail
            // 
            this.txt_kayit_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_mail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_mail.Location = new System.Drawing.Point(91, 99);
            this.txt_kayit_mail.Name = "txt_kayit_mail";
            this.txt_kayit_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_kayit_mail.TabIndex = 7;
            this.txt_kayit_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kayit_soyad
            // 
            this.txt_kayit_soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_soyad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_soyad.Location = new System.Drawing.Point(91, 66);
            this.txt_kayit_soyad.Name = "txt_kayit_soyad";
            this.txt_kayit_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_kayit_soyad.TabIndex = 6;
            this.txt_kayit_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kayit_ad
            // 
            this.txt_kayit_ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kayit_ad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kayit_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kayit_ad.Location = new System.Drawing.Point(91, 33);
            this.txt_kayit_ad.Name = "txt_kayit_ad";
            this.txt_kayit_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_kayit_ad.TabIndex = 5;
            this.txt_kayit_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_kayit_kod
            // 
            this.lbl_kayit_kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kayit_kod.AutoSize = true;
            this.lbl_kayit_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_kod.Location = new System.Drawing.Point(134, 239);
            this.lbl_kayit_kod.Name = "lbl_kayit_kod";
            this.lbl_kayit_kod.Size = new System.Drawing.Size(50, 16);
            this.lbl_kayit_kod.TabIndex = 0;
            this.lbl_kayit_kod.Text = "_kod_";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Kodu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre Tekrar";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adres";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eposta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.txt_giris_kod);
            this.groupBox1.Controls.Add(this.txt_giris_sifre);
            this.groupBox1.Controls.Add(this.txt_giris_posta);
            this.groupBox1.Controls.Add(this.lbl_giris_kod);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(410, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // btn_giris
            // 
            this.btn_giris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.btn_giris.IconColor = System.Drawing.Color.Black;
            this.btn_giris.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_giris.IconSize = 28;
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.Location = new System.Drawing.Point(19, 284);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(342, 39);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giris.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_giris_kod
            // 
            this.txt_giris_kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_giris_kod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_giris_kod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_giris_kod.Location = new System.Drawing.Point(234, 207);
            this.txt_giris_kod.Name = "txt_giris_kod";
            this.txt_giris_kod.Size = new System.Drawing.Size(67, 20);
            this.txt_giris_kod.TabIndex = 3;
            this.txt_giris_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_giris_sifre
            // 
            this.txt_giris_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_giris_sifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_giris_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_giris_sifre.Location = new System.Drawing.Point(160, 150);
            this.txt_giris_sifre.Name = "txt_giris_sifre";
            this.txt_giris_sifre.PasswordChar = '*';
            this.txt_giris_sifre.Size = new System.Drawing.Size(141, 20);
            this.txt_giris_sifre.TabIndex = 2;
            this.txt_giris_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_giris_posta
            // 
            this.txt_giris_posta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_giris_posta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_giris_posta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_giris_posta.Location = new System.Drawing.Point(160, 117);
            this.txt_giris_posta.Name = "txt_giris_posta";
            this.txt_giris_posta.Size = new System.Drawing.Size(141, 20);
            this.txt_giris_posta.TabIndex = 1;
            this.txt_giris_posta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_giris_kod
            // 
            this.lbl_giris_kod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_giris_kod.AutoSize = true;
            this.lbl_giris_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_kod.Location = new System.Drawing.Point(179, 210);
            this.lbl_giris_kod.Name = "lbl_giris_kod";
            this.lbl_giris_kod.Size = new System.Drawing.Size(50, 16);
            this.lbl_giris_kod.TabIndex = 0;
            this.lbl_giris_kod.Text = "_kod_";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Güvenlik Kodu";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(79, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Şifre";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(79, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Eposta";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gb_kayit_ol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 353);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // uc_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_giris";
            this.Size = new System.Drawing.Size(795, 353);
            this.Load += new System.EventHandler(this.uc_giris_Load);
            this.gb_kayit_ol.ResumeLayout(false);
            this.gb_kayit_ol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_kayit_ol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        public FontAwesome.Sharp.IconButton btn_kayit_ol;
        public System.Windows.Forms.TextBox txt_kayit_sifretekrar;
        public System.Windows.Forms.TextBox txt_kayit_sifre;
        public System.Windows.Forms.TextBox txt_kayit_mail;
        public System.Windows.Forms.TextBox txt_kayit_soyad;
        public System.Windows.Forms.TextBox txt_kayit_ad;
        public System.Windows.Forms.Label lbl_kayit_kod;
        public System.Windows.Forms.ComboBox cb_ilce;
        public System.Windows.Forms.ComboBox cb_il;
        public System.Windows.Forms.TextBox txt_kayit_kod;
        public System.Windows.Forms.TextBox txt_kayit_adres;
        public FontAwesome.Sharp.IconButton btn_giris;
        public System.Windows.Forms.TextBox txt_giris_kod;
        public System.Windows.Forms.TextBox txt_giris_sifre;
        public System.Windows.Forms.TextBox txt_giris_posta;
        public System.Windows.Forms.Label lbl_giris_kod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.MaskedTextBox mtxt_kayit_telefon;
    }
}
