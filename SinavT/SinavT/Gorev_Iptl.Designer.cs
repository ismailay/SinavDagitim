namespace SinavT
{
    partial class Gorev_Iptl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorev_Iptl));
            this.lstOgretmen = new System.Windows.Forms.ListBox();
            this.labelOgrtmn = new System.Windows.Forms.Label();
            this.dtGridDersler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinifSeviye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersDagitimOgretmenGorevTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGrvIptl = new System.Windows.Forms.Label();
            this.buttonCks = new System.Windows.Forms.Button();
            this.btnTumGorevleriSil = new System.Windows.Forms.Button();
            this.btnSinavGoreviniSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOgretmen
            // 
            this.lstOgretmen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOgretmen.FormattingEnabled = true;
            this.lstOgretmen.Location = new System.Drawing.Point(21, 61);
            this.lstOgretmen.Name = "lstOgretmen";
            this.lstOgretmen.Size = new System.Drawing.Size(160, 355);
            this.lstOgretmen.TabIndex = 49;
            this.lstOgretmen.Click += new System.EventHandler(this.lstOgretmen_Click);
            // 
            // labelOgrtmn
            // 
            this.labelOgrtmn.AutoSize = true;
            this.labelOgrtmn.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrtmn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrtmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOgrtmn.Location = new System.Drawing.Point(18, 41);
            this.labelOgrtmn.Name = "labelOgrtmn";
            this.labelOgrtmn.Size = new System.Drawing.Size(68, 14);
            this.labelOgrtmn.TabIndex = 48;
            this.labelOgrtmn.Text = "Öğretmen\r\n";
            // 
            // dtGridDersler
            // 
            this.dtGridDersler.AllowUserToAddRows = false;
            this.dtGridDersler.AllowUserToDeleteRows = false;
            this.dtGridDersler.AllowUserToResizeColumns = false;
            this.dtGridDersler.AllowUserToResizeRows = false;
            this.dtGridDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.OgretmenId,
            this.DersAdi,
            this.Tarih,
            this.Saat,
            this.SinavSekli,
            this.SinifSeviye,
            this.DersDagitimOgretmenGorevTuru});
            this.dtGridDersler.Location = new System.Drawing.Point(187, 61);
            this.dtGridDersler.MultiSelect = false;
            this.dtGridDersler.Name = "dtGridDersler";
            this.dtGridDersler.ReadOnly = true;
            this.dtGridDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDersler.Size = new System.Drawing.Size(520, 355);
            this.dtGridDersler.TabIndex = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // OgretmenId
            // 
            this.OgretmenId.DataPropertyName = "ogretmenId";
            this.OgretmenId.HeaderText = "Öğretmen Id";
            this.OgretmenId.Name = "OgretmenId";
            this.OgretmenId.ReadOnly = true;
            this.OgretmenId.Visible = false;
            // 
            // DersAdi
            // 
            this.DersAdi.DataPropertyName = "DersAdi";
            this.DersAdi.HeaderText = "Ders Adi";
            this.DersAdi.Name = "DersAdi";
            this.DersAdi.ReadOnly = true;
            this.DersAdi.Width = 150;
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
            this.Saat.Width = 50;
            // 
            // SinavSekli
            // 
            this.SinavSekli.DataPropertyName = "SinavSekli";
            this.SinavSekli.HeaderText = "Türü";
            this.SinavSekli.Name = "SinavSekli";
            this.SinavSekli.ReadOnly = true;
            this.SinavSekli.Width = 50;
            // 
            // SinifSeviye
            // 
            this.SinifSeviye.DataPropertyName = "SinifSeviye";
            this.SinifSeviye.HeaderText = "Seviye";
            this.SinifSeviye.Name = "SinifSeviye";
            this.SinifSeviye.ReadOnly = true;
            this.SinifSeviye.Width = 50;
            // 
            // DersDagitimOgretmenGorevTuru
            // 
            this.DersDagitimOgretmenGorevTuru.DataPropertyName = "DersDagitimOgretmenGorevTuru";
            this.DersDagitimOgretmenGorevTuru.HeaderText = "Görev";
            this.DersDagitimOgretmenGorevTuru.Name = "DersDagitimOgretmenGorevTuru";
            this.DersDagitimOgretmenGorevTuru.ReadOnly = true;
            this.DersDagitimOgretmenGorevTuru.Width = 80;
            // 
            // labelGrvIptl
            // 
            this.labelGrvIptl.AutoSize = true;
            this.labelGrvIptl.BackColor = System.Drawing.Color.Transparent;
            this.labelGrvIptl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGrvIptl.ForeColor = System.Drawing.Color.Crimson;
            this.labelGrvIptl.Location = new System.Drawing.Point(17, 9);
            this.labelGrvIptl.Name = "labelGrvIptl";
            this.labelGrvIptl.Size = new System.Drawing.Size(111, 19);
            this.labelGrvIptl.TabIndex = 53;
            this.labelGrvIptl.Text = "Görev İptal !\r\n";
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(629, 428);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 55;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // btnTumGorevleriSil
            // 
            this.btnTumGorevleriSil.Location = new System.Drawing.Point(69, 428);
            this.btnTumGorevleriSil.Name = "btnTumGorevleriSil";
            this.btnTumGorevleriSil.Size = new System.Drawing.Size(120, 52);
            this.btnTumGorevleriSil.TabIndex = 54;
            this.btnTumGorevleriSil.Text = "Tüm Görevleri Sil ";
            this.btnTumGorevleriSil.UseVisualStyleBackColor = true;
            this.btnTumGorevleriSil.Click += new System.EventHandler(this.btnTumGorevleriSil_Click);
            // 
            // btnSinavGoreviniSil
            // 
            this.btnSinavGoreviniSil.Location = new System.Drawing.Point(195, 428);
            this.btnSinavGoreviniSil.Name = "btnSinavGoreviniSil";
            this.btnSinavGoreviniSil.Size = new System.Drawing.Size(120, 52);
            this.btnSinavGoreviniSil.TabIndex = 56;
            this.btnSinavGoreviniSil.Text = "Sınav Görevini Sil";
            this.btnSinavGoreviniSil.UseVisualStyleBackColor = true;
            this.btnSinavGoreviniSil.Click += new System.EventHandler(this.btnSinavGoreviniSil_Click);
            // 
            // Gorev_Iptl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btnSinavGoreviniSil);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnTumGorevleriSil);
            this.Controls.Add(this.labelGrvIptl);
            this.Controls.Add(this.dtGridDersler);
            this.Controls.Add(this.lstOgretmen);
            this.Controls.Add(this.labelOgrtmn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gorev_Iptl";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev İptal";
            this.Load += new System.EventHandler(this.Gorev_Iptl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOgretmen;
        private System.Windows.Forms.Label labelOgrtmn;
        private System.Windows.Forms.DataGridView dtGridDersler;
        private System.Windows.Forms.Label labelGrvIptl;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button btnTumGorevleriSil;
        private System.Windows.Forms.Button btnSinavGoreviniSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinifSeviye;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersDagitimOgretmenGorevTuru;
    }
}