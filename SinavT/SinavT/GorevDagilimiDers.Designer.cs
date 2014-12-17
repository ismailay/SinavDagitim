namespace SinavT
{
    partial class GorevDagilimiDers
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
            this.dtGridDersler = new System.Windows.Forms.DataGridView();
            this.DersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSinavTuru = new System.Windows.Forms.ComboBox();
            this.labelDgtlmsDrslr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSinavSekli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).BeginInit();
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
            this.DersId,
            this.grup,
            this.DersAdi});
            this.dtGridDersler.Location = new System.Drawing.Point(10, 66);
            this.dtGridDersler.MultiSelect = false;
            this.dtGridDersler.Name = "dtGridDersler";
            this.dtGridDersler.ReadOnly = true;
            this.dtGridDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDersler.Size = new System.Drawing.Size(330, 343);
            this.dtGridDersler.TabIndex = 65;
            this.dtGridDersler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDersler_CellDoubleClick);
            this.dtGridDersler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtGridDersler_KeyUp);
            // 
            // DersId
            // 
            this.DersId.DataPropertyName = "DersId";
            this.DersId.HeaderText = "Id";
            this.DersId.Name = "DersId";
            this.DersId.ReadOnly = true;
            this.DersId.Visible = false;
            // 
            // grup
            // 
            this.grup.DataPropertyName = "Grup";
            this.grup.HeaderText = "Seviye";
            this.grup.Name = "grup";
            this.grup.ReadOnly = true;
            this.grup.Width = 70;
            // 
            // DersAdi
            // 
            this.DersAdi.DataPropertyName = "DersAdi";
            this.DersAdi.HeaderText = "Ders Adı";
            this.DersAdi.Name = "DersAdi";
            this.DersAdi.ReadOnly = true;
            this.DersAdi.Width = 200;
            // 
            // cmbSinavTuru
            // 
            this.cmbSinavTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinavTuru.FormattingEnabled = true;
            this.cmbSinavTuru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSinavTuru.Items.AddRange(new object[] {
            "Yazılı",
            "Sözlü",
            "Uygulama"});
            this.cmbSinavTuru.Location = new System.Drawing.Point(95, 7);
            this.cmbSinavTuru.Name = "cmbSinavTuru";
            this.cmbSinavTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbSinavTuru.TabIndex = 66;
            this.cmbSinavTuru.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSinavSekli_KeyUp);
            // 
            // labelDgtlmsDrslr
            // 
            this.labelDgtlmsDrslr.AutoSize = true;
            this.labelDgtlmsDrslr.BackColor = System.Drawing.Color.Transparent;
            this.labelDgtlmsDrslr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDgtlmsDrslr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDgtlmsDrslr.Location = new System.Drawing.Point(7, 9);
            this.labelDgtlmsDrslr.Name = "labelDgtlmsDrslr";
            this.labelDgtlmsDrslr.Size = new System.Drawing.Size(72, 14);
            this.labelDgtlmsDrslr.TabIndex = 67;
            this.labelDgtlmsDrslr.Text = "Sınav Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 69;
            this.label1.Text = "Sınav Şekli";
            // 
            // cmbSinavSekli
            // 
            this.cmbSinavSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinavSekli.FormattingEnabled = true;
            this.cmbSinavSekli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSinavSekli.Items.AddRange(new object[] {
            "Yazili",
            "Sözlü",
            "Uygulama"});
            this.cmbSinavSekli.Location = new System.Drawing.Point(95, 36);
            this.cmbSinavSekli.Name = "cmbSinavSekli";
            this.cmbSinavSekli.Size = new System.Drawing.Size(121, 21);
            this.cmbSinavSekli.TabIndex = 68;
            // 
            // GorevDagilimiDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 417);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSinavSekli);
            this.Controls.Add(this.labelDgtlmsDrslr);
            this.Controls.Add(this.cmbSinavTuru);
            this.Controls.Add(this.dtGridDersler);
            this.Name = "GorevDagilimiDers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dersler ve Komisyon Üyesi Ekleme";
            this.Load += new System.EventHandler(this.GorevDagilimiDers_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GorevDagilimiDers_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GorevDagilimiDers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridDersler;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.ComboBox cmbSinavTuru;
        private System.Windows.Forms.Label labelDgtlmsDrslr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSinavSekli;
    }
}