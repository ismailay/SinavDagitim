namespace SinavT
{
    partial class CarsafListe
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
            this.cryRptViewerCarsafListe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerCarsafListe
            // 
            this.cryRptViewerCarsafListe.ActiveViewIndex = -1;
            this.cryRptViewerCarsafListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerCarsafListe.DisplayGroupTree = false;
            this.cryRptViewerCarsafListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerCarsafListe.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerCarsafListe.Name = "cryRptViewerCarsafListe";
            this.cryRptViewerCarsafListe.SelectionFormula = "";
            this.cryRptViewerCarsafListe.Size = new System.Drawing.Size(554, 456);
            this.cryRptViewerCarsafListe.TabIndex = 0;
            this.cryRptViewerCarsafListe.ViewTimeSelectionFormula = "";
            // 
            // CarsafListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 456);
            this.Controls.Add(this.cryRptViewerCarsafListe);
            this.Name = "CarsafListe";
            this.Text = "Çarşaf Liste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarsafListe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerCarsafListe;
    }
}