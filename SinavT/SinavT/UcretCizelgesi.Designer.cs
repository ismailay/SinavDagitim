namespace SinavT
{
    partial class UcretCizelgesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcretCizelgesi));
            this.buttonCks = new System.Windows.Forms.Button();
            this.lstAy = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(12, 243);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(98, 41);
            this.buttonCks.TabIndex = 29;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.button2_Click);
            this.buttonCks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonCks_KeyUp);
            // 
            // lstAy
            // 
            this.lstAy.FormattingEnabled = true;
            this.lstAy.Location = new System.Drawing.Point(10, 12);
            this.lstAy.Name = "lstAy";
            this.lstAy.Size = new System.Drawing.Size(100, 225);
            this.lstAy.TabIndex = 30;
            this.lstAy.DoubleClick += new System.EventHandler(this.lstAy_DoubleClick);
            this.lstAy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstAy_KeyUp);
            // 
            // UcretCizelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 294);
            this.ControlBox = false;
            this.Controls.Add(this.lstAy);
            this.Controls.Add(this.buttonCks);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcretCizelgesi";
            this.Opacity = 0.97;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ücret Çizelgesi";
            this.Load += new System.EventHandler(this.UcretCizelgesi_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UcretCizelgesi_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.ListBox lstAy;
    }
}