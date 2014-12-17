namespace SinavT
{
    partial class Ogretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmen));
            this.dataGridViewOgtmn = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.txtBolumu = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.labelUnvn = new System.Windows.Forms.Label();
            this.labelAdSyad = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.buttonCks = new System.Windows.Forms.Button();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EskiGozcuGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EskiKomisyonGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeniGozcuGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeniKomisyonGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgtmn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgtmn
            // 
            this.dataGridViewOgtmn.AllowUserToAddRows = false;
            this.dataGridViewOgtmn.AllowUserToDeleteRows = false;
            this.dataGridViewOgtmn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgtmn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adi,
            this.bolum,
            this.id,
            this.grup,
            this.EskiGozcuGorevi,
            this.EskiKomisyonGorevi,
            this.YeniGozcuGorevi,
            this.YeniKomisyonGorevi});
            this.dataGridViewOgtmn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOgtmn.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOgtmn.MultiSelect = false;
            this.dataGridViewOgtmn.Name = "dataGridViewOgtmn";
            this.dataGridViewOgtmn.ReadOnly = true;
            this.dataGridViewOgtmn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgtmn.Size = new System.Drawing.Size(709, 302);
            this.dataGridViewOgtmn.TabIndex = 10;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(27, 405);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 52);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtBolumu
            // 
            this.txtBolumu.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBolumu.Enabled = false;
            this.txtBolumu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumu.Location = new System.Drawing.Point(272, 352);
            this.txtBolumu.Multiline = true;
            this.txtBolumu.Name = "txtBolumu";
            this.txtBolumu.Size = new System.Drawing.Size(192, 23);
            this.txtBolumu.TabIndex = 2;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAdiSoyadi.Enabled = false;
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdiSoyadi.Location = new System.Drawing.Point(28, 352);
            this.txtAdiSoyadi.Multiline = true;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(192, 23);
            this.txtAdiSoyadi.TabIndex = 1;
            // 
            // labelUnvn
            // 
            this.labelUnvn.AutoSize = true;
            this.labelUnvn.BackColor = System.Drawing.Color.Transparent;
            this.labelUnvn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUnvn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUnvn.Location = new System.Drawing.Point(270, 328);
            this.labelUnvn.Name = "labelUnvn";
            this.labelUnvn.Size = new System.Drawing.Size(53, 14);
            this.labelUnvn.TabIndex = 10;
            this.labelUnvn.Text = "Bölümü";
            // 
            // labelAdSyad
            // 
            this.labelAdSyad.AutoSize = true;
            this.labelAdSyad.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSyad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdSyad.Location = new System.Drawing.Point(25, 328);
            this.labelAdSyad.Name = "labelAdSyad";
            this.labelAdSyad.Size = new System.Drawing.Size(76, 14);
            this.labelAdSyad.TabIndex = 8;
            this.labelAdSyad.Text = "Adı  Soyadı";
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(135, 405);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 52);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(243, 405);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 52);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(351, 405);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 52);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(459, 405);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(102, 52);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(591, 405);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(102, 52);
            this.buttonCks.TabIndex = 8;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.button6_Click);
            // 
            // adi
            // 
            this.adi.DataPropertyName = "adi";
            this.adi.HeaderText = "Öğretmen Adı";
            this.adi.Name = "adi";
            this.adi.ReadOnly = true;
            // 
            // bolum
            // 
            this.bolum.DataPropertyName = "bolum";
            this.bolum.HeaderText = "Branşı";
            this.bolum.Name = "bolum";
            this.bolum.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // grup
            // 
            this.grup.DataPropertyName = "grup";
            this.grup.HeaderText = "Grubu";
            this.grup.Name = "grup";
            this.grup.ReadOnly = true;
            this.grup.Visible = false;
            // 
            // EskiGozcuGorevi
            // 
            this.EskiGozcuGorevi.DataPropertyName = "eskiGozcuGorevi";
            this.EskiGozcuGorevi.HeaderText = "EskiGozcuGorevi";
            this.EskiGozcuGorevi.Name = "EskiGozcuGorevi";
            this.EskiGozcuGorevi.ReadOnly = true;
            this.EskiGozcuGorevi.Visible = false;
            // 
            // EskiKomisyonGorevi
            // 
            this.EskiKomisyonGorevi.DataPropertyName = "eskiKomisyonGorevi";
            this.EskiKomisyonGorevi.HeaderText = "EskiKomisyonGorevi";
            this.EskiKomisyonGorevi.Name = "EskiKomisyonGorevi";
            this.EskiKomisyonGorevi.ReadOnly = true;
            this.EskiKomisyonGorevi.Visible = false;
            // 
            // YeniGozcuGorevi
            // 
            this.YeniGozcuGorevi.DataPropertyName = "yeniGozcuGorevi";
            this.YeniGozcuGorevi.HeaderText = "YeniGozcuGorevi";
            this.YeniGozcuGorevi.Name = "YeniGozcuGorevi";
            this.YeniGozcuGorevi.ReadOnly = true;
            this.YeniGozcuGorevi.Visible = false;
            // 
            // YeniKomisyonGorevi
            // 
            this.YeniKomisyonGorevi.DataPropertyName = "yeniKomisyonGorevi";
            this.YeniKomisyonGorevi.HeaderText = "YeniKomisyonGorevi";
            this.YeniKomisyonGorevi.Name = "YeniKomisyonGorevi";
            this.YeniKomisyonGorevi.ReadOnly = true;
            this.YeniKomisyonGorevi.Visible = false;
            // 
            // Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewOgtmn);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtBolumu);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.labelUnvn);
            this.Controls.Add(this.labelAdSyad);
            this.Controls.Add(this.btnDuzenle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ogretmen";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Bilgi Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ogretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgtmn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOgtmn;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtBolumu;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label labelUnvn;
        private System.Windows.Forms.Label labelAdSyad;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn EskiGozcuGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn EskiKomisyonGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeniGozcuGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeniKomisyonGorevi;
    }
}