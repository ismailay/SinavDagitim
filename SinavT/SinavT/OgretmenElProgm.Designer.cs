namespace SinavT
{
    partial class OgretmenElProgm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenElProgm));
            this.buttonCks = new System.Windows.Forms.Button();
            this.lstOgretmenler = new System.Windows.Forms.ListBox();
            this.labelOgrtmn = new System.Windows.Forms.Label();
            this.buttonRpr = new System.Windows.Forms.Button();
            this.dtGridDersler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinifSeviye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersDagitimOgretmenGorevTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(621, 440);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 59;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // lstOgretmenler
            // 
            this.lstOgretmenler.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOgretmenler.FormattingEnabled = true;
            this.lstOgretmenler.Location = new System.Drawing.Point(12, 31);
            this.lstOgretmenler.Name = "lstOgretmenler";
            this.lstOgretmenler.Size = new System.Drawing.Size(158, 394);
            this.lstOgretmenler.TabIndex = 57;
            this.lstOgretmenler.Click += new System.EventHandler(this.lstOgretmenler_Click);
            // 
            // labelOgrtmn
            // 
            this.labelOgrtmn.AutoSize = true;
            this.labelOgrtmn.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrtmn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrtmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOgrtmn.Location = new System.Drawing.Point(13, 13);
            this.labelOgrtmn.Name = "labelOgrtmn";
            this.labelOgrtmn.Size = new System.Drawing.Size(68, 28);
            this.labelOgrtmn.TabIndex = 56;
            this.labelOgrtmn.Text = "Öğretmen\r\nler";
            // 
            // buttonRpr
            // 
            this.buttonRpr.Location = new System.Drawing.Point(73, 440);
            this.buttonRpr.Name = "buttonRpr";
            this.buttonRpr.Size = new System.Drawing.Size(222, 31);
            this.buttonRpr.TabIndex = 60;
            this.buttonRpr.Text = "Tek Kişilik Form";
            this.buttonRpr.UseVisualStyleBackColor = true;
            this.buttonRpr.Click += new System.EventHandler(this.buttonRpr_Click);
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
            this.dtGridDersler.Location = new System.Drawing.Point(177, 31);
            this.dtGridDersler.MultiSelect = false;
            this.dtGridDersler.Name = "dtGridDersler";
            this.dtGridDersler.ReadOnly = true;
            this.dtGridDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDersler.Size = new System.Drawing.Size(520, 394);
            this.dtGridDersler.TabIndex = 61;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OgretmenElProgm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtGridDersler);
            this.Controls.Add(this.buttonRpr);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.lstOgretmenler);
            this.Controls.Add(this.labelOgrtmn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgretmenElProgm";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen El Programı";
            this.Load += new System.EventHandler(this.OgretmenElProgm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.ListBox lstOgretmenler;
        private System.Windows.Forms.Label labelOgrtmn;
        private System.Windows.Forms.Button buttonRpr;
        private System.Windows.Forms.DataGridView dtGridDersler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinifSeviye;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersDagitimOgretmenGorevTuru;
        private System.Windows.Forms.Button button1;
    }
}