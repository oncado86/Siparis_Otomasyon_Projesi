
namespace Siparis_Otomasyon.Ui
{
    partial class uc_kullanici_siparis_ekrani
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
            this.btn_kapida = new FontAwesome.Sharp.IconButton();
            this.btn_odeme_yap = new FontAwesome.Sharp.IconButton();
            this.btn_taksitle = new FontAwesome.Sharp.IconButton();
            this.btn_nakit = new FontAwesome.Sharp.IconButton();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.lbl_toplam_ucret = new System.Windows.Forms.Label();
            this.lbl_taksit = new System.Windows.Forms.Label();
            this.lbl_ekmasraf = new System.Windows.Forms.Label();
            this.cb_taksit = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ekmasraf_miktari = new System.Windows.Forms.Label();
            this.lbl_toplam_ucret_miktari = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapida
            // 
            this.btn_kapida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapida.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_kapida.IconColor = System.Drawing.Color.Black;
            this.btn_kapida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_kapida.IconSize = 42;
            this.btn_kapida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kapida.Location = new System.Drawing.Point(252, 198);
            this.btn_kapida.Name = "btn_kapida";
            this.btn_kapida.Size = new System.Drawing.Size(150, 50);
            this.btn_kapida.TabIndex = 0;
            this.btn_kapida.Text = "Kapıda Öde";
            this.btn_kapida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapida.UseVisualStyleBackColor = true;
            this.btn_kapida.Click += new System.EventHandler(this.btn_kapida_Click);
            // 
            // btn_odeme_yap
            // 
            this.btn_odeme_yap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_odeme_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_odeme_yap.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            this.btn_odeme_yap.IconColor = System.Drawing.Color.Black;
            this.btn_odeme_yap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_odeme_yap.IconSize = 42;
            this.btn_odeme_yap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_odeme_yap.Location = new System.Drawing.Point(197, 471);
            this.btn_odeme_yap.Name = "btn_odeme_yap";
            this.btn_odeme_yap.Size = new System.Drawing.Size(261, 50);
            this.btn_odeme_yap.TabIndex = 0;
            this.btn_odeme_yap.Text = "Ödeme Yap";
            this.btn_odeme_yap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_odeme_yap.UseVisualStyleBackColor = true;
            this.btn_odeme_yap.Visible = false;
            this.btn_odeme_yap.Click += new System.EventHandler(this.btn_odeme_yap_Click);
            // 
            // btn_taksitle
            // 
            this.btn_taksitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_taksitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taksitle.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btn_taksitle.IconColor = System.Drawing.Color.Black;
            this.btn_taksitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_taksitle.IconSize = 35;
            this.btn_taksitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taksitle.Location = new System.Drawing.Point(78, 198);
            this.btn_taksitle.Name = "btn_taksitle";
            this.btn_taksitle.Size = new System.Drawing.Size(150, 50);
            this.btn_taksitle.TabIndex = 0;
            this.btn_taksitle.Text = "Taksitle Öde";
            this.btn_taksitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taksitle.UseVisualStyleBackColor = true;
            this.btn_taksitle.Click += new System.EventHandler(this.btn_taksitle_Click);
            // 
            // btn_nakit
            // 
            this.btn_nakit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nakit.IconChar = FontAwesome.Sharp.IconChar.LiraSign;
            this.btn_nakit.IconColor = System.Drawing.Color.Black;
            this.btn_nakit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nakit.IconSize = 35;
            this.btn_nakit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nakit.Location = new System.Drawing.Point(426, 198);
            this.btn_nakit.Name = "btn_nakit";
            this.btn_nakit.Size = new System.Drawing.Size(150, 50);
            this.btn_nakit.TabIndex = 0;
            this.btn_nakit.Text = "Nakit Öde";
            this.btn_nakit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nakit.UseVisualStyleBackColor = true;
            this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi.Location = new System.Drawing.Point(83, 65);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(258, 24);
            this.lbl_bilgi.TabIndex = 1;
            this.lbl_bilgi.Text = "Lüfen bir ödeme türü seçiniz..";
            // 
            // lbl_toplam_ucret
            // 
            this.lbl_toplam_ucret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_toplam_ucret.AutoSize = true;
            this.lbl_toplam_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_ucret.Location = new System.Drawing.Point(226, 404);
            this.lbl_toplam_ucret.Name = "lbl_toplam_ucret";
            this.lbl_toplam_ucret.Size = new System.Drawing.Size(90, 16);
            this.lbl_toplam_ucret.TabIndex = 3;
            this.lbl_toplam_ucret.Text = "Toplam Ücret";
            this.lbl_toplam_ucret.Visible = false;
            // 
            // lbl_taksit
            // 
            this.lbl_taksit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_taksit.AutoSize = true;
            this.lbl_taksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_taksit.Location = new System.Drawing.Point(226, 306);
            this.lbl_taksit.Name = "lbl_taksit";
            this.lbl_taksit.Size = new System.Drawing.Size(45, 16);
            this.lbl_taksit.TabIndex = 4;
            this.lbl_taksit.Text = "Taksit";
            this.lbl_taksit.Visible = false;
            // 
            // lbl_ekmasraf
            // 
            this.lbl_ekmasraf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ekmasraf.AutoSize = true;
            this.lbl_ekmasraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekmasraf.Location = new System.Drawing.Point(226, 355);
            this.lbl_ekmasraf.Name = "lbl_ekmasraf";
            this.lbl_ekmasraf.Size = new System.Drawing.Size(83, 16);
            this.lbl_ekmasraf.TabIndex = 4;
            this.lbl_ekmasraf.Text = "Ek masraflar";
            this.lbl_ekmasraf.Visible = false;
            // 
            // cb_taksit
            // 
            this.cb_taksit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_taksit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_taksit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_taksit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_taksit.FormattingEnabled = true;
            this.cb_taksit.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_taksit.Location = new System.Drawing.Point(330, 303);
            this.cb_taksit.Name = "cb_taksit";
            this.cb_taksit.Size = new System.Drawing.Size(99, 24);
            this.cb_taksit.TabIndex = 5;
            this.cb_taksit.Visible = false;
            this.cb_taksit.SelectedIndexChanged += new System.EventHandler(this.cb_taksit_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 600);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_kapida);
            this.groupBox1.Controls.Add(this.cb_taksit);
            this.groupBox1.Controls.Add(this.btn_odeme_yap);
            this.groupBox1.Controls.Add(this.lbl_ekmasraf_miktari);
            this.groupBox1.Controls.Add(this.lbl_ekmasraf);
            this.groupBox1.Controls.Add(this.btn_taksitle);
            this.groupBox1.Controls.Add(this.lbl_taksit);
            this.groupBox1.Controls.Add(this.btn_nakit);
            this.groupBox1.Controls.Add(this.lbl_toplam_ucret_miktari);
            this.groupBox1.Controls.Add(this.lbl_toplam_ucret);
            this.groupBox1.Controls.Add(this.lbl_bilgi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 594);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ekmasraf_miktari
            // 
            this.lbl_ekmasraf_miktari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ekmasraf_miktari.AutoSize = true;
            this.lbl_ekmasraf_miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekmasraf_miktari.Location = new System.Drawing.Point(330, 355);
            this.lbl_ekmasraf_miktari.Name = "lbl_ekmasraf_miktari";
            this.lbl_ekmasraf_miktari.Size = new System.Drawing.Size(77, 16);
            this.lbl_ekmasraf_miktari.TabIndex = 4;
            this.lbl_ekmasraf_miktari.Text = "Ek masraf";
            this.lbl_ekmasraf_miktari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ekmasraf_miktari.Visible = false;
            // 
            // lbl_toplam_ucret_miktari
            // 
            this.lbl_toplam_ucret_miktari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_toplam_ucret_miktari.AutoSize = true;
            this.lbl_toplam_ucret_miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_ucret_miktari.Location = new System.Drawing.Point(330, 404);
            this.lbl_toplam_ucret_miktari.Name = "lbl_toplam_ucret_miktari";
            this.lbl_toplam_ucret_miktari.Size = new System.Drawing.Size(102, 16);
            this.lbl_toplam_ucret_miktari.TabIndex = 3;
            this.lbl_toplam_ucret_miktari.Text = "Toplam Ücret";
            this.lbl_toplam_ucret_miktari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_toplam_ucret_miktari.Visible = false;
            // 
            // uc_kullanici_siparis_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_kullanici_siparis_ekrani";
            this.Size = new System.Drawing.Size(660, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public FontAwesome.Sharp.IconButton btn_kapida;
        public FontAwesome.Sharp.IconButton btn_odeme_yap;
        public FontAwesome.Sharp.IconButton btn_taksitle;
        public FontAwesome.Sharp.IconButton btn_nakit;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.Label lbl_toplam_ucret;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_toplam_ucret_miktari;
        public System.Windows.Forms.Label lbl_taksit;
        public System.Windows.Forms.Label lbl_ekmasraf;
        public System.Windows.Forms.ComboBox cb_taksit;
        public System.Windows.Forms.Label lbl_ekmasraf_miktari;
    }
}
