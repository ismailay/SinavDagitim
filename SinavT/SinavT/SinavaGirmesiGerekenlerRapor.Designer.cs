namespace SinavT
{
    partial class SinavaGirmesiGerekenlerRapor
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
            this.cryRptViewerSinavaGirmesiGerekenler = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewerSinavaGirmesiGerekenler
            // 
            this.cryRptViewerSinavaGirmesiGerekenler.ActiveViewIndex = -1;
            this.cryRptViewerSinavaGirmesiGerekenler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewerSinavaGirmesiGerekenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewerSinavaGirmesiGerekenler.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewerSinavaGirmesiGerekenler.Name = "cryRptViewerSinavaGirmesiGerekenler";
            this.cryRptViewerSinavaGirmesiGerekenler.SelectionFormula = "";
            this.cryRptViewerSinavaGirmesiGerekenler.Size = new System.Drawing.Size(568, 430);
            this.cryRptViewerSinavaGirmesiGerekenler.TabIndex = 0;
            this.cryRptViewerSinavaGirmesiGerekenler.ViewTimeSelectionFormula = "";
            // 
            // SinavaGirmesiGerekenlerRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 430);
            this.Controls.Add(this.cryRptViewerSinavaGirmesiGerekenler);
            this.Name = "SinavaGirmesiGerekenlerRapor";
            this.Text = "SinavaGirmesiGerekenlerRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SinavaGirmesiGerekenlerRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewerSinavaGirmesiGerekenler;
    }
}