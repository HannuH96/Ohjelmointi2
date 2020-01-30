namespace Ohjelmointi2_vko3_h4
{
    partial class Form1
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
            this.txtb_luku1 = new System.Windows.Forms.TextBox();
            this.txtb_luku2 = new System.Windows.Forms.TextBox();
            this.lbl_syota1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_luku1
            // 
            this.txtb_luku1.Location = new System.Drawing.Point(120, 31);
            this.txtb_luku1.Name = "txtb_luku1";
            this.txtb_luku1.Size = new System.Drawing.Size(182, 20);
            this.txtb_luku1.TabIndex = 0;
            this.txtb_luku1.Leave += new System.EventHandler(this.Txtb_luku1_Leave);
            // 
            // txtb_luku2
            // 
            this.txtb_luku2.Location = new System.Drawing.Point(120, 68);
            this.txtb_luku2.Name = "txtb_luku2";
            this.txtb_luku2.Size = new System.Drawing.Size(182, 20);
            this.txtb_luku2.TabIndex = 1;
            this.txtb_luku2.Leave += new System.EventHandler(this.Txtb_luku2_Leave);
            // 
            // lbl_syota1
            // 
            this.lbl_syota1.AutoSize = true;
            this.lbl_syota1.Location = new System.Drawing.Point(51, 34);
            this.lbl_syota1.Name = "lbl_syota1";
            this.lbl_syota1.Size = new System.Drawing.Size(60, 13);
            this.lbl_syota1.TabIndex = 2;
            this.lbl_syota1.Text = "Syötä luku:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Syötä toinen luku:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 123);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslbl_status
            // 
            this.sslbl_status.Name = "sslbl_status";
            this.sslbl_status.Size = new System.Drawing.Size(164, 17);
            this.sslbl_status.Text = "Syötä luku johonkin kenttään.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 145);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_syota1);
            this.Controls.Add(this.txtb_luku2);
            this.Controls.Add(this.txtb_luku1);
            this.Name = "Form1";
            this.Text = "Teht 7 / KT 4";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_luku1;
        private System.Windows.Forms.TextBox txtb_luku2;
        private System.Windows.Forms.Label lbl_syota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_status;
    }
}

