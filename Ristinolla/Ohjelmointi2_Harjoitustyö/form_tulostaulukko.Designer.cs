namespace Ohjelmointi2_Harjoitustyö
{
    partial class form_tulostaulukko
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
            this.dgv_tulostaulukko = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbl_dgvinfot = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tulostaulukko)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tulostaulukko
            // 
            this.dgv_tulostaulukko.AllowUserToAddRows = false;
            this.dgv_tulostaulukko.AllowUserToDeleteRows = false;
            this.dgv_tulostaulukko.AllowUserToResizeColumns = false;
            this.dgv_tulostaulukko.AllowUserToResizeRows = false;
            this.dgv_tulostaulukko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tulostaulukko.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tulostaulukko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tulostaulukko.Location = new System.Drawing.Point(0, 0);
            this.dgv_tulostaulukko.Name = "dgv_tulostaulukko";
            this.dgv_tulostaulukko.RowHeadersVisible = false;
            this.dgv_tulostaulukko.Size = new System.Drawing.Size(688, 470);
            this.dgv_tulostaulukko.TabIndex = 0;
            this.dgv_tulostaulukko.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_tulostaulukko_CellMouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl_dgvinfot});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbl_dgvinfot
            // 
            this.tsslbl_dgvinfot.Name = "tsslbl_dgvinfot";
            this.tsslbl_dgvinfot.Size = new System.Drawing.Size(222, 17);
            this.tsslbl_dgvinfot.Text = "Tuplaklikkaamalla poistat pelaajan tiedot";
            // 
            // form_tulostaulukko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv_tulostaulukko);
            this.Name = "form_tulostaulukko";
            this.Text = "Ristinolla | Tulostaulukko";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tulostaulukko)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tulostaulukko;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl_dgvinfot;
    }
}