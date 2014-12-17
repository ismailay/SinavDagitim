namespace SinavT
{
    partial class OgrenciDersAtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciDersAtama));
            this.lstBolum = new System.Windows.Forms.ListBox();
            this.lstSeviye = new System.Windows.Forms.ListBox();
            this.dataGridViewSvye = new System.Windows.Forms.DataGridView();
            this.listeleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listeleDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listeleSeviye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbDersAdi = new System.Windows.Forms.ComboBox();
            this.labelDrslr = new System.Windows.Forms.Label();
            this.labelBlm = new System.Windows.Forms.Label();
            this.labelSviy = new System.Windows.Forms.Label();
            this.buttonCks = new System.Windows.Forms.Button();
            this.dataGridViewOgrnci = new System.Windows.Forms.DataGridView();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSvye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrnci)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBolum
            // 
            this.lstBolum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBolum.FormattingEnabled = true;
            this.lstBolum.Location = new System.Drawing.Point(509, 29);
            this.lstBolum.Name = "lstBolum";
            this.lstBolum.Size = new System.Drawing.Size(189, 108);
            this.lstBolum.TabIndex = 60;
            this.lstBolum.Click += new System.EventHandler(this.lstBolum_Click);
            // 
            // lstSeviye
            // 
            this.lstSeviye.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSeviye.FormattingEnabled = true;
            this.lstSeviye.Location = new System.Drawing.Point(398, 29);
            this.lstSeviye.Name = "lstSeviye";
            this.lstSeviye.Size = new System.Drawing.Size(105, 108);
            this.lstSeviye.TabIndex = 59;
            this.lstSeviye.Click += new System.EventHandler(this.lstSeviye_Click);
            // 
            // dataGridViewSvye
            // 
            this.dataGridViewSvye.AllowUserToAddRows = false;
            this.dataGridViewSvye.AllowUserToDeleteRows = false;
            this.dataGridViewSvye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSvye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listeleId,
            this.ogrenciId,
            this.listeleDersAdi,
            this.listeleSeviye});
            this.dataGridViewSvye.Location = new System.Drawing.Point(401, 282);
            this.dataGridViewSvye.MultiSelect = false;
            this.dataGridViewSvye.Name = "dataGridViewSvye";
            this.dataGridViewSvye.ReadOnly = true;
            this.dataGridViewSvye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSvye.Size = new System.Drawing.Size(300, 210);
            this.dataGridViewSvye.TabIndex = 58;
            // 
            // listeleId
            // 
            this.listeleId.DataPropertyName = "ogrenciDers.id";
            this.listeleId.HeaderText = "Listele Id";
            this.listeleId.Name = "listeleId";
            this.listeleId.ReadOnly = true;
            this.listeleId.Visible = false;
            // 
            // ogrenciId
            // 
            this.ogrenciId.DataPropertyName = "sabitOgrenci.id";
            this.ogrenciId.HeaderText = "Öğrenci Id";
            this.ogrenciId.Name = "ogrenciId";
            this.ogrenciId.ReadOnly = true;
            this.ogrenciId.Visible = false;
            // 
            // listeleDersAdi
            // 
            this.listeleDersAdi.DataPropertyName = "adi";
            this.listeleDersAdi.HeaderText = "Ders Adı";
            this.listeleDersAdi.Name = "listeleDersAdi";
            this.listeleDersAdi.ReadOnly = true;
            this.listeleDersAdi.Width = 170;
            // 
            // listeleSeviye
            // 
            this.listeleSeviye.DataPropertyName = "grup";
            this.listeleSeviye.HeaderText = "Seviye";
            this.listeleSeviye.Name = "listeleSeviye";
            this.listeleSeviye.ReadOnly = true;
            this.listeleSeviye.Width = 70;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(502, 210);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 52);
            this.btnSil.TabIndex = 57;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(398, 210);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 52);
            this.btnKaydet.TabIndex = 56;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbDersAdi
            // 
            this.cmbDersAdi.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbDersAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersAdi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDersAdi.FormattingEnabled = true;
            this.cmbDersAdi.Location = new System.Drawing.Point(397, 171);
            this.cmbDersAdi.Name = "cmbDersAdi";
            this.cmbDersAdi.Size = new System.Drawing.Size(304, 21);
            this.cmbDersAdi.TabIndex = 55;
            // 
            // labelDrslr
            // 
            this.labelDrslr.AutoSize = true;
            this.labelDrslr.BackColor = System.Drawing.Color.Transparent;
            this.labelDrslr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDrslr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDrslr.Location = new System.Drawing.Point(398, 145);
            this.labelDrslr.Name = "labelDrslr";
            this.labelDrslr.Size = new System.Drawing.Size(49, 14);
            this.labelDrslr.TabIndex = 54;
            this.labelDrslr.Text = "Dersler";
            // 
            // labelBlm
            // 
            this.labelBlm.AutoSize = true;
            this.labelBlm.BackColor = System.Drawing.Color.Transparent;
            this.labelBlm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBlm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBlm.Location = new System.Drawing.Point(509, 12);
            this.labelBlm.Name = "labelBlm";
            this.labelBlm.Size = new System.Drawing.Size(45, 14);
            this.labelBlm.TabIndex = 53;
            this.labelBlm.Text = "Bölüm";
            // 
            // labelSviy
            // 
            this.labelSviy.AutoSize = true;
            this.labelSviy.BackColor = System.Drawing.Color.Transparent;
            this.labelSviy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSviy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSviy.Location = new System.Drawing.Point(398, 12);
            this.labelSviy.Name = "labelSviy";
            this.labelSviy.Size = new System.Drawing.Size(46, 14);
            this.labelSviy.TabIndex = 52;
            this.labelSviy.Text = "Seviye";
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(607, 210);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(94, 52);
            this.buttonCks.TabIndex = 44;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
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
            this.dataGridViewOgrnci.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOgrnci.MultiSelect = false;
            this.dataGridViewOgrnci.Name = "dataGridViewOgrnci";
            this.dataGridViewOgrnci.ReadOnly = true;
            this.dataGridViewOgrnci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrnci.Size = new System.Drawing.Size(380, 480);
            this.dataGridViewOgrnci.TabIndex = 61;
            this.dataGridViewOgrnci.Click += new System.EventHandler(this.dataGridViewOgrnci_Click);
            // 
            // numara
            // 
            this.numara.DataPropertyName = "numara";
            this.numara.HeaderText = "Numara";
            this.numara.Name = "numara";
            this.numara.ReadOnly = true;
            this.numara.Width = 70;
            // 
            // sinif
            // 
            this.sinif.DataPropertyName = "adi";
            this.sinif.HeaderText = "Sınıf";
            this.sinif.Name = "sinif";
            this.sinif.ReadOnly = true;
            this.sinif.Width = 70;
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
            // OgrenciDersAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewOgrnci);
            this.Controls.Add(this.lstBolum);
            this.Controls.Add(this.lstSeviye);
            this.Controls.Add(this.dataGridViewSvye);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDersAdi);
            this.Controls.Add(this.labelDrslr);
            this.Controls.Add(this.labelBlm);
            this.Controls.Add(this.labelSviy);
            this.Controls.Add(this.buttonCks);
            this.Name = "OgrenciDersAtama";
            this.Text = "OgrenciDersAtama";
            this.Load += new System.EventHandler(this.OgrenciDersAtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSvye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrnci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBolum;
        private System.Windows.Forms.ListBox lstSeviye;
        private System.Windows.Forms.DataGridView dataGridViewSvye;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbDersAdi;
        private System.Windows.Forms.Label labelDrslr;
        private System.Windows.Forms.Label labelBlm;
        private System.Windows.Forms.Label labelSviy;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.DataGridView dataGridViewOgrnci;
        private System.Windows.Forms.DataGridViewTextBoxColumn listeleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn listeleDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn listeleSeviye;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn notu;
    }
}