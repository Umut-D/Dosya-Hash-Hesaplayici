namespace HashHesaplayici
{
    partial class FrmHash
    {
        /// <summary>
        ///Gerekli designer değişkeni.
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
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHash));
            this.gbDosyaAc = new System.Windows.Forms.GroupBox();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.lblDosyaAc = new System.Windows.Forms.Label();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.lblSha1 = new System.Windows.Forms.Label();
            this.lblMd5 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.txtKarsilastir = new System.Windows.Forms.TextBox();
            this.lblKarsilastir = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbDosyaAc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDosyaAc
            // 
            this.gbDosyaAc.Controls.Add(this.btnDosyaAc);
            this.gbDosyaAc.Controls.Add(this.lblDosyaAc);
            this.gbDosyaAc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDosyaAc.Location = new System.Drawing.Point(13, 10);
            this.gbDosyaAc.Name = "gbDosyaAc";
            this.gbDosyaAc.Size = new System.Drawing.Size(486, 104);
            this.gbDosyaAc.TabIndex = 0;
            this.gbDosyaAc.TabStop = false;
            this.gbDosyaAc.Text = "Dosya Aç";
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaAc.Location = new System.Drawing.Point(348, 46);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaAc.TabIndex = 1;
            this.btnDosyaAc.Text = "Dosya Aç";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.BtnDosyaAc_Click);
            // 
            // lblDosyaAc
            // 
            this.lblDosyaAc.AllowDrop = true;
            this.lblDosyaAc.Location = new System.Drawing.Point(7, 18);
            this.lblDosyaAc.Name = "lblDosyaAc";
            this.lblDosyaAc.Size = new System.Drawing.Size(469, 78);
            this.lblDosyaAc.TabIndex = 0;
            this.lblDosyaAc.Text = "                  Dosyanızı bu alanın üzerine sürükleyip bırakın -veya-  ";
            this.lblDosyaAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDosyaAc.DragDrop += new System.Windows.Forms.DragEventHandler(this.LblDosyaAc_DragDrop);
            this.lblDosyaAc.DragEnter += new System.Windows.Forms.DragEventHandler(this.LblDosyaAc_DragEnter);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAdi.Location = new System.Drawing.Point(22, 132);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(64, 15);
            this.lblDosyaAdi.TabIndex = 1;
            this.lblDosyaAdi.Text = "Dosya Adı:";
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAdi.Location = new System.Drawing.Point(92, 129);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.ReadOnly = true;
            this.txtDosyaAdi.Size = new System.Drawing.Size(317, 23);
            this.txtDosyaAdi.TabIndex = 2;
            // 
            // lblSha1
            // 
            this.lblSha1.AutoSize = true;
            this.lblSha1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSha1.Location = new System.Drawing.Point(42, 189);
            this.lblSha1.Name = "lblSha1";
            this.lblSha1.Size = new System.Drawing.Size(44, 15);
            this.lblSha1.TabIndex = 3;
            this.lblSha1.Text = "SHA-1:";
            // 
            // lblMd5
            // 
            this.lblMd5.AutoSize = true;
            this.lblMd5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMd5.Location = new System.Drawing.Point(49, 160);
            this.lblMd5.Name = "lblMd5";
            this.lblMd5.Size = new System.Drawing.Size(37, 15);
            this.lblMd5.TabIndex = 5;
            this.lblMd5.Text = "MD5:";
            // 
            // txtMd5
            // 
            this.txtMd5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMd5.Location = new System.Drawing.Point(92, 157);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.ReadOnly = true;
            this.txtMd5.Size = new System.Drawing.Size(317, 23);
            this.txtMd5.TabIndex = 7;
            // 
            // txtSha1
            // 
            this.txtSha1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSha1.Location = new System.Drawing.Point(92, 186);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.ReadOnly = true;
            this.txtSha1.Size = new System.Drawing.Size(317, 23);
            this.txtSha1.TabIndex = 8;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrolEt.Location = new System.Drawing.Point(419, 157);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(70, 81);
            this.btnKontrolEt.TabIndex = 9;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.BtnKontrolEt_Click);
            // 
            // txtKarsilastir
            // 
            this.txtKarsilastir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKarsilastir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKarsilastir.Location = new System.Drawing.Point(92, 215);
            this.txtKarsilastir.Name = "txtKarsilastir";
            this.txtKarsilastir.Size = new System.Drawing.Size(317, 23);
            this.txtKarsilastir.TabIndex = 10;
            this.txtKarsilastir.TextChanged += new System.EventHandler(this.TxtKarsilastir_TextChanged);
            this.txtKarsilastir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKarsilastir_KeyDown);
            // 
            // lblKarsilastir
            // 
            this.lblKarsilastir.AutoSize = true;
            this.lblKarsilastir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarsilastir.Location = new System.Drawing.Point(24, 218);
            this.lblKarsilastir.Name = "lblKarsilastir";
            this.lblKarsilastir.Size = new System.Drawing.Size(62, 15);
            this.lblKarsilastir.TabIndex = 11;
            this.lblKarsilastir.Text = "Karşılaştır:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Tüm Dosyalar|*.*";
            this.openFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Dosya Aç";
            // 
            // FrmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 253);
            this.Controls.Add(this.lblKarsilastir);
            this.Controls.Add(this.txtKarsilastir);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.txtMd5);
            this.Controls.Add(this.lblMd5);
            this.Controls.Add(this.lblSha1);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.gbDosyaAc);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Hash Değeri Hesaplayıcı";
            this.gbDosyaAc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDosyaAc;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.Label lblDosyaAc;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label lblSha1;
        private System.Windows.Forms.Label lblMd5;
        public System.Windows.Forms.TextBox txtMd5;
        public System.Windows.Forms.TextBox txtSha1;
        public System.Windows.Forms.TextBox txtKarsilastir;
        public System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label lblKarsilastir;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}