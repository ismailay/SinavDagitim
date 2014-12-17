namespace SinavT
{
    partial class SinavGreviIslemlri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavGreviIslemlri));
            this.dtGridOgretmenler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniKomisyonGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eskiKomisyonGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniGozcuGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eskiGozcuGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCks = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdSyad = new System.Windows.Forms.Label();
            this.txtEskiGozcu = new System.Windows.Forms.TextBox();
            this.txtEskiKomisyon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridOgretmenler
            // 
            this.dtGridOgretmenler.AllowUserToAddRows = false;
            this.dtGridOgretmenler.AllowUserToDeleteRows = false;
            this.dtGridOgretmenler.AllowUserToResizeColumns = false;
            this.dtGridOgretmenler.AllowUserToResizeRows = false;
            this.dtGridOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOgretmenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.grup,
            this.adi,
            this.bolum,
            this.yeniKomisyonGorevi,
            this.eskiKomisyonGorevi,
            this.yeniGozcuGorevi,
            this.eskiGozcuGorevi});
            this.dtGridOgretmenler.Location = new System.Drawing.Point(12, 72);
            this.dtGridOgretmenler.MultiSelect = false;
            this.dtGridOgretmenler.Name = "dtGridOgretmenler";
            this.dtGridOgretmenler.ReadOnly = true;
            this.dtGridOgretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOgretmenler.Size = new System.Drawing.Size(685, 416);
            this.dtGridOgretmenler.TabIndex = 0;
            this.dtGridOgretmenler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridOgretmenler_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // grup
            // 
            this.grup.DataPropertyName = "grup";
            this.grup.HeaderText = "grup";
            this.grup.Name = "grup";
            this.grup.ReadOnly = true;
            this.grup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grup.Visible = false;
            // 
            // adi
            // 
            this.adi.DataPropertyName = "adi";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adi.DefaultCellStyle = dataGridViewCellStyle1;
            this.adi.HeaderText = "Ogretmen Adı";
            this.adi.Name = "adi";
            this.adi.ReadOnly = true;
            this.adi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.adi.Width = 160;
            // 
            // bolum
            // 
            this.bolum.DataPropertyName = "bolum";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bolum.DefaultCellStyle = dataGridViewCellStyle2;
            this.bolum.HeaderText = "Branşı";
            this.bolum.Name = "bolum";
            this.bolum.ReadOnly = true;
            this.bolum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bolum.Width = 125;
            // 
            // yeniKomisyonGorevi
            // 
            this.yeniKomisyonGorevi.DataPropertyName = "yeniKomisyonGorevi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yeniKomisyonGorevi.DefaultCellStyle = dataGridViewCellStyle3;
            this.yeniKomisyonGorevi.HeaderText = "Yeni Komisyon Görevi";
            this.yeniKomisyonGorevi.Name = "yeniKomisyonGorevi";
            this.yeniKomisyonGorevi.ReadOnly = true;
            this.yeniKomisyonGorevi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yeniKomisyonGorevi.Width = 85;
            // 
            // eskiKomisyonGorevi
            // 
            this.eskiKomisyonGorevi.DataPropertyName = "eskiKomisyonGorevi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eskiKomisyonGorevi.DefaultCellStyle = dataGridViewCellStyle4;
            this.eskiKomisyonGorevi.HeaderText = "Eski Komisyon Görevi";
            this.eskiKomisyonGorevi.Name = "eskiKomisyonGorevi";
            this.eskiKomisyonGorevi.ReadOnly = true;
            this.eskiKomisyonGorevi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.eskiKomisyonGorevi.Width = 85;
            // 
            // yeniGozcuGorevi
            // 
            this.yeniGozcuGorevi.DataPropertyName = "yeniGozcuGorevi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yeniGozcuGorevi.DefaultCellStyle = dataGridViewCellStyle5;
            this.yeniGozcuGorevi.HeaderText = "Yeni Gözcü Görevi";
            this.yeniGozcuGorevi.Name = "yeniGozcuGorevi";
            this.yeniGozcuGorevi.ReadOnly = true;
            this.yeniGozcuGorevi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yeniGozcuGorevi.Width = 85;
            // 
            // eskiGozcuGorevi
            // 
            this.eskiGozcuGorevi.DataPropertyName = "eskiGozcuGorevi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eskiGozcuGorevi.DefaultCellStyle = dataGridViewCellStyle6;
            this.eskiGozcuGorevi.HeaderText = "Eski Gözcü Görevi";
            this.eskiGozcuGorevi.Name = "eskiGozcuGorevi";
            this.eskiGozcuGorevi.ReadOnly = true;
            this.eskiGozcuGorevi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.eskiGozcuGorevi.Width = 85;
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(180, 12);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(50, 50);
            this.buttonCks.TabIndex = 12;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(124, 12);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(50, 50);
            this.btnVazgec.TabIndex = 11;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(68, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 50);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(12, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(50, 50);
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelAdSyad);
            this.groupBox1.Controls.Add(this.txtEskiGozcu);
            this.groupBox1.Controls.Add(this.txtEskiKomisyon);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eski Gözcülük Görevi";
            // 
            // labelAdSyad
            // 
            this.labelAdSyad.AutoSize = true;
            this.labelAdSyad.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSyad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdSyad.Location = new System.Drawing.Point(6, 18);
            this.labelAdSyad.Name = "labelAdSyad";
            this.labelAdSyad.Size = new System.Drawing.Size(135, 14);
            this.labelAdSyad.TabIndex = 17;
            this.labelAdSyad.Text = "Eski Komisyon Görevi";
            // 
            // txtEskiGozcu
            // 
            this.txtEskiGozcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiGozcu.Location = new System.Drawing.Point(361, 16);
            this.txtEskiGozcu.MaxLength = 2;
            this.txtEskiGozcu.Name = "txtEskiGozcu";
            this.txtEskiGozcu.Size = new System.Drawing.Size(44, 20);
            this.txtEskiGozcu.TabIndex = 16;
            this.txtEskiGozcu.Click += new System.EventHandler(this.txtEskiGozcu_Click);
            this.txtEskiGozcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEskiGozcu_KeyPress);
            this.txtEskiGozcu.Enter += new System.EventHandler(this.txtEskiGozcu_Enter);
            // 
            // txtEskiKomisyon
            // 
            this.txtEskiKomisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiKomisyon.Location = new System.Drawing.Point(147, 16);
            this.txtEskiKomisyon.MaxLength = 2;
            this.txtEskiKomisyon.Name = "txtEskiKomisyon";
            this.txtEskiKomisyon.Size = new System.Drawing.Size(45, 20);
            this.txtEskiKomisyon.TabIndex = 15;
            this.txtEskiKomisyon.Click += new System.EventHandler(this.txtEskiKomisyon_Click);
            this.txtEskiKomisyon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEskiKomisyon_KeyPress);
            this.txtEskiKomisyon.Enter += new System.EventHandler(this.txtEskiKomisyon_Enter);
            // 
            // SinavGreviIslemlri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dtGridOgretmenler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinavGreviIslemlri";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Görevi İşlemleri";
            this.Load += new System.EventHandler(this.SinavGreviIslemlri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOgretmenler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridOgretmenler;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdSyad;
        private System.Windows.Forms.TextBox txtEskiGozcu;
        private System.Windows.Forms.TextBox txtEskiKomisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeniKomisyonGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn eskiKomisyonGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeniGozcuGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn eskiGozcuGorevi;
    }
}