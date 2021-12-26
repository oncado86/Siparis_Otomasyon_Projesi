
namespace Siparis_Otomasyon.Ui
{
    partial class uc_admin_araba_ekle
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
            this.txt_motor_gucu = new System.Windows.Forms.TextBox();
            this.txt_motor_hacmi = new System.Windows.Forms.TextBox();
            this.cb_cekis_tipi = new System.Windows.Forms.ComboBox();
            this.cb_renk = new System.Windows.Forms.ComboBox();
            this.cb_kasa_tipi = new System.Windows.Forms.ComboBox();
            this.txt_KM = new System.Windows.Forms.TextBox();
            this.cb_yakit_tipi = new System.Windows.Forms.ComboBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.cb_vites_tipi = new System.Windows.Forms.ComboBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.txt_uretim_yili = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_araba_ekle = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_marka = new FontAwesome.Sharp.IconButton();
            this.gb_egs = new System.Windows.Forms.GroupBox();
            this.txt_guncel_bilgi = new System.Windows.Forms.TextBox();
            this.btn_secimi_guncelle = new FontAwesome.Sharp.IconButton();
            this.btn_secimi_sil = new FontAwesome.Sharp.IconButton();
            this.btn_secimi_ekle = new FontAwesome.Sharp.IconButton();
            this.txt_yeni_bilgi = new System.Windows.Forms.TextBox();
            this.txt_eski_bilgi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_model = new FontAwesome.Sharp.IconButton();
            this.btn_vites = new FontAwesome.Sharp.IconButton();
            this.btn_yakit = new FontAwesome.Sharp.IconButton();
            this.btn_kasa = new FontAwesome.Sharp.IconButton();
            this.btn_renk = new FontAwesome.Sharp.IconButton();
            this.btn_cekis = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.gb_egs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_motor_gucu
            // 
            this.txt_motor_gucu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_motor_gucu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_motor_gucu.Location = new System.Drawing.Point(95, 417);
            this.txt_motor_gucu.Name = "txt_motor_gucu";
            this.txt_motor_gucu.Size = new System.Drawing.Size(121, 20);
            this.txt_motor_gucu.TabIndex = 39;
            this.txt_motor_gucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_motor_hacmi
            // 
            this.txt_motor_hacmi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_motor_hacmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_motor_hacmi.Location = new System.Drawing.Point(95, 384);
            this.txt_motor_hacmi.Name = "txt_motor_hacmi";
            this.txt_motor_hacmi.Size = new System.Drawing.Size(121, 20);
            this.txt_motor_hacmi.TabIndex = 38;
            this.txt_motor_hacmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_cekis_tipi
            // 
            this.cb_cekis_tipi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_cekis_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cekis_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cekis_tipi.FormattingEnabled = true;
            this.cb_cekis_tipi.Location = new System.Drawing.Point(95, 350);
            this.cb_cekis_tipi.Name = "cb_cekis_tipi";
            this.cb_cekis_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_cekis_tipi.TabIndex = 37;
            // 
            // cb_renk
            // 
            this.cb_renk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_renk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_renk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_renk.FormattingEnabled = true;
            this.cb_renk.Location = new System.Drawing.Point(95, 316);
            this.cb_renk.Name = "cb_renk";
            this.cb_renk.Size = new System.Drawing.Size(121, 21);
            this.cb_renk.TabIndex = 36;
            // 
            // cb_kasa_tipi
            // 
            this.cb_kasa_tipi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_kasa_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kasa_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_kasa_tipi.FormattingEnabled = true;
            this.cb_kasa_tipi.Location = new System.Drawing.Point(95, 282);
            this.cb_kasa_tipi.Name = "cb_kasa_tipi";
            this.cb_kasa_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_kasa_tipi.TabIndex = 35;
            // 
            // txt_KM
            // 
            this.txt_KM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_KM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KM.Location = new System.Drawing.Point(95, 249);
            this.txt_KM.Name = "txt_KM";
            this.txt_KM.Size = new System.Drawing.Size(121, 20);
            this.txt_KM.TabIndex = 34;
            this.txt_KM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_yakit_tipi
            // 
            this.cb_yakit_tipi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_yakit_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yakit_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_yakit_tipi.FormattingEnabled = true;
            this.cb_yakit_tipi.Location = new System.Drawing.Point(95, 215);
            this.cb_yakit_tipi.Name = "cb_yakit_tipi";
            this.cb_yakit_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_yakit_tipi.TabIndex = 33;
            // 
            // txt_stok
            // 
            this.txt_stok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stok.Location = new System.Drawing.Point(95, 182);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(121, 20);
            this.txt_stok.TabIndex = 32;
            this.txt_stok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(95, 149);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_fiyat.TabIndex = 31;
            this.txt_fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_vites_tipi
            // 
            this.cb_vites_tipi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_vites_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vites_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_vites_tipi.FormattingEnabled = true;
            this.cb_vites_tipi.Location = new System.Drawing.Point(95, 115);
            this.cb_vites_tipi.Name = "cb_vites_tipi";
            this.cb_vites_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_vites_tipi.TabIndex = 30;
            // 
            // cb_model
            // 
            this.cb_model.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(95, 81);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 21);
            this.cb_model.TabIndex = 29;
            // 
            // cb_marka
            // 
            this.cb_marka.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(95, 47);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(121, 21);
            this.cb_marka.TabIndex = 28;
            this.cb_marka.SelectedIndexChanged += new System.EventHandler(this.cb_marka_SelectedIndexChanged);
            // 
            // txt_uretim_yili
            // 
            this.txt_uretim_yili.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_uretim_yili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uretim_yili.Location = new System.Drawing.Point(95, 14);
            this.txt_uretim_yili.Name = "txt_uretim_yili";
            this.txt_uretim_yili.Size = new System.Drawing.Size(121, 20);
            this.txt_uretim_yili.TabIndex = 27;
            this.txt_uretim_yili.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Motor Gücü (HP)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Motor Hacmi (CC)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Çekiş Tipi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Renk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kasa Tipi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Yakıt Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vites Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üretim Yılı";
            // 
            // btn_araba_ekle
            // 
            this.btn_araba_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_araba_ekle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_araba_ekle.IconColor = System.Drawing.Color.Black;
            this.btn_araba_ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_araba_ekle.IconSize = 30;
            this.btn_araba_ekle.Location = new System.Drawing.Point(11, 451);
            this.btn_araba_ekle.Name = "btn_araba_ekle";
            this.btn_araba_ekle.Size = new System.Drawing.Size(205, 39);
            this.btn_araba_ekle.TabIndex = 40;
            this.btn_araba_ekle.Text = "Araba Ekle";
            this.btn_araba_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_araba_ekle.UseVisualStyleBackColor = true;
            this.btn_araba_ekle.Click += new System.EventHandler(this.btn_araba_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_araba_ekle);
            this.groupBox1.Controls.Add(this.txt_motor_gucu);
            this.groupBox1.Controls.Add(this.txt_motor_hacmi);
            this.groupBox1.Controls.Add(this.cb_cekis_tipi);
            this.groupBox1.Controls.Add(this.cb_renk);
            this.groupBox1.Controls.Add(this.cb_kasa_tipi);
            this.groupBox1.Controls.Add(this.txt_KM);
            this.groupBox1.Controls.Add(this.cb_yakit_tipi);
            this.groupBox1.Controls.Add(this.txt_stok);
            this.groupBox1.Controls.Add(this.txt_fiyat);
            this.groupBox1.Controls.Add(this.cb_vites_tipi);
            this.groupBox1.Controls.Add(this.cb_model);
            this.groupBox1.Controls.Add(this.cb_marka);
            this.groupBox1.Controls.Add(this.txt_uretim_yili);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 505);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // btn_marka
            // 
            this.btn_marka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_marka.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_marka.IconColor = System.Drawing.Color.Black;
            this.btn_marka.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_marka.IconSize = 20;
            this.btn_marka.Location = new System.Drawing.Point(309, 98);
            this.btn_marka.Name = "btn_marka";
            this.btn_marka.Size = new System.Drawing.Size(112, 23);
            this.btn_marka.TabIndex = 42;
            this.btn_marka.UseVisualStyleBackColor = true;
            this.btn_marka.Click += new System.EventHandler(this.btn_marka_Click);
            // 
            // gb_egs
            // 
            this.gb_egs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_egs.Controls.Add(this.txt_guncel_bilgi);
            this.gb_egs.Controls.Add(this.btn_secimi_guncelle);
            this.gb_egs.Controls.Add(this.btn_secimi_sil);
            this.gb_egs.Controls.Add(this.btn_secimi_ekle);
            this.gb_egs.Controls.Add(this.txt_yeni_bilgi);
            this.gb_egs.Controls.Add(this.txt_eski_bilgi);
            this.gb_egs.Controls.Add(this.label16);
            this.gb_egs.Controls.Add(this.label15);
            this.gb_egs.Controls.Add(this.label14);
            this.gb_egs.Enabled = false;
            this.gb_egs.Location = new System.Drawing.Point(462, 53);
            this.gb_egs.Name = "gb_egs";
            this.gb_egs.Size = new System.Drawing.Size(327, 490);
            this.gb_egs.TabIndex = 43;
            this.gb_egs.TabStop = false;
            this.gb_egs.Text = "Ekle-Güncelle-Sil";
            // 
            // txt_guncel_bilgi
            // 
            this.txt_guncel_bilgi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_guncel_bilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guncel_bilgi.Location = new System.Drawing.Point(115, 250);
            this.txt_guncel_bilgi.Name = "txt_guncel_bilgi";
            this.txt_guncel_bilgi.Size = new System.Drawing.Size(100, 20);
            this.txt_guncel_bilgi.TabIndex = 1;
            this.txt_guncel_bilgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_secimi_guncelle
            // 
            this.btn_secimi_guncelle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_secimi_guncelle.IconColor = System.Drawing.Color.Black;
            this.btn_secimi_guncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_secimi_guncelle.IconSize = 20;
            this.btn_secimi_guncelle.Location = new System.Drawing.Point(221, 215);
            this.btn_secimi_guncelle.Name = "btn_secimi_guncelle";
            this.btn_secimi_guncelle.Size = new System.Drawing.Size(75, 55);
            this.btn_secimi_guncelle.TabIndex = 42;
            this.btn_secimi_guncelle.UseVisualStyleBackColor = true;
            this.btn_secimi_guncelle.Click += new System.EventHandler(this.btn_secimi_guncelle_Click);
            // 
            // btn_secimi_sil
            // 
            this.btn_secimi_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secimi_sil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_secimi_sil.IconColor = System.Drawing.Color.Black;
            this.btn_secimi_sil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_secimi_sil.Location = new System.Drawing.Point(34, 330);
            this.btn_secimi_sil.Name = "btn_secimi_sil";
            this.btn_secimi_sil.Size = new System.Drawing.Size(262, 41);
            this.btn_secimi_sil.TabIndex = 42;
            this.btn_secimi_sil.Text = "Seçimi Sil";
            this.btn_secimi_sil.UseVisualStyleBackColor = true;
            this.btn_secimi_sil.Click += new System.EventHandler(this.btn_secimi_sil_Click);
            // 
            // btn_secimi_ekle
            // 
            this.btn_secimi_ekle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_secimi_ekle.IconColor = System.Drawing.Color.Black;
            this.btn_secimi_ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_secimi_ekle.IconSize = 20;
            this.btn_secimi_ekle.Location = new System.Drawing.Point(221, 137);
            this.btn_secimi_ekle.Name = "btn_secimi_ekle";
            this.btn_secimi_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_secimi_ekle.TabIndex = 42;
            this.btn_secimi_ekle.UseVisualStyleBackColor = true;
            this.btn_secimi_ekle.Click += new System.EventHandler(this.btn_secimi_ekle_Click);
            // 
            // txt_yeni_bilgi
            // 
            this.txt_yeni_bilgi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_yeni_bilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yeni_bilgi.Location = new System.Drawing.Point(115, 139);
            this.txt_yeni_bilgi.Name = "txt_yeni_bilgi";
            this.txt_yeni_bilgi.Size = new System.Drawing.Size(100, 20);
            this.txt_yeni_bilgi.TabIndex = 1;
            this.txt_yeni_bilgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_eski_bilgi
            // 
            this.txt_eski_bilgi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_eski_bilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_eski_bilgi.Enabled = false;
            this.txt_eski_bilgi.Location = new System.Drawing.Point(115, 215);
            this.txt_eski_bilgi.Name = "txt_eski_bilgi";
            this.txt_eski_bilgi.Size = new System.Drawing.Size(100, 20);
            this.txt_eski_bilgi.TabIndex = 1;
            this.txt_eski_bilgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Eklenecek Bilgi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Güncel Bildi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Eski Bilgi";
            // 
            // btn_model
            // 
            this.btn_model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_model.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_model.IconColor = System.Drawing.Color.Black;
            this.btn_model.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_model.IconSize = 20;
            this.btn_model.Location = new System.Drawing.Point(309, 132);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(112, 23);
            this.btn_model.TabIndex = 42;
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // btn_vites
            // 
            this.btn_vites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_vites.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_vites.IconColor = System.Drawing.Color.Black;
            this.btn_vites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_vites.IconSize = 20;
            this.btn_vites.Location = new System.Drawing.Point(309, 166);
            this.btn_vites.Name = "btn_vites";
            this.btn_vites.Size = new System.Drawing.Size(112, 23);
            this.btn_vites.TabIndex = 42;
            this.btn_vites.UseVisualStyleBackColor = true;
            this.btn_vites.Click += new System.EventHandler(this.btn_vites_Click);
            // 
            // btn_yakit
            // 
            this.btn_yakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_yakit.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_yakit.IconColor = System.Drawing.Color.Black;
            this.btn_yakit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_yakit.IconSize = 20;
            this.btn_yakit.Location = new System.Drawing.Point(309, 266);
            this.btn_yakit.Name = "btn_yakit";
            this.btn_yakit.Size = new System.Drawing.Size(112, 23);
            this.btn_yakit.TabIndex = 42;
            this.btn_yakit.UseVisualStyleBackColor = true;
            this.btn_yakit.Click += new System.EventHandler(this.btn_yakit_Click);
            // 
            // btn_kasa
            // 
            this.btn_kasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kasa.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_kasa.IconColor = System.Drawing.Color.Black;
            this.btn_kasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_kasa.IconSize = 20;
            this.btn_kasa.Location = new System.Drawing.Point(309, 333);
            this.btn_kasa.Name = "btn_kasa";
            this.btn_kasa.Size = new System.Drawing.Size(112, 23);
            this.btn_kasa.TabIndex = 42;
            this.btn_kasa.UseVisualStyleBackColor = true;
            this.btn_kasa.Click += new System.EventHandler(this.btn_kasa_Click);
            // 
            // btn_renk
            // 
            this.btn_renk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_renk.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_renk.IconColor = System.Drawing.Color.Black;
            this.btn_renk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_renk.IconSize = 20;
            this.btn_renk.Location = new System.Drawing.Point(309, 367);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(112, 23);
            this.btn_renk.TabIndex = 42;
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // btn_cekis
            // 
            this.btn_cekis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cekis.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_cekis.IconColor = System.Drawing.Color.Black;
            this.btn_cekis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cekis.IconSize = 20;
            this.btn_cekis.Location = new System.Drawing.Point(309, 401);
            this.btn_cekis.Name = "btn_cekis";
            this.btn_cekis.Size = new System.Drawing.Size(112, 23);
            this.btn_cekis.TabIndex = 42;
            this.btn_cekis.UseVisualStyleBackColor = true;
            this.btn_cekis.Click += new System.EventHandler(this.btn_cekis_Click);
            // 
            // uc_admin_araba_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gb_egs);
            this.Controls.Add(this.btn_cekis);
            this.Controls.Add(this.btn_renk);
            this.Controls.Add(this.btn_kasa);
            this.Controls.Add(this.btn_yakit);
            this.Controls.Add(this.btn_vites);
            this.Controls.Add(this.btn_model);
            this.Controls.Add(this.btn_marka);
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_admin_araba_ekle";
            this.Size = new System.Drawing.Size(830, 610);
            this.Load += new System.EventHandler(this.uc_admin_araba_ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_egs.ResumeLayout(false);
            this.gb_egs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txt_motor_gucu;
        public System.Windows.Forms.TextBox txt_motor_hacmi;
        public System.Windows.Forms.ComboBox cb_cekis_tipi;
        public System.Windows.Forms.ComboBox cb_renk;
        public System.Windows.Forms.ComboBox cb_kasa_tipi;
        public System.Windows.Forms.TextBox txt_KM;
        public System.Windows.Forms.ComboBox cb_yakit_tipi;
        public System.Windows.Forms.TextBox txt_stok;
        public System.Windows.Forms.TextBox txt_fiyat;
        public System.Windows.Forms.ComboBox cb_vites_tipi;
        public System.Windows.Forms.ComboBox cb_model;
        public System.Windows.Forms.ComboBox cb_marka;
        public System.Windows.Forms.TextBox txt_uretim_yili;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public FontAwesome.Sharp.IconButton btn_araba_ekle;
        private FontAwesome.Sharp.IconButton btn_marka;
        private System.Windows.Forms.GroupBox gb_egs;
        private System.Windows.Forms.TextBox txt_guncel_bilgi;
        private FontAwesome.Sharp.IconButton btn_secimi_guncelle;
        private FontAwesome.Sharp.IconButton btn_secimi_sil;
        private FontAwesome.Sharp.IconButton btn_secimi_ekle;
        private System.Windows.Forms.TextBox txt_yeni_bilgi;
        private System.Windows.Forms.TextBox txt_eski_bilgi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btn_model;
        private FontAwesome.Sharp.IconButton btn_vites;
        private FontAwesome.Sharp.IconButton btn_yakit;
        private FontAwesome.Sharp.IconButton btn_kasa;
        private FontAwesome.Sharp.IconButton btn_renk;
        private FontAwesome.Sharp.IconButton btn_cekis;
    }
}
