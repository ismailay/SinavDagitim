namespace SinavT
{
    partial class OgretmenElProgramiRapor
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
            this.cryRptViewerOgretmenElProgrami = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerOgretmenElProgrami
            // 
            this.cryRptViewerOgretmenElProgrami.ActiveViewIndex = -1;
            this.cryRptViewerOgretmenElProgrami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerOgretmenElProgrami.DisplayGroupTree = false;
            this.cryRptViewerOgretmenElProgrami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerOgretmenElProgrami.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerOgretmenElProgrami.Name = "cryRptViewerOgretmenElProgrami";
            this.cryRptViewerOgretmenElProgrami.SelectionFormula = "";
            this.cryRptViewerOgretmenElProgrami.Size = new System.Drawing.Size(591, 400);
            this.cryRptViewerOgretmenElProgrami.TabIndex = 0;
            this.cryRptViewerOgretmenElProgrami.ViewTimeSelectionFormula = "";
            // 
            // OgretmenElProgramiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 400);
            this.Controls.Add(this.cryRptViewerOgretmenElProgrami);
            this.Name = "OgretmenElProgramiRapor";
            this.Opacity = 0.97;
            this.Text = "Öğretmen El Programı Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgretmenElProgramiRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerOgretmenElProgrami;
    }
}