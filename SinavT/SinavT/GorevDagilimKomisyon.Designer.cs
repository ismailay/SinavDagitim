namespace SinavT
{
    partial class GorevDagilimKomisyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevDagilimKomisyon));
            this.dtGridOgretmen = new System.Windows.Forms.DataGridView();
            this.lstKomisyon = new System.Windows.Forms.ListBox();
            this.labelKmsynUye = new System.Windows.Forms.Label();
            this.buttonCks = new System.Windows.Forms.Button();
            this.OgretmenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridOgretmen
            // 
            this.dtGridOgretmen.AllowUserToAddRows = false;
            this.dtGridOgretmen.AllowUserToDeleteRows = false;
            this.dtGridOgretmen.AllowUserToResizeColumns = false;
            this.dtGridOgretmen.AllowUserToResizeRows = false;
            this.dtGridOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOgretmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgretmenId,
            this.OgretmenAdi});
            this.dtGridOgretmen.Location = new System.Drawing.Point(10, 10);
            this.dtGridOgretmen.MultiSelect = false;
            this.dtGridOgretmen.Name = "dtGridOgretmen";
            this.dtGridOgretmen.ReadOnly = true;
            this.dtGridOgretmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOgretmen.Size = new System.Drawing.Size(240, 270);
            this.dtGridOgretmen.TabIndex = 0;
            this.dtGridOgretmen.TabStop = false;
            this.dtGridOgretmen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridOgretmen_CellDoubleClick);
            this.dtGridOgretmen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtGridOgretmen_KeyUp);
            // 
            // lstKomisyon
            // 
            this.lstKomisyon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKomisyon.FormattingEnabled = true;
            this.lstKomisyon.Location = new System.Drawing.Point(10, 300);
            this.lstKomisyon.Name = "lstKomisyon";
            this.lstKomisyon.Size = new System.Drawing.Size(185, 95);
            this.lstKomisyon.TabIndex = 1;
            this.lstKomisyon.TabStop = false;
            this.lstKomisyon.DoubleClick += new System.EventHandler(this.lstKomisyon_DoubleClick);
            this.lstKomisyon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstKomisyon_KeyUp);
            // 
            // labelKmsynUye
            // 
            this.labelKmsynUye.AutoSize = true;
            this.labelKmsynUye.BackColor = System.Drawing.Color.Transparent;
            this.labelKmsynUye.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKmsynUye.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelKmsynUye.Location = new System.Drawing.Point(12, 284);
            this.labelKmsynUye.Name = "labelKmsynUye";
            this.labelKmsynUye.Size = new System.Drawing.Size(110, 14);
            this.labelKmsynUye.TabIndex = 2;
            this.labelKmsynUye.Text = "Komisyon Üyeleri";
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(203, 343);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(47, 52);
            this.buttonCks.TabIndex = 82;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // OgretmenId
            // 
            this.OgretmenId.DataPropertyName = "OgretmenId";
            this.OgretmenId.HeaderText = "Id";
            this.OgretmenId.Name = "OgretmenId";
            this.OgretmenId.ReadOnly = true;
            this.OgretmenId.Visible = false;
            // 
            // OgretmenAdi
            // 
            this.OgretmenAdi.DataPropertyName = "OgretmenAdi";
            this.OgretmenAdi.HeaderText = "Öğretmen Adi";
            this.OgretmenAdi.Name = "OgretmenAdi";
            this.OgretmenAdi.ReadOnly = true;
            this.OgretmenAdi.Width = 180;
            // 
            // GorevDagilimKomisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 407);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.lstKomisyon);
            this.Controls.Add(this.labelKmsynUye);
            this.Controls.Add(this.dtGridOgretmen);
            this.Name = "GorevDagilimKomisyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Komisyon Görevi Ekleme";
            this.Load += new System.EventHandler(this.GorevDagilimKomisyon_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GorevDagilimKomisyon_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridOgretmen;
        private System.Windows.Forms.ListBox lstKomisyon;
        private System.Windows.Forms.Label labelKmsynUye;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenAdi;
    }
}