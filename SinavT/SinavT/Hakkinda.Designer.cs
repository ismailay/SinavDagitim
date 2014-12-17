namespace SinavT
{
    partial class Hakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkinda));
            this.panelBatl = new System.Windows.Forms.Panel();
            this.textSdp = new System.Windows.Forms.Label();
            this.textSinavdagitimpr = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panelOkul = new System.Windows.Forms.Panel();
            this.text2011 = new System.Windows.Forms.Label();
            this.textBatl = new System.Windows.Forms.Label();
            this.panelOkul.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBatl
            // 
            this.panelBatl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBatl.BackgroundImage")));
            this.panelBatl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBatl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBatl.Location = new System.Drawing.Point(14, 13);
            this.panelBatl.Name = "panelBatl";
            this.panelBatl.Size = new System.Drawing.Size(160, 204);
            this.panelBatl.TabIndex = 0;
            // 
            // textSdp
            // 
            this.textSdp.AutoSize = true;
            this.textSdp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSdp.Location = new System.Drawing.Point(223, 13);
            this.textSdp.Name = "textSdp";
            this.textSdp.Size = new System.Drawing.Size(150, 25);
            this.textSdp.TabIndex = 1;
            this.textSdp.Text = "SINAVMATİK";
            // 
            // textSinavdagitimpr
            // 
            this.textSinavdagitimpr.AutoSize = true;
            this.textSinavdagitimpr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSinavdagitimpr.Location = new System.Drawing.Point(225, 55);
            this.textSinavdagitimpr.Name = "textSinavdagitimpr";
            this.textSinavdagitimpr.Size = new System.Drawing.Size(157, 16);
            this.textSinavdagitimpr.TabIndex = 2;
            this.textSinavdagitimpr.Text = "Sınav Dağıtım Programı";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(323, 194);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(90, 23);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "&Tamam";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panelOkul
            // 
            this.panelOkul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOkul.Controls.Add(this.text2011);
            this.panelOkul.Controls.Add(this.textBatl);
            this.panelOkul.Location = new System.Drawing.Point(187, 96);
            this.panelOkul.Name = "panelOkul";
            this.panelOkul.Size = new System.Drawing.Size(226, 84);
            this.panelOkul.TabIndex = 4;
            // 
            // text2011
            // 
            this.text2011.AutoSize = true;
            this.text2011.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text2011.Location = new System.Drawing.Point(94, 46);
            this.text2011.Name = "text2011";
            this.text2011.Size = new System.Drawing.Size(35, 14);
            this.text2011.TabIndex = 4;
            this.text2011.Text = "2011";
            // 
            // textBatl
            // 
            this.textBatl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBatl.Location = new System.Drawing.Point(5, 1);
            this.textBatl.Name = "textBatl";
            this.textBatl.Size = new System.Drawing.Size(216, 45);
            this.textBatl.TabIndex = 3;
            this.textBatl.Text = "Karaman Temizel-Ünlü Teknik ve Endüstri Meslek Lise";
            this.textBatl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 227);
            this.ControlBox = false;
            this.Controls.Add(this.panelOkul);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.textSinavdagitimpr);
            this.Controls.Add(this.textSdp);
            this.Controls.Add(this.panelBatl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hakkinda";
            this.Opacity = 0.97;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.Hakkinda_Load);
            this.panelOkul.ResumeLayout(false);
            this.panelOkul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBatl;
        private System.Windows.Forms.Label textSdp;
        private System.Windows.Forms.Label textSinavdagitimpr;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Panel panelOkul;
        private System.Windows.Forms.Label textBatl;
        private System.Windows.Forms.Label text2011;
    }
}