namespace SinavT
{
    partial class SinifBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinifBilgileri));
            this.dataGridSnfBlglrSnfBlm = new System.Windows.Forms.DataGridView();
            this.bolumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridSnfBlglrSnfAdi = new System.Windows.Forms.DataGridView();
            this.sinifId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.labelSnfBlglrBlmAd = new System.Windows.Forms.Label();
            this.txtSinifAdi = new System.Windows.Forms.TextBox();
            this.labelSnfBlglrSnfAdi = new System.Windows.Forms.Label();
            this.buttonCks = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seviyeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seviyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSeviyeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridViewSinavTuru = new System.Windows.Forms.DataGridView();
            this.txtSinavTuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSnfBlglrSnfBlm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSnfBlglrSnfAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSinavTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSnfBlglrSnfBlm
            // 
            this.dataGridSnfBlglrSnfBlm.AllowUserToAddRows = false;
            this.dataGridSnfBlglrSnfBlm.AllowUserToDeleteRows = false;
            this.dataGridSnfBlglrSnfBlm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSnfBlglrSnfBlm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumId,
            this.bolumAdi});
            this.dataGridSnfBlglrSnfBlm.Location = new System.Drawing.Point(271, 88);
            this.dataGridSnfBlglrSnfBlm.MultiSelect = false;
            this.dataGridSnfBlglrSnfBlm.Name = "dataGridSnfBlglrSnfBlm";
            this.dataGridSnfBlglrSnfBlm.ReadOnly = true;
            this.dataGridSnfBlglrSnfBlm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSnfBlglrSnfBlm.Size = new System.Drawing.Size(230, 257);
            this.dataGridSnfBlglrSnfBlm.TabIndex = 1;
            this.dataGridSnfBlglrSnfBlm.Click += new System.EventHandler(this.dataGridSnfBlglrSnfBlm_Click);
            // 
            // bolumId
            // 
            this.bolumId.DataPropertyName = "id";
            this.bolumId.HeaderText = "BölümId";
            this.bolumId.Name = "bolumId";
            this.bolumId.ReadOnly = true;
            this.bolumId.Visible = false;
            // 
            // bolumAdi
            // 
            this.bolumAdi.DataPropertyName = "ad";
            this.bolumAdi.HeaderText = "Bölüm Adı";
            this.bolumAdi.Name = "bolumAdi";
            this.bolumAdi.ReadOnly = true;
            this.bolumAdi.Width = 170;
            // 
            // dataGridSnfBlglrSnfAdi
            // 
            this.dataGridSnfBlglrSnfAdi.AllowUserToAddRows = false;
            this.dataGridSnfBlglrSnfAdi.AllowUserToDeleteRows = false;
            this.dataGridSnfBlglrSnfAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSnfBlglrSnfAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifId,
            this.sinifAdi});
            this.dataGridSnfBlglrSnfAdi.Location = new System.Drawing.Point(22, 88);
            this.dataGridSnfBlglrSnfAdi.MultiSelect = false;
            this.dataGridSnfBlglrSnfAdi.Name = "dataGridSnfBlglrSnfAdi";
            this.dataGridSnfBlglrSnfAdi.ReadOnly = true;
            this.dataGridSnfBlglrSnfAdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSnfBlglrSnfAdi.Size = new System.Drawing.Size(230, 257);
            this.dataGridSnfBlglrSnfAdi.TabIndex = 0;
            this.dataGridSnfBlglrSnfAdi.Click += new System.EventHandler(this.dataGridSnfBlglrSnfAdi_Click);
            // 
            // sinifId
            // 
            this.sinifId.DataPropertyName = "id";
            this.sinifId.HeaderText = "SınıfId";
            this.sinifId.Name = "sinifId";
            this.sinifId.ReadOnly = true;
            this.sinifId.Visible = false;
            // 
            // sinifAdi
            // 
            this.sinifAdi.DataPropertyName = "adi";
            this.sinifAdi.HeaderText = "Sınıf Adı";
            this.sinifAdi.Name = "sinifAdi";
            this.sinifAdi.ReadOnly = true;
            this.sinifAdi.Width = 170;
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBolumAdi.Enabled = false;
            this.txtBolumAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAdi.Location = new System.Drawing.Point(274, 38);
            this.txtBolumAdi.Multiline = true;
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(227, 23);
            this.txtBolumAdi.TabIndex = 10;
            // 
            // labelSnfBlglrBlmAd
            // 
            this.labelSnfBlglrBlmAd.AutoSize = true;
            this.labelSnfBlglrBlmAd.BackColor = System.Drawing.Color.Transparent;
            this.labelSnfBlglrBlmAd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSnfBlglrBlmAd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSnfBlglrBlmAd.Location = new System.Drawing.Point(276, 18);
            this.labelSnfBlglrBlmAd.Name = "labelSnfBlglrBlmAd";
            this.labelSnfBlglrBlmAd.Size = new System.Drawing.Size(69, 14);
            this.labelSnfBlglrBlmAd.TabIndex = 22;
            this.labelSnfBlglrBlmAd.Text = "Bölüm Adı";
            // 
            // txtSinifAdi
            // 
            this.txtSinifAdi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSinifAdi.Enabled = false;
            this.txtSinifAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinifAdi.Location = new System.Drawing.Point(22, 38);
            this.txtSinifAdi.Multiline = true;
            this.txtSinifAdi.Name = "txtSinifAdi";
            this.txtSinifAdi.Size = new System.Drawing.Size(227, 23);
            this.txtSinifAdi.TabIndex = 9;
            // 
            // labelSnfBlglrSnfAdi
            // 
            this.labelSnfBlglrSnfAdi.AutoSize = true;
            this.labelSnfBlglrSnfAdi.BackColor = System.Drawing.Color.Transparent;
            this.labelSnfBlglrSnfAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSnfBlglrSnfAdi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSnfBlglrSnfAdi.Location = new System.Drawing.Point(24, 18);
            this.labelSnfBlglrSnfAdi.Name = "labelSnfBlglrSnfAdi";
            this.labelSnfBlglrSnfAdi.Size = new System.Drawing.Size(58, 14);
            this.labelSnfBlglrSnfAdi.TabIndex = 20;
            this.labelSnfBlglrSnfAdi.Text = "Sınıf Adı";
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(586, 388);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(102, 52);
            this.buttonCks.TabIndex = 8;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(454, 388);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(102, 52);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(346, 388);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 52);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(238, 388);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 52);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(130, 388);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 52);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(22, 388);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 52);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seviyeId,
            this.seviyeAdi});
            this.dataGridView1.Location = new System.Drawing.Point(521, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(160, 89);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // seviyeId
            // 
            this.seviyeId.DataPropertyName = "id";
            this.seviyeId.HeaderText = "SeviyeId";
            this.seviyeId.Name = "seviyeId";
            this.seviyeId.ReadOnly = true;
            this.seviyeId.Visible = false;
            // 
            // seviyeAdi
            // 
            this.seviyeAdi.DataPropertyName = "grup";
            this.seviyeAdi.HeaderText = "Sınıf Seviyesi";
            this.seviyeAdi.Name = "seviyeAdi";
            this.seviyeAdi.ReadOnly = true;
            // 
            // txtSeviyeAdi
            // 
            this.txtSeviyeAdi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSeviyeAdi.Enabled = false;
            this.txtSeviyeAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeviyeAdi.Location = new System.Drawing.Point(521, 38);
            this.txtSeviyeAdi.Multiline = true;
            this.txtSeviyeAdi.Name = "txtSeviyeAdi";
            this.txtSeviyeAdi.Size = new System.Drawing.Size(160, 23);
            this.txtSeviyeAdi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(523, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Seviye";
            // 
            // dtGridViewSinavTuru
            // 
            this.dtGridViewSinavTuru.AllowUserToAddRows = false;
            this.dtGridViewSinavTuru.AllowUserToDeleteRows = false;
            this.dtGridViewSinavTuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewSinavTuru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TurId,
            this.TurAdi});
            this.dtGridViewSinavTuru.Location = new System.Drawing.Point(521, 239);
            this.dtGridViewSinavTuru.MultiSelect = false;
            this.dtGridViewSinavTuru.Name = "dtGridViewSinavTuru";
            this.dtGridViewSinavTuru.ReadOnly = true;
            this.dtGridViewSinavTuru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewSinavTuru.Size = new System.Drawing.Size(160, 106);
            this.dtGridViewSinavTuru.TabIndex = 33;
            this.dtGridViewSinavTuru.Click += new System.EventHandler(this.dtGridViewSinavTuru_Click);
            // 
            // txtSinavTuru
            // 
            this.txtSinavTuru.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSinavTuru.Enabled = false;
            this.txtSinavTuru.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavTuru.Location = new System.Drawing.Point(521, 210);
            this.txtSinavTuru.Multiline = true;
            this.txtSinavTuru.Name = "txtSinavTuru";
            this.txtSinavTuru.Size = new System.Drawing.Size(160, 23);
            this.txtSinavTuru.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(518, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sınav Türleri";
            // 
            // TurId
            // 
            this.TurId.DataPropertyName = "id";
            this.TurId.HeaderText = "Id";
            this.TurId.Name = "TurId";
            this.TurId.ReadOnly = true;
            this.TurId.Visible = false;
            // 
            // TurAdi
            // 
            this.TurAdi.DataPropertyName = "adi";
            this.TurAdi.HeaderText = "Sınav Türü";
            this.TurAdi.Name = "TurAdi";
            this.TurAdi.ReadOnly = true;
            // 
            // SinifBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 500);
            this.ControlBox = false;
            this.Controls.Add(this.dtGridViewSinavTuru);
            this.Controls.Add(this.txtSinavTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSeviyeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dataGridSnfBlglrSnfBlm);
            this.Controls.Add(this.dataGridSnfBlglrSnfAdi);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.labelSnfBlglrBlmAd);
            this.Controls.Add(this.txtSinifAdi);
            this.Controls.Add(this.labelSnfBlglrSnfAdi);
            this.Name = "SinifBilgileri";
            this.Text = "SinifBilgileri";
            this.Load += new System.EventHandler(this.SinifBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSnfBlglrSnfBlm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSnfBlglrSnfAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSinavTuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSnfBlglrSnfBlm;
        private System.Windows.Forms.DataGridView dataGridSnfBlglrSnfAdi;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label labelSnfBlglrBlmAd;
        private System.Windows.Forms.TextBox txtSinifAdi;
        private System.Windows.Forms.Label labelSnfBlglrSnfAdi;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSeviyeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn seviyeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn seviyeAdi;
        private System.Windows.Forms.DataGridView dtGridViewSinavTuru;
        private System.Windows.Forms.TextBox txtSinavTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAdi;
    }
}