namespace SinavT
{
    partial class SinavIlanCizelgsiRapor
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
            this.cryRptViewerSinavIlanCizelgsi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerSinavIlanCizelgsi
            // 
            this.cryRptViewerSinavIlanCizelgsi.ActiveViewIndex = -1;
            this.cryRptViewerSinavIlanCizelgsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerSinavIlanCizelgsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerSinavIlanCizelgsi.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerSinavIlanCizelgsi.Name = "cryRptViewerSinavIlanCizelgsi";
            this.cryRptViewerSinavIlanCizelgsi.SelectionFormula = "";
            this.cryRptViewerSinavIlanCizelgsi.Size = new System.Drawing.Size(563, 414);
            this.cryRptViewerSinavIlanCizelgsi.TabIndex = 0;
            this.cryRptViewerSinavIlanCizelgsi.ViewTimeSelectionFormula = "";

            // 
            // SinavIlanCizelgsiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 414);
            this.Controls.Add(this.cryRptViewerSinavIlanCizelgsi);
            this.Name = "SinavIlanCizelgsiRapor";
            this.Text = "SinavIlanCizelgsiRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SinavIlanCizelgsiRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerSinavIlanCizelgsi;
    }
}