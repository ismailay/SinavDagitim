namespace SinavT
{
    partial class Nobetc_Ogretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nobetc_Ogretmen));
            this.lstTarih = new System.Windows.Forms.ListBox();
            this.labelSnvGnlri = new System.Windows.Forms.Label();
            this.labelNbtcMdrYrdm = new System.Windows.Forms.Label();
            this.labelNtcOgrtmn = new System.Windows.Forms.Label();
            this.lstOgretmenler = new System.Windows.Forms.ListBox();
            this.labelOgrtmn = new System.Windows.Forms.Label();
            this.lstMudurYardimcisi = new System.Windows.Forms.ListBox();
            this.labelMdrYrdmc = new System.Windows.Forms.Label();
            this.buttonCks = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.labelTplm = new System.Windows.Forms.Label();
            this.labelTpmSayi = new System.Windows.Forms.Label();
            this.labelNot = new System.Windows.Forms.Label();
            this.txtNobetciMudurYardimcisi = new System.Windows.Forms.TextBox();
            this.txtNobetciOgretmen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTarih
            // 
            this.lstTarih.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.Location = new System.Drawing.Point(13, 26);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(130, 368);
            this.lstTarih.TabIndex = 39;
            this.lstTarih.Click += new System.EventHandler(this.lstTarih_Click);
            // 
            // labelSnvGnlri
            // 
            this.labelSnvGnlri.AutoSize = true;
            this.labelSnvGnlri.BackColor = System.Drawing.Color.Transparent;
            this.labelSnvGnlri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSnvGnlri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSnvGnlri.Location = new System.Drawing.Point(12, 9);
            this.labelSnvGnlri.Name = "labelSnvGnlri";
            this.labelSnvGnlri.Size = new System.Drawing.Size(86, 14);
            this.labelSnvGnlri.TabIndex = 38;
            this.labelSnvGnlri.Text = "Sınav Günleri";
            // 
            // labelNbtcMdrYrdm
            // 
            this.labelNbtcMdrYrdm.AutoSize = true;
            this.labelNbtcMdrYrdm.BackColor = System.Drawing.Color.Transparent;
            this.labelNbtcMdrYrdm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNbtcMdrYrdm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNbtcMdrYrdm.Location = new System.Drawing.Point(149, 9);
            this.labelNbtcMdrYrdm.Name = "labelNbtcMdrYrdm";
            this.labelNbtcMdrYrdm.Size = new System.Drawing.Size(160, 14);
            this.labelNbtcMdrYrdm.TabIndex = 40;
            this.labelNbtcMdrYrdm.Text = "Nöbetci Müdür Yardımcısı\r\n";
            // 
            // labelNtcOgrtmn
            // 
            this.labelNtcOgrtmn.AutoSize = true;
            this.labelNtcOgrtmn.BackColor = System.Drawing.Color.Transparent;
            this.labelNtcOgrtmn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNtcOgrtmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNtcOgrtmn.Location = new System.Drawing.Point(348, 9);
            this.labelNtcOgrtmn.Name = "labelNtcOgrtmn";
            this.labelNtcOgrtmn.Size = new System.Drawing.Size(118, 14);
            this.labelNtcOgrtmn.TabIndex = 42;
            this.labelNtcOgrtmn.Text = "Nöbetci Öğretmen\r\n";
            // 
            // lstOgretmenler
            // 
            this.lstOgretmenler.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOgretmenler.FormattingEnabled = true;
            this.lstOgretmenler.Location = new System.Drawing.Point(342, 67);
            this.lstOgretmenler.Name = "lstOgretmenler";
            this.lstOgretmenler.Size = new System.Drawing.Size(168, 329);
            this.lstOgretmenler.TabIndex = 47;
            this.lstOgretmenler.DoubleClick += new System.EventHandler(this.lstOgretmenler_DoubleClick);
            // 
            // labelOgrtmn
            // 
            this.labelOgrtmn.AutoSize = true;
            this.labelOgrtmn.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrtmn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrtmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOgrtmn.Location = new System.Drawing.Point(342, 50);
            this.labelOgrtmn.Name = "labelOgrtmn";
            this.labelOgrtmn.Size = new System.Drawing.Size(68, 14);
            this.labelOgrtmn.TabIndex = 46;
            this.labelOgrtmn.Text = "Öğretmen\r\n";
            // 
            // lstMudurYardimcisi
            // 
            this.lstMudurYardimcisi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMudurYardimcisi.FormattingEnabled = true;
            this.lstMudurYardimcisi.Location = new System.Drawing.Point(152, 67);
            this.lstMudurYardimcisi.Name = "lstMudurYardimcisi";
            this.lstMudurYardimcisi.Size = new System.Drawing.Size(168, 264);
            this.lstMudurYardimcisi.TabIndex = 45;
            this.lstMudurYardimcisi.DoubleClick += new System.EventHandler(this.lstMudurYardimcisi_DoubleClick);
            // 
            // labelMdrYrdmc
            // 
            this.labelMdrYrdmc.AutoSize = true;
            this.labelMdrYrdmc.BackColor = System.Drawing.Color.Transparent;
            this.labelMdrYrdmc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMdrYrdmc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMdrYrdmc.Location = new System.Drawing.Point(149, 50);
            this.labelMdrYrdmc.Name = "labelMdrYrdmc";
            this.labelMdrYrdmc.Size = new System.Drawing.Size(110, 14);
            this.labelMdrYrdmc.TabIndex = 44;
            this.labelMdrYrdmc.Text = "Müdür Yardımcısı\r\n";
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(252, 342);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 49;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(152, 342);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(68, 52);
            this.btnKaydet.TabIndex = 48;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelTplm
            // 
            this.labelTplm.AutoSize = true;
            this.labelTplm.BackColor = System.Drawing.Color.Transparent;
            this.labelTplm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTplm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTplm.Location = new System.Drawing.Point(84, 411);
            this.labelTplm.Name = "labelTplm";
            this.labelTplm.Size = new System.Drawing.Size(59, 14);
            this.labelTplm.TabIndex = 50;
            this.labelTplm.Text = "Toplam :";
            // 
            // labelTpmSayi
            // 
            this.labelTpmSayi.AutoSize = true;
            this.labelTpmSayi.BackColor = System.Drawing.Color.Transparent;
            this.labelTpmSayi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTpmSayi.ForeColor = System.Drawing.Color.Crimson;
            this.labelTpmSayi.Location = new System.Drawing.Point(156, 409);
            this.labelTpmSayi.Name = "labelTpmSayi";
            this.labelTpmSayi.Size = new System.Drawing.Size(14, 17);
            this.labelTpmSayi.TabIndex = 51;
            this.labelTpmSayi.Text = "-";
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.BackColor = System.Drawing.Color.Transparent;
            this.labelNot.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNot.ForeColor = System.Drawing.Color.Crimson;
            this.labelNot.Location = new System.Drawing.Point(136, 434);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(436, 34);
            this.labelNot.TabIndex = 52;
            this.labelNot.Text = "Not : Yanlızca BİR\'er Nöbetci seçilebilir . \r\nAksi durumda birinci sıradaki kayde" +
                "dilir , diğerleri kaydedilmez !";
            // 
            // txtNobetciMudurYardimcisi
            // 
            this.txtNobetciMudurYardimcisi.Enabled = false;
            this.txtNobetciMudurYardimcisi.Location = new System.Drawing.Point(152, 26);
            this.txtNobetciMudurYardimcisi.Name = "txtNobetciMudurYardimcisi";
            this.txtNobetciMudurYardimcisi.Size = new System.Drawing.Size(168, 21);
            this.txtNobetciMudurYardimcisi.TabIndex = 53;
            // 
            // txtNobetciOgretmen
            // 
            this.txtNobetciOgretmen.Enabled = false;
            this.txtNobetciOgretmen.Location = new System.Drawing.Point(345, 26);
            this.txtNobetciOgretmen.Name = "txtNobetciOgretmen";
            this.txtNobetciOgretmen.Size = new System.Drawing.Size(168, 21);
            this.txtNobetciOgretmen.TabIndex = 54;
            // 
            // Nobetc_Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.txtNobetciOgretmen);
            this.Controls.Add(this.txtNobetciMudurYardimcisi);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.labelTpmSayi);
            this.Controls.Add(this.labelTplm);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstOgretmenler);
            this.Controls.Add(this.labelOgrtmn);
            this.Controls.Add(this.lstMudurYardimcisi);
            this.Controls.Add(this.labelMdrYrdmc);
            this.Controls.Add(this.labelNtcOgrtmn);
            this.Controls.Add(this.labelNbtcMdrYrdm);
            this.Controls.Add(this.lstTarih);
            this.Controls.Add(this.labelSnvGnlri);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nobetc_Ogretmen";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nöbetci Öğretmen Dağıtımı";
            this.Load += new System.EventHandler(this.Nobetc_Ogretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTarih;
        private System.Windows.Forms.Label labelSnvGnlri;
        private System.Windows.Forms.Label labelNbtcMdrYrdm;
        private System.Windows.Forms.Label labelNtcOgrtmn;
        private System.Windows.Forms.ListBox lstOgretmenler;
        private System.Windows.Forms.Label labelOgrtmn;
        private System.Windows.Forms.ListBox lstMudurYardimcisi;
        private System.Windows.Forms.Label labelMdrYrdmc;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label labelTplm;
        private System.Windows.Forms.Label labelTpmSayi;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.TextBox txtNobetciMudurYardimcisi;
        private System.Windows.Forms.TextBox txtNobetciOgretmen;
    }
}