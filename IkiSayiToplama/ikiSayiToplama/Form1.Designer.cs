namespace ikiSayiToplama
{
    partial class frmIkiSayiToplama
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpToplama = new System.Windows.Forms.TabPage();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLoglama = new System.Windows.Forms.TabPage();
            this.lstToplamaLoglama = new System.Windows.Forms.ListView();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tbpToplama.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpLoglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpToplama
            // 
            this.tbpToplama.Controls.Add(this.btnİleri);
            this.tbpToplama.Controls.Add(this.txtBirinciSayi);
            this.tbpToplama.Controls.Add(this.txtToplam);
            this.tbpToplama.Controls.Add(this.txtİkinciSayi);
            this.tbpToplama.Controls.Add(this.btnTopla);
            this.tbpToplama.Controls.Add(this.label1);
            this.tbpToplama.Controls.Add(this.lblİkinciSayi);
            this.tbpToplama.Controls.Add(this.lblToplam);
            this.tbpToplama.Location = new System.Drawing.Point(4, 25);
            this.tbpToplama.Name = "tbpToplama";
            this.tbpToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tbpToplama.Size = new System.Drawing.Size(768, 397);
            this.tbpToplama.TabIndex = 0;
            this.tbpToplama.Text = "Toplama İşlemi";
            this.tbpToplama.UseVisualStyleBackColor = true;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(204, 208);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(55, 17);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam";
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(287, 92);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.ShortcutsEnabled = false;
            this.txtİkinciSayi.Size = new System.Drawing.Size(170, 22);
            this.txtİkinciSayi.TabIndex = 2;
            this.txtİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİkinciSayi_KeyPress);
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(204, 92);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(70, 17);
            this.lblİkinciSayi.TabIndex = 2;
            this.lblİkinciSayi.Text = "İkinci Sayı";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(287, 203);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(170, 22);
            this.txtToplam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci Sayı";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(287, 136);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(170, 44);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(287, 64);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.ShortcutsEnabled = false;
            this.txtBirinciSayi.Size = new System.Drawing.Size(170, 22);
            this.txtBirinciSayi.TabIndex = 1;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpToplama);
            this.tabControl1.Controls.Add(this.tbpLoglama);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpLoglama
            // 
            this.tbpLoglama.Controls.Add(this.btnGeri);
            this.tbpLoglama.Controls.Add(this.lstToplamaLoglama);
            this.tbpLoglama.Location = new System.Drawing.Point(4, 25);
            this.tbpLoglama.Name = "tbpLoglama";
            this.tbpLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoglama.Size = new System.Drawing.Size(768, 397);
            this.tbpLoglama.TabIndex = 1;
            this.tbpLoglama.Text = "Loglar";
            this.tbpLoglama.UseVisualStyleBackColor = true;
            // 
            // lstToplamaLoglama
            // 
            this.lstToplamaLoglama.HideSelection = false;
            this.lstToplamaLoglama.Location = new System.Drawing.Point(0, 3);
            this.lstToplamaLoglama.Name = "lstToplamaLoglama";
            this.lstToplamaLoglama.Size = new System.Drawing.Size(756, 388);
            this.lstToplamaLoglama.TabIndex = 0;
            this.lstToplamaLoglama.UseCompatibleStateImageBehavior = false;
            this.lstToplamaLoglama.View = System.Windows.Forms.View.List;
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(592, 343);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(170, 37);
            this.btnİleri.TabIndex = 4;
            this.btnİleri.Text = "İleri";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(16, 343);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(161, 37);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmIkiSayiToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIkiSayiToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İki Sayı Toplama";
            this.Shown += new System.EventHandler(this.frmIkiSayiToplama_Shown);
            this.tbpToplama.ResumeLayout(false);
            this.tbpToplama.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpLoglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpToplama;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLoglama;
        private System.Windows.Forms.ListView lstToplamaLoglama;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
    }
}

