namespace SinavT
{
    partial class YedkAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YedkAlma));
            this.panelAktifSnv = new System.Windows.Forms.Panel();
            this.textAktfSnvDnmi = new System.Windows.Forms.Label();
            this.panelSnvDnmIsmi = new System.Windows.Forms.Panel();
            this.textSnvDnmIsmi = new System.Windows.Forms.Label();
            this.buttonYedekAl = new System.Windows.Forms.Button();
            this.txtYedekAdi = new System.Windows.Forms.TextBox();
            this.buttonGeriAl = new System.Windows.Forms.Button();
            this.buttonYedekSil = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.dtGridViewYedekler = new System.Windows.Forms.DataGridView();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yedekTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yedekSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAktifSnv.SuspendLayout();
            this.panelSnvDnmIsmi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewYedekler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAktifSnv
            // 
            this.panelAktifSnv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAktifSnv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAktifSnv.Controls.Add(this.textAktfSnvDnmi);
            this.panelAktifSnv.Location = new System.Drawing.Point(12, 12);
            this.panelAktifSnv.Name = "panelAktifSnv";
            this.panelAktifSnv.Size = new System.Drawing.Size(685, 38);
            this.panelAktifSnv.TabIndex = 0;
            // 
            // textAktfSnvDnmi
            // 
            this.textAktfSnvDnmi.AutoSize = true;
            this.textAktfSnvDnmi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAktfSnvDnmi.ForeColor = System.Drawing.Color.Navy;
            this.textAktfSnvDnmi.Location = new System.Drawing.Point(252, 9);
            this.textAktfSnvDnmi.Name = "textAktfSnvDnmi";
            this.textAktfSnvDnmi.Size = new System.Drawing.Size(165, 19);
            this.textAktfSnvDnmi.TabIndex = 3;
            this.textAktfSnvDnmi.Text = "Aktif Sınav Dönemi";
            // 
            // panelSnvDnmIsmi
            // 
            this.panelSnvDnmIsmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSnvDnmIsmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSnvDnmIsmi.Controls.Add(this.textSnvDnmIsmi);
            this.panelSnvDnmIsmi.Location = new System.Drawing.Point(12, 51);
            this.panelSnvDnmIsmi.Name = "panelSnvDnmIsmi";
            this.panelSnvDnmIsmi.Size = new System.Drawing.Size(685, 31);
            this.panelSnvDnmIsmi.TabIndex = 1;
            // 
            // textSnvDnmIsmi
            // 
            this.textSnvDnmIsmi.AutoSize = true;
            this.textSnvDnmIsmi.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSnvDnmIsmi.ForeColor = System.Drawing.Color.Black;
            this.textSnvDnmIsmi.Location = new System.Drawing.Point(270, 5);
            this.textSnvDnmIsmi.Name = "textSnvDnmIsmi";
            this.textSnvDnmIsmi.Size = new System.Drawing.Size(124, 16);
            this.textSnvDnmIsmi.TabIndex = 4;
            this.textSnvDnmIsmi.Text = "Sınav Dönemi İsmi";
            // 
            // buttonYedekAl
            // 
            this.buttonYedekAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYedekAl.BackgroundImage")));
            this.buttonYedekAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYedekAl.Location = new System.Drawing.Point(12, 88);
            this.buttonYedekAl.Name = "buttonYedekAl";
            this.buttonYedekAl.Size = new System.Drawing.Size(87, 34);
            this.buttonYedekAl.TabIndex = 2;
            this.buttonYedekAl.UseVisualStyleBackColor = true;
            this.buttonYedekAl.Click += new System.EventHandler(this.buttonYedekAl_Click);
            // 
            // txtYedekAdi
            // 
            this.txtYedekAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYedekAdi.Location = new System.Drawing.Point(114, 93);
            this.txtYedekAdi.Multiline = true;
            this.txtYedekAdi.Name = "txtYedekAdi";
            this.txtYedekAdi.Size = new System.Drawing.Size(571, 26);
            this.txtYedekAdi.TabIndex = 3;
            // 
            // buttonGeriAl
            // 
            this.buttonGeriAl.Enabled = false;
            this.buttonGeriAl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeriAl.Location = new System.Drawing.Point(12, 441);
            this.buttonGeriAl.Name = "buttonGeriAl";
            this.buttonGeriAl.Size = new System.Drawing.Size(104, 35);
            this.buttonGeriAl.TabIndex = 5;
            this.buttonGeriAl.Text = "Yedeten Geri Al";
            this.buttonGeriAl.UseVisualStyleBackColor = true;
            this.buttonGeriAl.Click += new System.EventHandler(this.buttonGeriAl_Click);
            // 
            // buttonYedekSil
            // 
            this.buttonYedekSil.Enabled = false;
            this.buttonYedekSil.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYedekSil.Location = new System.Drawing.Point(122, 441);
            this.buttonYedekSil.Name = "buttonYedekSil";
            this.buttonYedekSil.Size = new System.Drawing.Size(104, 35);
            this.buttonYedekSil.TabIndex = 6;
            this.buttonYedekSil.Text = "Yedegi Sil";
            this.buttonYedekSil.UseVisualStyleBackColor = true;
            this.buttonYedekSil.Click += new System.EventHandler(this.buttonYedekSil_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKapat.BackgroundImage")));
            this.buttonKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonKapat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKapat.Location = new System.Drawing.Point(593, 441);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(104, 35);
            this.buttonKapat.TabIndex = 7;
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // dtGridViewYedekler
            // 
            this.dtGridViewYedekler.AllowUserToAddRows = false;
            this.dtGridViewYedekler.AllowUserToDeleteRows = false;
            this.dtGridViewYedekler.AllowUserToResizeColumns = false;
            this.dtGridViewYedekler.AllowUserToResizeRows = false;
            this.dtGridViewYedekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewYedekler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adi,
            this.yedekTarihi,
            this.yedekSaat,
            this.kurumAdi,
            this.donemYili,
            this.donemAdi,
            this.baslangicTarihi,
            this.bitisTarihi,
            this.dosyaAdi,
            this.id});
            this.dtGridViewYedekler.Location = new System.Drawing.Point(12, 128);
            this.dtGridViewYedekler.MultiSelect = false;
            this.dtGridViewYedekler.Name = "dtGridViewYedekler";
            this.dtGridViewYedekler.ReadOnly = true;
            this.dtGridViewYedekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewYedekler.Size = new System.Drawing.Size(685, 307);
            this.dtGridViewYedekler.TabIndex = 8;
            // 
            // adi
            // 
            this.adi.DataPropertyName = "adi";
            this.adi.HeaderText = "Yedek Adı";
            this.adi.Name = "adi";
            this.adi.Width = 140;
            // 
            // yedekTarihi
            // 
            this.yedekTarihi.DataPropertyName = "yedekTarihi";
            this.yedekTarihi.HeaderText = "Yedek Tarihi";
            this.yedekTarihi.Name = "yedekTarihi";
            this.yedekTarihi.Width = 65;
            // 
            // yedekSaat
            // 
            this.yedekSaat.DataPropertyName = "yedekSaat";
            this.yedekSaat.HeaderText = "Yedek Saati";
            this.yedekSaat.Name = "yedekSaat";
            this.yedekSaat.Width = 40;
            // 
            // kurumAdi
            // 
            this.kurumAdi.DataPropertyName = "kurumAdi";
            this.kurumAdi.HeaderText = "Kurum Adı";
            this.kurumAdi.Name = "kurumAdi";
            this.kurumAdi.Width = 140;
            // 
            // donemYili
            // 
            this.donemYili.DataPropertyName = "donemYili";
            this.donemYili.HeaderText = "Öğretim Yılı";
            this.donemYili.Name = "donemYili";
            this.donemYili.Width = 60;
            // 
            // donemAdi
            // 
            this.donemAdi.DataPropertyName = "donemAdi";
            this.donemAdi.HeaderText = "Dönem Adı";
            this.donemAdi.Name = "donemAdi";
            this.donemAdi.Width = 50;
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.DataPropertyName = "baslangicTarihi";
            this.baslangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Width = 65;
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.DataPropertyName = "bitisTarihi";
            this.bitisTarihi.HeaderText = "Bitiş Tarihi";
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Width = 65;
            // 
            // dosyaAdi
            // 
            this.dosyaAdi.DataPropertyName = "dosyaAdi";
            this.dosyaAdi.HeaderText = "Dosya Adı";
            this.dosyaAdi.Name = "dosyaAdi";
            this.dosyaAdi.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // YedkAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dtGridViewYedekler);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonYedekSil);
            this.Controls.Add(this.buttonGeriAl);
            this.Controls.Add(this.txtYedekAdi);
            this.Controls.Add(this.buttonYedekAl);
            this.Controls.Add(this.panelSnvDnmIsmi);
            this.Controls.Add(this.panelAktifSnv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YedkAlma";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedek Alma";
            this.Load += new System.EventHandler(this.YedkAlma_Load);
            this.panelAktifSnv.ResumeLayout(false);
            this.panelAktifSnv.PerformLayout();
            this.panelSnvDnmIsmi.ResumeLayout(false);
            this.panelSnvDnmIsmi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewYedekler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAktifSnv;
        private System.Windows.Forms.Panel panelSnvDnmIsmi;
        private System.Windows.Forms.Label textAktfSnvDnmi;
        private System.Windows.Forms.Label textSnvDnmIsmi;
        private System.Windows.Forms.Button buttonYedekAl;
        private System.Windows.Forms.TextBox txtYedekAdi;
        private System.Windows.Forms.Button buttonGeriAl;
        private System.Windows.Forms.Button buttonYedekSil;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.DataGridView dtGridViewYedekler;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yedekTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yedekSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}