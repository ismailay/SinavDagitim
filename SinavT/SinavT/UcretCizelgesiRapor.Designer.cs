namespace SinavT
{
    partial class UcretCizelgesiRapor
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
            this.cryRptViewerUcretCizelgesi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerUcretCizelgesi
            // 
            this.cryRptViewerUcretCizelgesi.ActiveViewIndex = -1;
            this.cryRptViewerUcretCizelgesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerUcretCizelgesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerUcretCizelgesi.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerUcretCizelgesi.Name = "cryRptViewerUcretCizelgesi";
            this.cryRptViewerUcretCizelgesi.SelectionFormula = "";
            this.cryRptViewerUcretCizelgesi.Size = new System.Drawing.Size(611, 380);
            this.cryRptViewerUcretCizelgesi.TabIndex = 0;
            this.cryRptViewerUcretCizelgesi.ViewTimeSelectionFormula = "";
            // 
            // UcretCizelgesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 380);
            this.Controls.Add(this.cryRptViewerUcretCizelgesi);
            this.Name = "UcretCizelgesiRapor";
            this.Text = "UcretCizelgesiRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UcretCizelgesiRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerUcretCizelgesi;
    }
}