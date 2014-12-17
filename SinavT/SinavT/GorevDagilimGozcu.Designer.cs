namespace SinavT
{
    partial class GorevDagilimGozcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevDagilimGozcu));
            this.lstGozetmen = new System.Windows.Forms.ListBox();
            this.labelKmsynUye = new System.Windows.Forms.Label();
            this.dtGridOgretmen = new System.Windows.Forms.DataGridView();
            this.OgretmenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGozetmen
            // 
            this.lstGozetmen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGozetmen.FormattingEnabled = true;
            this.lstGozetmen.Location = new System.Drawing.Point(9, 301);
            this.lstGozetmen.Name = "lstGozetmen";
            this.lstGozetmen.Size = new System.Drawing.Size(185, 95);
            this.lstGozetmen.TabIndex = 4;
            this.lstGozetmen.TabStop = false;
            this.lstGozetmen.DoubleClick += new System.EventHandler(this.lstGozetmen_DoubleClick);
            this.lstGozetmen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstGozetmen_KeyUp);
            // 
            // labelKmsynUye
            // 
            this.labelKmsynUye.AutoSize = true;
            this.labelKmsynUye.BackColor = System.Drawing.Color.Transparent;
            this.labelKmsynUye.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKmsynUye.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelKmsynUye.Location = new System.Drawing.Point(11, 285);
            this.labelKmsynUye.Name = "labelKmsynUye";
            this.labelKmsynUye.Size = new System.Drawing.Size(83, 14);
            this.labelKmsynUye.TabIndex = 5;
            this.labelKmsynUye.Text = "Gözetmenler";
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
            this.dtGridOgretmen.Location = new System.Drawing.Point(9, 11);
            this.dtGridOgretmen.MultiSelect = false;
            this.dtGridOgretmen.Name = "dtGridOgretmen";
            this.dtGridOgretmen.ReadOnly = true;
            this.dtGridOgretmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOgretmen.Size = new System.Drawing.Size(240, 270);
            this.dtGridOgretmen.TabIndex = 3;
            this.dtGridOgretmen.TabStop = false;
            this.dtGridOgretmen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridOgretmen_CellDoubleClick);
            this.dtGridOgretmen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtGridOgretmen_KeyUp);
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
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(202, 344);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(47, 52);
            this.buttonCks.TabIndex = 83;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // GorevDagilimGozcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 407);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.lstGozetmen);
            this.Controls.Add(this.labelKmsynUye);
            this.Controls.Add(this.dtGridOgretmen);
            this.Name = "GorevDagilimGozcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gözcülük Görevi Ekleme";
            this.Load += new System.EventHandler(this.GorevDagilimGozcu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GorevDagilimGozcu_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGozetmen;
        private System.Windows.Forms.Label labelKmsynUye;
        private System.Windows.Forms.DataGridView dtGridOgretmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenAdi;
        private System.Windows.Forms.Button buttonCks;
    }
}