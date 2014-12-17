namespace SinavT
{
    partial class SinavIlanCizelgsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavIlanCizelgsi));
            this.groupBoxFormBslg = new System.Windows.Forms.GroupBox();
            this.groupBoxDpnot = new System.Windows.Forms.GroupBox();
            this.txtDipNot = new System.Windows.Forms.TextBox();
            this.labelNot = new System.Windows.Forms.Label();
            this.labelNtAcklma = new System.Windows.Forms.Label();
            this.buttonRpr = new System.Windows.Forms.Button();
            this.buttonCks = new System.Windows.Forms.Button();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.groupBoxFormBslg.SuspendLayout();
            this.groupBoxDpnot.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormBslg
            // 
            this.groupBoxFormBslg.Controls.Add(this.txtBaslik);
            this.groupBoxFormBslg.Location = new System.Drawing.Point(12, 24);
            this.groupBoxFormBslg.Name = "groupBoxFormBslg";
            this.groupBoxFormBslg.Size = new System.Drawing.Size(685, 122);
            this.groupBoxFormBslg.TabIndex = 4;
            this.groupBoxFormBslg.TabStop = false;
            this.groupBoxFormBslg.Text = "Form Başlığı";
            // 
            // groupBoxDpnot
            // 
            this.groupBoxDpnot.Controls.Add(this.txtDipNot);
            this.groupBoxDpnot.Location = new System.Drawing.Point(12, 166);
            this.groupBoxDpnot.Name = "groupBoxDpnot";
            this.groupBoxDpnot.Size = new System.Drawing.Size(685, 167);
            this.groupBoxDpnot.TabIndex = 16;
            this.groupBoxDpnot.TabStop = false;
            this.groupBoxDpnot.Text = "Sınav Çizelgesinin Altında Yer Alacak Dipnot";
            // 
            // txtDipNot
            // 
            this.txtDipNot.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDipNot.Enabled = false;
            this.txtDipNot.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDipNot.Location = new System.Drawing.Point(41, 19);
            this.txtDipNot.Multiline = true;
            this.txtDipNot.Name = "txtDipNot";
            this.txtDipNot.Size = new System.Drawing.Size(604, 142);
            this.txtDipNot.TabIndex = 15;
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.BackColor = System.Drawing.Color.Transparent;
            this.labelNot.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNot.ForeColor = System.Drawing.Color.Crimson;
            this.labelNot.Location = new System.Drawing.Point(66, 353);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(48, 18);
            this.labelNot.TabIndex = 53;
            this.labelNot.Text = "Not : ";
            // 
            // labelNtAcklma
            // 
            this.labelNtAcklma.AutoSize = true;
            this.labelNtAcklma.BackColor = System.Drawing.Color.Transparent;
            this.labelNtAcklma.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNtAcklma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNtAcklma.Location = new System.Drawing.Point(120, 355);
            this.labelNtAcklma.Name = "labelNtAcklma";
            this.labelNtAcklma.Size = new System.Drawing.Size(473, 34);
            this.labelNtAcklma.TabIndex = 54;
            this.labelNtAcklma.Text = "Yukarıdaki bilgiler Bilgi Girişi / Sabit Bilgiler kısmından değiştirilebilir ..\r\n" +
                "\r\n";
            // 
            // buttonRpr
            // 
            this.buttonRpr.Image = ((System.Drawing.Image)(resources.GetObject("buttonRpr.Image")));
            this.buttonRpr.Location = new System.Drawing.Point(254, 392);
            this.buttonRpr.Name = "buttonRpr";
            this.buttonRpr.Size = new System.Drawing.Size(209, 46);
            this.buttonRpr.TabIndex = 67;
            this.buttonRpr.UseVisualStyleBackColor = true;
            this.buttonRpr.Click += new System.EventHandler(this.buttonRpr_Click);
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(629, 413);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 66;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Enabled = false;
            this.txtBaslik.Location = new System.Drawing.Point(6, 20);
            this.txtBaslik.Multiline = true;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(673, 96);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SinavIlanCizelgsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRpr);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.labelNtAcklma);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.groupBoxDpnot);
            this.Controls.Add(this.groupBoxFormBslg);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinavIlanCizelgsi";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav İlan Çizelgesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SinavIlanCizelgsi_Load);
            this.groupBoxFormBslg.ResumeLayout(false);
            this.groupBoxFormBslg.PerformLayout();
            this.groupBoxDpnot.ResumeLayout(false);
            this.groupBoxDpnot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormBslg;
        private System.Windows.Forms.GroupBox groupBoxDpnot;
        private System.Windows.Forms.TextBox txtDipNot;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.Label labelNtAcklma;
        private System.Windows.Forms.Button buttonRpr;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.TextBox txtBaslik;
    }
}