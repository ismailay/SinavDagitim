namespace SinavT
{
    partial class Sinav_Iptl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinav_Iptl));
            this.dtGridDersler = new System.Windows.Forms.DataGridView();
            this.dtGridOgretmenler = new System.Windows.Forms.DataGridView();
            this.buttonCks = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.DersDagitimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabitDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabitBolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDagitimId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabitOgretmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GorevTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).BeginInit();
            this.SuspendLayout();
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
            this.SabitDersAdi,
            this.Gurp,
            this.SabitBolumAdi,
            this.Tarih,
            this.Saat,
            this.SinavTuru,
            this.SinavSekli});
            this.dtGridDersler.Location = new System.Drawing.Point(10, 10);
            this.dtGridDersler.MultiSelect = false;
            this.dtGridDersler.Name = "dtGridDersler";
            this.dtGridDersler.ReadOnly = true;
            this.dtGridDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDersler.Size = new System.Drawing.Size(690, 336);
            this.dtGridDersler.TabIndex = 0;
            this.dtGridDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDersler_CellClick);
            // 
            // dtGridOgretmenler
            // 
            this.dtGridOgretmenler.AllowUserToAddRows = false;
            this.dtGridOgretmenler.AllowUserToDeleteRows = false;
            this.dtGridOgretmenler.AllowUserToResizeColumns = false;
            this.dtGridOgretmenler.AllowUserToResizeRows = false;
            this.dtGridOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOgretmenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersDagitimId1,
            this.OgretmenId,
            this.SabitOgretmenAdi,
            this.GorevTuru});
            this.dtGridOgretmenler.Enabled = false;
            this.dtGridOgretmenler.Location = new System.Drawing.Point(10, 352);
            this.dtGridOgretmenler.MultiSelect = false;
            this.dtGridOgretmenler.Name = "dtGridOgretmenler";
            this.dtGridOgretmenler.ReadOnly = true;
            this.dtGridOgretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOgretmenler.Size = new System.Drawing.Size(380, 136);
            this.dtGridOgretmenler.TabIndex = 1;
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(619, 435);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(78, 53);
            this.buttonCks.TabIndex = 25;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.Location = new System.Drawing.Point(619, 352);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(78, 53);
            this.buttonSil.TabIndex = 23;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // DersDagitimId
            // 
            this.DersDagitimId.DataPropertyName = "DersDagitimId";
            this.DersDagitimId.HeaderText = "Id";
            this.DersDagitimId.Name = "DersDagitimId";
            this.DersDagitimId.ReadOnly = true;
            this.DersDagitimId.Visible = false;
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
            // dersDagitimId1
            // 
            this.dersDagitimId1.DataPropertyName = "DersDagitimId";
            this.dersDagitimId1.HeaderText = "Id";
            this.dersDagitimId1.Name = "dersDagitimId1";
            this.dersDagitimId1.ReadOnly = true;
            this.dersDagitimId1.Visible = false;
            // 
            // OgretmenId
            // 
            this.OgretmenId.DataPropertyName = "ogretmenId";
            this.OgretmenId.HeaderText = "Öğretmen Id";
            this.OgretmenId.Name = "OgretmenId";
            this.OgretmenId.ReadOnly = true;
            this.OgretmenId.Visible = false;
            // 
            // SabitOgretmenAdi
            // 
            this.SabitOgretmenAdi.DataPropertyName = "SabitOgretmenAdi";
            this.SabitOgretmenAdi.HeaderText = "Öğretmen Adı";
            this.SabitOgretmenAdi.Name = "SabitOgretmenAdi";
            this.SabitOgretmenAdi.ReadOnly = true;
            this.SabitOgretmenAdi.Width = 200;
            // 
            // GorevTuru
            // 
            this.GorevTuru.DataPropertyName = "gorevTuru";
            this.GorevTuru.HeaderText = "Görev";
            this.GorevTuru.Name = "GorevTuru";
            this.GorevTuru.ReadOnly = true;
            this.GorevTuru.Width = 120;
            // 
            // Sinav_Iptl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 500);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dtGridOgretmenler);
            this.Controls.Add(this.dtGridDersler);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sinav_Iptl";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav İptal";
            this.Load += new System.EventHandler(this.Sinav_Iptl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridDersler;
        private System.Windows.Forms.DataGridView dtGridOgretmenler;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersDagitimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabitDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabitBolumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDagitimId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabitOgretmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevTuru;
    }
}