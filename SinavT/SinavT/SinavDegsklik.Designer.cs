namespace SinavT
{
    partial class SinavDegsklik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavDegsklik));
            this.buttonCks = new System.Windows.Forms.Button();
            this.dtGridDersler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSinavSekli = new System.Windows.Forms.ComboBox();
            this.labelDgtlmsDrslr = new System.Windows.Forms.Label();
            this.cmbSinavTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOturum = new System.Windows.Forms.ComboBox();
            this.rdBtnTarih = new System.Windows.Forms.RadioButton();
            this.rdBtnSaat = new System.Windows.Forms.RadioButton();
            this.rdBtnOturum = new System.Windows.Forms.RadioButton();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.DersDagitimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oturum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabitDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabitBolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarihId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabitSinavSekliId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(619, 419);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(78, 53);
            this.buttonCks.TabIndex = 26;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // dtGridDersler
            // 
            this.dtGridDersler.AllowUserToAddRows = false;
            this.dtGridDersler.AllowUserToDeleteRows = false;
            this.dtGridDersler.AllowUserToResizeColumns = false;
            this.dtGridDersler.AllowUserToResizeRows = false;
            this.dtGridDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DersDagitimId,
            this.Oturum,
            this.SabitDersAdi,
            this.Gurp,
            this.SabitBolumAdi,
            this.Tarih,
            this.Saat,
            this.SinavTuru,
            this.SinavSekli,
            this.TarihId,
            this.SaatId,
            this.DersId,
            this.sabitSinavSekliId});
            this.dtGridDersler.Location = new System.Drawing.Point(12, 12);
            this.dtGridDersler.MultiSelect = false;
            this.dtGridDersler.Name = "dtGridDersler";
            this.dtGridDersler.ReadOnly = true;
            this.dtGridDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDersler.Size = new System.Drawing.Size(690, 302);
            this.dtGridDersler.TabIndex = 27;
            this.dtGridDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDersler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 73;
            this.label1.Text = "Sınav Şekli";
            // 
            // cmbSinavSekli
            // 
            this.cmbSinavSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinavSekli.Enabled = false;
            this.cmbSinavSekli.FormattingEnabled = true;
            this.cmbSinavSekli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSinavSekli.Items.AddRange(new object[] {
            "Yazili",
            "Sözlü",
            "Uygulama"});
            this.cmbSinavSekli.Location = new System.Drawing.Point(116, 456);
            this.cmbSinavSekli.Name = "cmbSinavSekli";
            this.cmbSinavSekli.Size = new System.Drawing.Size(208, 21);
            this.cmbSinavSekli.TabIndex = 72;
            // 
            // labelDgtlmsDrslr
            // 
            this.labelDgtlmsDrslr.AutoSize = true;
            this.labelDgtlmsDrslr.BackColor = System.Drawing.Color.Transparent;
            this.labelDgtlmsDrslr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDgtlmsDrslr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDgtlmsDrslr.Location = new System.Drawing.Point(12, 426);
            this.labelDgtlmsDrslr.Name = "labelDgtlmsDrslr";
            this.labelDgtlmsDrslr.Size = new System.Drawing.Size(72, 14);
            this.labelDgtlmsDrslr.TabIndex = 71;
            this.labelDgtlmsDrslr.Text = "Sınav Türü";
            // 
            // cmbSinavTuru
            // 
            this.cmbSinavTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinavTuru.Enabled = false;
            this.cmbSinavTuru.FormattingEnabled = true;
            this.cmbSinavTuru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSinavTuru.Items.AddRange(new object[] {
            "Yazılı",
            "Sözlü",
            "Uygulama"});
            this.cmbSinavTuru.Location = new System.Drawing.Point(116, 424);
            this.cmbSinavTuru.Name = "cmbSinavTuru";
            this.cmbSinavTuru.Size = new System.Drawing.Size(104, 21);
            this.cmbSinavTuru.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tarih";
            // 
            // cmbTarih
            // 
            this.cmbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarih.Enabled = false;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTarih.Items.AddRange(new object[] {
            "Sözlü",
            "Uygulama",
            "Yazili"});
            this.cmbTarih.Location = new System.Drawing.Point(116, 328);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(104, 21);
            this.cmbTarih.Sorted = true;
            this.cmbTarih.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 77;
            this.label3.Text = "Saat";
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.Enabled = false;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSaat.Items.AddRange(new object[] {
            "Sözlü",
            "Uygulama",
            "Yazili"});
            this.cmbSaat.Location = new System.Drawing.Point(116, 360);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(104, 21);
            this.cmbSaat.Sorted = true;
            this.cmbSaat.TabIndex = 76;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(447, 419);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(78, 53);
            this.btnKaydet.TabIndex = 79;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Enabled = false;
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(361, 419);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(78, 53);
            this.btnDuzenle.TabIndex = 78;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 81;
            this.label4.Text = "Oturum";
            // 
            // cmbOturum
            // 
            this.cmbOturum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOturum.Enabled = false;
            this.cmbOturum.FormattingEnabled = true;
            this.cmbOturum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOturum.Items.AddRange(new object[] {
            "Sözlü",
            "Uygulama",
            "Yazili"});
            this.cmbOturum.Location = new System.Drawing.Point(116, 392);
            this.cmbOturum.Name = "cmbOturum";
            this.cmbOturum.Size = new System.Drawing.Size(104, 21);
            this.cmbOturum.Sorted = true;
            this.cmbOturum.TabIndex = 80;
            // 
            // rdBtnTarih
            // 
            this.rdBtnTarih.AutoSize = true;
            this.rdBtnTarih.Checked = true;
            this.rdBtnTarih.Location = new System.Drawing.Point(92, 332);
            this.rdBtnTarih.Name = "rdBtnTarih";
            this.rdBtnTarih.Size = new System.Drawing.Size(14, 13);
            this.rdBtnTarih.TabIndex = 82;
            this.rdBtnTarih.TabStop = true;
            this.rdBtnTarih.UseVisualStyleBackColor = true;
            // 
            // rdBtnSaat
            // 
            this.rdBtnSaat.AutoSize = true;
            this.rdBtnSaat.Location = new System.Drawing.Point(92, 364);
            this.rdBtnSaat.Name = "rdBtnSaat";
            this.rdBtnSaat.Size = new System.Drawing.Size(14, 13);
            this.rdBtnSaat.TabIndex = 83;
            this.rdBtnSaat.UseVisualStyleBackColor = true;
            // 
            // rdBtnOturum
            // 
            this.rdBtnOturum.AutoSize = true;
            this.rdBtnOturum.Location = new System.Drawing.Point(92, 395);
            this.rdBtnOturum.Name = "rdBtnOturum";
            this.rdBtnOturum.Size = new System.Drawing.Size(14, 13);
            this.rdBtnOturum.TabIndex = 84;
            this.rdBtnOturum.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(533, 419);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(78, 53);
            this.btnVazgec.TabIndex = 85;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // DersDagitimId
            // 
            this.DersDagitimId.DataPropertyName = "DersDagitimId";
            this.DersDagitimId.HeaderText = "Id";
            this.DersDagitimId.Name = "DersDagitimId";
            this.DersDagitimId.ReadOnly = true;
            this.DersDagitimId.Visible = false;
            // 
            // Oturum
            // 
            this.Oturum.DataPropertyName = "oturum";
            this.Oturum.HeaderText = "Oturum";
            this.Oturum.Name = "Oturum";
            this.Oturum.ReadOnly = true;
            this.Oturum.Visible = false;
            // 
            // SabitDersAdi
            // 
            this.SabitDersAdi.DataPropertyName = "SabitDersAdi";
            this.SabitDersAdi.HeaderText = "Ders Adı";
            this.SabitDersAdi.Name = "SabitDersAdi";
            this.SabitDersAdi.ReadOnly = true;
            this.SabitDersAdi.Width = 140;
            // 
            // Gurp
            // 
            this.Gurp.DataPropertyName = "grup";
            this.Gurp.HeaderText = "Grup";
            this.Gurp.Name = "Gurp";
            this.Gurp.ReadOnly = true;
            this.Gurp.Width = 60;
            // 
            // SabitBolumAdi
            // 
            this.SabitBolumAdi.DataPropertyName = "SabitBolumAdi";
            this.SabitBolumAdi.HeaderText = "Bölüm Adi";
            this.SabitBolumAdi.Name = "SabitBolumAdi";
            this.SabitBolumAdi.ReadOnly = true;
            this.SabitBolumAdi.Width = 120;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Width = 80;
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Width = 40;
            // 
            // SinavTuru
            // 
            this.SinavTuru.DataPropertyName = "turu";
            this.SinavTuru.HeaderText = "Sinav Türü";
            this.SinavTuru.Name = "SinavTuru";
            this.SinavTuru.ReadOnly = true;
            this.SinavTuru.Width = 90;
            // 
            // SinavSekli
            // 
            this.SinavSekli.DataPropertyName = "SinavSekli";
            this.SinavSekli.HeaderText = "Sınav Şekli";
            this.SinavSekli.Name = "SinavSekli";
            this.SinavSekli.ReadOnly = true;
            // 
            // TarihId
            // 
            this.TarihId.DataPropertyName = "TarihId";
            this.TarihId.HeaderText = "Tarih Id";
            this.TarihId.Name = "TarihId";
            this.TarihId.ReadOnly = true;
            this.TarihId.Visible = false;
            // 
            // SaatId
            // 
            this.SaatId.DataPropertyName = "SaatId";
            this.SaatId.HeaderText = "Saat Id";
            this.SaatId.Name = "SaatId";
            this.SaatId.ReadOnly = true;
            this.SaatId.Visible = false;
            // 
            // DersId
            // 
            this.DersId.DataPropertyName = "dersId";
            this.DersId.HeaderText = "Ders Id";
            this.DersId.Name = "DersId";
            this.DersId.ReadOnly = true;
            this.DersId.Visible = false;
            // 
            // sabitSinavSekliId
            // 
            this.sabitSinavSekliId.DataPropertyName = "sabitSinavSekliId";
            this.sabitSinavSekliId.HeaderText = "Sabit Sınav Şekli";
            this.sabitSinavSekliId.Name = "sabitSinavSekliId";
            this.sabitSinavSekliId.ReadOnly = true;
            this.sabitSinavSekliId.Visible = false;
            // 
            // SinavDegsklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.rdBtnOturum);
            this.Controls.Add(this.rdBtnSaat);
            this.Controls.Add(this.rdBtnTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOturum);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSinavSekli);
            this.Controls.Add(this.labelDgtlmsDrslr);
            this.Controls.Add(this.cmbSinavTuru);
            this.Controls.Add(this.dtGridDersler);
            this.Controls.Add(this.buttonCks);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinavDegsklik";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Değişiklik";
            this.Load += new System.EventHandler(this.SinavDegsklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.DataGridView dtGridDersler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSinavSekli;
        private System.Windows.Forms.Label labelDgtlmsDrslr;
        private System.Windows.Forms.ComboBox cmbSinavTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOturum;
        private System.Windows.Forms.RadioButton rdBtnTarih;
        private System.Windows.Forms.RadioButton rdBtnSaat;
        private System.Windows.Forms.RadioButton rdBtnOturum;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersDagitimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oturum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabitDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabitBolumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabitSinavSekliId;

    }
}