namespace SinavT
{
    partial class ImzaCetveliRapor
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
            this.cryRptViewerImzaCetveli = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerImzaCetveli
            // 
            this.cryRptViewerImzaCetveli.ActiveViewIndex = -1;
            this.cryRptViewerImzaCetveli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerImzaCetveli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerImzaCetveli.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerImzaCetveli.Name = "cryRptViewerImzaCetveli";
            this.cryRptViewerImzaCetveli.SelectionFormula = "";
            this.cryRptViewerImzaCetveli.Size = new System.Drawing.Size(571, 467);
            this.cryRptViewerImzaCetveli.TabIndex = 0;
            this.cryRptViewerImzaCetveli.ViewTimeSelectionFormula = "";
            // 
            // ImzaCetveliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 467);
            this.Controls.Add(this.cryRptViewerImzaCetveli);
            this.Name = "ImzaCetveliRapor";
            this.Text = "ImzaCetveliRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImzaCetveliRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerImzaCetveli;
    }
}