namespace SinavT
{
    partial class ImzaCetveli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImzaCetveli));
            this.buttonRpr = new System.Windows.Forms.Button();
            this.buttonCks = new System.Windows.Forms.Button();
            this.dtGridOgretmenler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarihId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstTarih = new System.Windows.Forms.ListBox();
            this.labelOgrtmn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRpr
            // 
            this.buttonRpr.Image = ((System.Drawing.Image)(resources.GetObject("buttonRpr.Image")));
            this.buttonRpr.Location = new System.Drawing.Point(68, 428);
            this.buttonRpr.Name = "buttonRpr";
            this.buttonRpr.Size = new System.Drawing.Size(68, 52);
            this.buttonRpr.TabIndex = 65;
            this.buttonRpr.UseVisualStyleBackColor = true;
            this.buttonRpr.Click += new System.EventHandler(this.buttonRpr_Click);
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(621, 428);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 64;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // dtGridOgretmenler
            // 
            this.dtGridOgretmenler.AllowUserToAddRows = false;
            this.dtGridOgretmenler.AllowUserToDeleteRows = false;
            this.dtGridOgretmenler.AllowUserToResizeColumns = false;
            this.dtGridOgretmenler.AllowUserToResizeRows = false;
            this.dtGridOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOgretmenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TarihId,
            this.tarih,
            this.adi,
            this.saat,
            this.gorevTuru});
            this.dtGridOgretmenler.Enabled = false;
            this.dtGridOgretmenler.Location = new System.Drawing.Point(201, 38);
            this.dtGridOgretmenler.MultiSelect = false;
            this.dtGridOgretmenler.Name = "dtGridOgretmenler";
            this.dtGridOgretmenler.ReadOnly = true;
            this.dtGridOgretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOgretmenler.Size = new System.Drawing.Size(500, 355);
            this.dtGridOgretmenler.TabIndex = 63;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TarihId
            // 
            this.TarihId.DataPropertyName = "TarihId";
            this.TarihId.HeaderText = "Tarih Id";
            this.TarihId.Name = "TarihId";
            this.TarihId.ReadOnly = true;
            this.TarihId.Visible = false;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            this.tarih.Visible = false;
            // 
            // adi
            // 
            this.adi.DataPropertyName = "adi";
            this.adi.HeaderText = "Öğretmen Adı Soyadı";
            this.adi.Name = "adi";
            this.adi.ReadOnly = true;
            this.adi.Width = 210;
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "Sınav Saati";
            this.saat.Name = "saat";
            this.saat.ReadOnly = true;
            // 
            // gorevTuru
            // 
            this.gorevTuru.DataPropertyName = "gorevTuru";
            this.gorevTuru.HeaderText = "Görev Türü";
            this.gorevTuru.Name = "gorevTuru";
            this.gorevTuru.ReadOnly = true;
            this.gorevTuru.Width = 130;
            // 
            // lstTarih
            // 
            this.lstTarih.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.Location = new System.Drawing.Point(19, 38);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(168, 355);
            this.lstTarih.TabIndex = 62;
            this.lstTarih.Click += new System.EventHandler(this.lstTarih_Click);
            // 
            // labelOgrtmn
            // 
            this.labelOgrtmn.AutoSize = true;
            this.labelOgrtmn.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrtmn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrtmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOgrtmn.Location = new System.Drawing.Point(20, 21);
            this.labelOgrtmn.Name = "labelOgrtmn";
            this.labelOgrtmn.Size = new System.Drawing.Size(77, 14);
            this.labelOgrtmn.TabIndex = 61;
            this.labelOgrtmn.Text = "Sınav Tarihi";
            // 
            // ImzaCetveli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRpr);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.dtGridOgretmenler);
            this.Controls.Add(this.lstTarih);
            this.Controls.Add(this.labelOgrtmn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImzaCetveli";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav İmza Çetveli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImzaCetveli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRpr;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.DataGridView dtGridOgretmenler;
        private System.Windows.Forms.ListBox lstTarih;
        private System.Windows.Forms.Label labelOgrtmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevTuru;
    }
}