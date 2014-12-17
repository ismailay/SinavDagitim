namespace SinavT
{
    partial class Ogrnci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrnci));
            this.buttonCks = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.dataGridViewOgrnci = new System.Windows.Forms.DataGridView();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.labelSnf = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.labelAdSyd = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.labelNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrnci)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(586, 416);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(94, 52);
            this.buttonCks.TabIndex = 6;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(454, 416);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(102, 52);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(346, 416);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 52);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(238, 416);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 52);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(130, 416);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 52);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(22, 416);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 52);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // dataGridViewOgrnci
            // 
            this.dataGridViewOgrnci.AllowUserToAddRows = false;
            this.dataGridViewOgrnci.AllowUserToDeleteRows = false;
            this.dataGridViewOgrnci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrnci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numara,
            this.sinif,
            this.adsoyad,
            this.id,
            this.sinifId,
            this.ders,
            this.notu});
            this.dataGridViewOgrnci.Location = new System.Drawing.Point(22, 12);
            this.dataGridViewOgrnci.MultiSelect = false;
            this.dataGridViewOgrnci.Name = "dataGridViewOgrnci";
            this.dataGridViewOgrnci.ReadOnly = true;
            this.dataGridViewOgrnci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrnci.Size = new System.Drawing.Size(440, 322);
            this.dataGridViewOgrnci.TabIndex = 0;
            // 
            // numara
            // 
            this.numara.DataPropertyName = "numara";
            this.numara.HeaderText = "Numara";
            this.numara.Name = "numara";
            this.numara.ReadOnly = true;
            // 
            // sinif
            // 
            this.sinif.DataPropertyName = "adi";
            this.sinif.HeaderText = "Sınıf";
            this.sinif.Name = "sinif";
            this.sinif.ReadOnly = true;
            // 
            // adsoyad
            // 
            this.adsoyad.DataPropertyName = "adsoyad";
            this.adsoyad.HeaderText = "Adı Soyadı";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            this.adsoyad.Width = 180;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // sinifId
            // 
            this.sinifId.DataPropertyName = "sinif";
            this.sinifId.HeaderText = "Sınıf Id";
            this.sinifId.Name = "sinifId";
            this.sinifId.ReadOnly = true;
            this.sinifId.Visible = false;
            // 
            // ders
            // 
            this.ders.DataPropertyName = "ders";
            this.ders.HeaderText = "Ders";
            this.ders.Name = "ders";
            this.ders.ReadOnly = true;
            this.ders.Visible = false;
            // 
            // notu
            // 
            this.notu.DataPropertyName = "notu";
            this.notu.HeaderText = "Not";
            this.notu.Name = "notu";
            this.notu.ReadOnly = true;
            this.notu.Visible = false;
            // 
            // cmbSinif
            // 
            this.cmbSinif.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinif.Enabled = false;
            this.cmbSinif.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(568, 75);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(94, 21);
            this.cmbSinif.TabIndex = 8;
            // 
            // labelSnf
            // 
            this.labelSnf.AutoSize = true;
            this.labelSnf.BackColor = System.Drawing.Color.Transparent;
            this.labelSnf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSnf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSnf.Location = new System.Drawing.Point(483, 82);
            this.labelSnf.Name = "labelSnf";
            this.labelSnf.Size = new System.Drawing.Size(34, 14);
            this.labelSnf.TabIndex = 34;
            this.labelSnf.Text = "Sınıf";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAdiSoyadi.Enabled = false;
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdiSoyadi.Location = new System.Drawing.Point(568, 126);
            this.txtAdiSoyadi.Multiline = true;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(138, 23);
            this.txtAdiSoyadi.TabIndex = 9;
            // 
            // labelAdSyd
            // 
            this.labelAdSyd.AutoSize = true;
            this.labelAdSyd.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSyd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSyd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdSyd.Location = new System.Drawing.Point(484, 135);
            this.labelAdSyd.Name = "labelAdSyd";
            this.labelAdSyd.Size = new System.Drawing.Size(72, 14);
            this.labelAdSyd.TabIndex = 32;
            this.labelAdSyd.Text = "Adı Soyadı";
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNumara.Enabled = false;
            this.txtNumara.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(568, 21);
            this.txtNumara.Multiline = true;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(112, 23);
            this.txtNumara.TabIndex = 7;
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNo.Location = new System.Drawing.Point(483, 30);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(53, 14);
            this.labelNo.TabIndex = 30;
            this.labelNo.Text = "Numara";
            // 
            // Ogrnci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.labelSnf);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.labelAdSyd);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.dataGridViewOgrnci);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ogrnci";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Girişi";
            this.Load += new System.EventHandler(this.Ogrnci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrnci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridView dataGridViewOgrnci;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Label labelSnf;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label labelAdSyd;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn notu;
    }
}