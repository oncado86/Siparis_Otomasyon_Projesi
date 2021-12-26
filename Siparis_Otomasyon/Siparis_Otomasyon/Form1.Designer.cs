
namespace Siparis_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_sol = new System.Windows.Forms.Panel();
            this.pnl_sol_alt = new System.Windows.Forms.Panel();
            this.btn_sol_panel_menu = new FontAwesome.Sharp.IconButton();
            this.pnl_sol_menu = new System.Windows.Forms.Panel();
            this.pnl_ust = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_giris_yapan_kullanici_adi = new System.Windows.Forms.Label();
            this.pnl_orta = new System.Windows.Forms.Panel();
            this.tmr_sol_ac = new System.Windows.Forms.Timer(this.components);
            this.tmr_sol_kapat = new System.Windows.Forms.Timer(this.components);
            this.pnl_sag = new System.Windows.Forms.Panel();
            this.pnl_sag_alt = new System.Windows.Forms.Panel();
            this.pnl_sag_menu = new System.Windows.Forms.Panel();
            this.btn_sag_panel_menu = new FontAwesome.Sharp.IconButton();
            this.tmr_sag_kapat = new System.Windows.Forms.Timer(this.components);
            this.tmr_sag_ac = new System.Windows.Forms.Timer(this.components);
            this.tmr_acilis = new System.Windows.Forms.Timer(this.components);
            this.pnl_sol.SuspendLayout();
            this.pnl_ust.SuspendLayout();
            this.pnl_sag.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sol
            // 
            this.pnl_sol.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_sol.Controls.Add(this.pnl_sol_alt);
            this.pnl_sol.Controls.Add(this.btn_sol_panel_menu);
            this.pnl_sol.Controls.Add(this.pnl_sol_menu);
            this.pnl_sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sol.Location = new System.Drawing.Point(0, 60);
            this.pnl_sol.Name = "pnl_sol";
            this.pnl_sol.Size = new System.Drawing.Size(220, 612);
            this.pnl_sol.TabIndex = 1;
            // 
            // pnl_sol_alt
            // 
            this.pnl_sol_alt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_sol_alt.Location = new System.Drawing.Point(0, 544);
            this.pnl_sol_alt.Name = "pnl_sol_alt";
            this.pnl_sol_alt.Size = new System.Drawing.Size(220, 60);
            this.pnl_sol_alt.TabIndex = 3;
            // 
            // btn_sol_panel_menu
            // 
            this.btn_sol_panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sol_panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_sol_panel_menu.FlatAppearance.BorderSize = 0;
            this.btn_sol_panel_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sol_panel_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sol_panel_menu.IconChar = FontAwesome.Sharp.IconChar.Empire;
            this.btn_sol_panel_menu.IconColor = System.Drawing.Color.Black;
            this.btn_sol_panel_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sol_panel_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sol_panel_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_sol_panel_menu.Name = "btn_sol_panel_menu";
            this.btn_sol_panel_menu.Size = new System.Drawing.Size(220, 60);
            this.btn_sol_panel_menu.TabIndex = 2;
            this.btn_sol_panel_menu.Text = "Car Wars";
            this.btn_sol_panel_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sol_panel_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sol_panel_menu.UseVisualStyleBackColor = false;
            this.btn_sol_panel_menu.Click += new System.EventHandler(this.btn_sol_panel_menu_Click);
            // 
            // pnl_sol_menu
            // 
            this.pnl_sol_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_sol_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sol_menu.Location = new System.Drawing.Point(0, 60);
            this.pnl_sol_menu.Name = "pnl_sol_menu";
            this.pnl_sol_menu.Size = new System.Drawing.Size(220, 400);
            this.pnl_sol_menu.TabIndex = 1;
            // 
            // pnl_ust
            // 
            this.pnl_ust.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_ust.Controls.Add(this.label1);
            this.pnl_ust.Controls.Add(this.lbl_giris_yapan_kullanici_adi);
            this.pnl_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ust.Location = new System.Drawing.Point(0, 0);
            this.pnl_ust.Name = "pnl_ust";
            this.pnl_ust.Size = new System.Drawing.Size(1084, 60);
            this.pnl_ust.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(750, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "May the Force be with you!";
            // 
            // lbl_giris_yapan_kullanici_adi
            // 
            this.lbl_giris_yapan_kullanici_adi.AutoSize = true;
            this.lbl_giris_yapan_kullanici_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_yapan_kullanici_adi.Location = new System.Drawing.Point(39, 18);
            this.lbl_giris_yapan_kullanici_adi.Name = "lbl_giris_yapan_kullanici_adi";
            this.lbl_giris_yapan_kullanici_adi.Size = new System.Drawing.Size(125, 25);
            this.lbl_giris_yapan_kullanici_adi.TabIndex = 0;
            this.lbl_giris_yapan_kullanici_adi.Text = "_kullanıcı_";
            // 
            // pnl_orta
            // 
            this.pnl_orta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_orta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_orta.Location = new System.Drawing.Point(220, 60);
            this.pnl_orta.Name = "pnl_orta";
            this.pnl_orta.Size = new System.Drawing.Size(822, 612);
            this.pnl_orta.TabIndex = 3;
            // 
            // tmr_sol_ac
            // 
            this.tmr_sol_ac.Interval = 1;
            this.tmr_sol_ac.Tick += new System.EventHandler(this.tmr_sol_ac_Tick);
            // 
            // tmr_sol_kapat
            // 
            this.tmr_sol_kapat.Interval = 1;
            this.tmr_sol_kapat.Tick += new System.EventHandler(this.tmr_sol_kapat_Tick);
            // 
            // pnl_sag
            // 
            this.pnl_sag.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_sag.Controls.Add(this.pnl_sag_alt);
            this.pnl_sag.Controls.Add(this.pnl_sag_menu);
            this.pnl_sag.Controls.Add(this.btn_sag_panel_menu);
            this.pnl_sag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sag.Location = new System.Drawing.Point(1042, 60);
            this.pnl_sag.Name = "pnl_sag";
            this.pnl_sag.Size = new System.Drawing.Size(42, 612);
            this.pnl_sag.TabIndex = 4;
            // 
            // pnl_sag_alt
            // 
            this.pnl_sag_alt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_sag_alt.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sag_alt.Location = new System.Drawing.Point(0, 545);
            this.pnl_sag_alt.Name = "pnl_sag_alt";
            this.pnl_sag_alt.Size = new System.Drawing.Size(220, 60);
            this.pnl_sag_alt.TabIndex = 5;
            // 
            // pnl_sag_menu
            // 
            this.pnl_sag_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sag_menu.Location = new System.Drawing.Point(0, 60);
            this.pnl_sag_menu.Name = "pnl_sag_menu";
            this.pnl_sag_menu.Size = new System.Drawing.Size(220, 450);
            this.pnl_sag_menu.TabIndex = 4;
            // 
            // btn_sag_panel_menu
            // 
            this.btn_sag_panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_sag_panel_menu.FlatAppearance.BorderSize = 0;
            this.btn_sag_panel_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sag_panel_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sag_panel_menu.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btn_sag_panel_menu.IconColor = System.Drawing.Color.Black;
            this.btn_sag_panel_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sag_panel_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sag_panel_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_sag_panel_menu.Name = "btn_sag_panel_menu";
            this.btn_sag_panel_menu.Size = new System.Drawing.Size(220, 60);
            this.btn_sag_panel_menu.TabIndex = 3;
            this.btn_sag_panel_menu.Text = "Detaylar";
            this.btn_sag_panel_menu.UseVisualStyleBackColor = false;
            this.btn_sag_panel_menu.Click += new System.EventHandler(this.btn_sag_panel_menu_Click);
            // 
            // tmr_sag_kapat
            // 
            this.tmr_sag_kapat.Interval = 1;
            this.tmr_sag_kapat.Tick += new System.EventHandler(this.tmr_sag_kapat_Tick);
            // 
            // tmr_sag_ac
            // 
            this.tmr_sag_ac.Interval = 1;
            this.tmr_sag_ac.Tick += new System.EventHandler(this.tmr_sag_ac_Tick);
            // 
            // tmr_acilis
            // 
            this.tmr_acilis.Interval = 1;
            this.tmr_acilis.Tick += new System.EventHandler(this.tmr_acilis_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.pnl_orta);
            this.Controls.Add(this.pnl_sag);
            this.Controls.Add(this.pnl_sol);
            this.Controls.Add(this.pnl_ust);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is the way!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_sol.ResumeLayout(false);
            this.pnl_ust.ResumeLayout(false);
            this.pnl_ust.PerformLayout();
            this.pnl_sag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sol;
        private System.Windows.Forms.Panel pnl_ust;
        private System.Windows.Forms.Timer tmr_sol_ac;
        private System.Windows.Forms.Timer tmr_sol_kapat;
        private System.Windows.Forms.Panel pnl_sag;
        private System.Windows.Forms.Label lbl_giris_yapan_kullanici_adi;
        private System.Windows.Forms.Panel pnl_sol_menu;
        private System.Windows.Forms.Timer tmr_sag_ac;
        private System.Windows.Forms.Timer tmr_acilis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_sag_alt;
        private FontAwesome.Sharp.IconButton btn_sol_panel_menu;
        private FontAwesome.Sharp.IconButton btn_sag_panel_menu;
        private System.Windows.Forms.Panel pnl_sol_alt;
        public System.Windows.Forms.Panel pnl_sag_menu;
        public System.Windows.Forms.Panel pnl_orta;
        public System.Windows.Forms.Timer tmr_sag_kapat;
    }
}