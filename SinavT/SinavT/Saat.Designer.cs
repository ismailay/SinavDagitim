namespace SinavT
{
    partial class Saat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saat));
            this.dataGridSaat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaatAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCks = new System.Windows.Forms.Button();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSaat
            // 
            this.dataGridSaat.AllowUserToAddRows = false;
            this.dataGridSaat.AllowUserToDeleteRows = false;
            this.dataGridSaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SaatAdi});
            this.dataGridSaat.Location = new System.Drawing.Point(12, 43);
            this.dataGridSaat.MultiSelect = false;
            this.dataGridSaat.Name = "dataGridSaat";
            this.dataGridSaat.ReadOnly = true;
            this.dataGridSaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSaat.Size = new System.Drawing.Size(120, 197);
            this.dataGridSaat.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SaatAdi
            // 
            this.SaatAdi.DataPropertyName = "saat";
            this.SaatAdi.HeaderText = "Saat";
            this.SaatAdi.Name = "SaatAdi";
            this.SaatAdi.ReadOnly = true;
            this.SaatAdi.Width = 60;
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(138, 207);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 33);
            this.buttonCks.TabIndex = 4;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.Enabled = false;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45"});
            this.cmbSaat.Location = new System.Drawing.Point(12, 13);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(108, 21);
            this.cmbSaat.TabIndex = 5;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(138, 159);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(68, 33);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(138, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(68, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(138, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 33);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(136, 63);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Saat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.dataGridSaat);
            this.Name = "Saat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saat";
            this.Load += new System.EventHandler(this.Saat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSaat;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaatAdi;
    }
}