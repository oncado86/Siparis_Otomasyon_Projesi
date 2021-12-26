
namespace Siparis_Otomasyon.Ui
{
    partial class uc_admin_siparisler
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
            this.txt_ = new System.Windows.Forms.TextBox();
            this.dgv_ = new System.Windows.Forms.DataGridView();
            this.cntr_Arama_Liste_ = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_)).BeginInit();
            this.cntr_Arama_Liste_.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_
            // 
            this.txt_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_.Location = new System.Drawing.Point(3, 3);
            this.txt_.MinimumSize = new System.Drawing.Size(4, 50);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(285, 38);
            this.txt_.TabIndex = 0;
            this.txt_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // dgv_
            // 
            this.dgv_.AllowUserToAddRows = false;
            this.dgv_.AllowUserToDeleteRows = false;
            this.dgv_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_.Location = new System.Drawing.Point(3, 53);
            this.dgv_.MinimumSize = new System.Drawing.Size(0, 50);
            this.dgv_.Name = "dgv_";
            this.dgv_.ReadOnly = true;
            this.dgv_.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_.Size = new System.Drawing.Size(285, 252);
            this.dgv_.TabIndex = 1;
            // 
            // cntr_Arama_Liste_
            // 
            this.cntr_Arama_Liste_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntr_Arama_Liste_.ColumnCount = 1;
            this.cntr_Arama_Liste_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cntr_Arama_Liste_.Controls.Add(this.txt_, 0, 0);
            this.cntr_Arama_Liste_.Controls.Add(this.dgv_, 0, 1);
            this.cntr_Arama_Liste_.Location = new System.Drawing.Point(3, 3);
            this.cntr_Arama_Liste_.Name = "cntr_Arama_Liste_";
            this.cntr_Arama_Liste_.RowCount = 2;
            this.cntr_Arama_Liste_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cntr_Arama_Liste_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cntr_Arama_Liste_.Size = new System.Drawing.Size(291, 308);
            this.cntr_Arama_Liste_.TabIndex = 1;
            // 
            // uc_admin_siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cntr_Arama_Liste_);
            this.Name = "uc_admin_siparisler";
            this.Size = new System.Drawing.Size(296, 314);
            this.Load += new System.EventHandler(this.uc_admin_siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_)).EndInit();
            this.cntr_Arama_Liste_.ResumeLayout(false);
            this.cntr_Arama_Liste_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txt_;
        public System.Windows.Forms.DataGridView dgv_;
        public System.Windows.Forms.TableLayoutPanel cntr_Arama_Liste_;
    }
}
