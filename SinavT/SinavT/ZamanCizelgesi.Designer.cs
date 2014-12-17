namespace SinavT
{
    partial class ZamanCizelgesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamanCizelgesi));
            this.buttonCks = new System.Windows.Forms.Button();
            this.buttonKydt = new System.Windows.Forms.Button();
            this.groupBoxNot = new System.Windows.Forms.GroupBox();
            this.labelUyari = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Image = ((System.Drawing.Image)(resources.GetObject("buttonCks.Image")));
            this.buttonCks.Location = new System.Drawing.Point(629, 440);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(68, 52);
            this.buttonCks.TabIndex = 31;
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // buttonKydt
            // 
            this.buttonKydt.Image = ((System.Drawing.Image)(resources.GetObject("buttonKydt.Image")));
            this.buttonKydt.Location = new System.Drawing.Point(542, 440);
            this.buttonKydt.Name = "buttonKydt";
            this.buttonKydt.Size = new System.Drawing.Size(68, 52);
            this.buttonKydt.TabIndex = 30;
            this.buttonKydt.UseVisualStyleBackColor = true;
            this.buttonKydt.Click += new System.EventHandler(this.buttonKydt_Click);
            // 
            // groupBoxNot
            // 
            this.groupBoxNot.Controls.Add(this.labelUyari);
            this.groupBoxNot.Location = new System.Drawing.Point(12, 426);
            this.groupBoxNot.Name = "groupBoxNot";
            this.groupBoxNot.Size = new System.Drawing.Size(513, 66);
            this.groupBoxNot.TabIndex = 29;
            this.groupBoxNot.TabStop = false;
            this.groupBoxNot.Text = "Not !";
            // 
            // labelUyari
            // 
            this.labelUyari.AutoSize = true;
            this.labelUyari.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyari.ForeColor = System.Drawing.Color.Crimson;
            this.labelUyari.Location = new System.Drawing.Point(48, 20);
            this.labelUyari.Name = "labelUyari";
            this.labelUyari.Size = new System.Drawing.Size(248, 32);
            this.labelUyari.TabIndex = 25;
            this.labelUyari.Text = "Sınav olmayacagı gün ve saatleri seçiniz !\r\nKırmızı işaretler sınav olmadığını gö" +
                "sterir .";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 399);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // ZamanCizelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.buttonKydt);
            this.Controls.Add(this.groupBoxNot);
            this.Name = "ZamanCizelgesi";
            this.Text = "Zaman Çizelgesi";
            this.Load += new System.EventHandler(this.ZamanCizelgesi_Load);
            this.Activated += new System.EventHandler(this.ZamanCizelgesi_Activated);
            this.groupBoxNot.ResumeLayout(false);
            this.groupBoxNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button buttonKydt;
        private System.Windows.Forms.GroupBox groupBoxNot;
        private System.Windows.Forms.Label labelUyari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}