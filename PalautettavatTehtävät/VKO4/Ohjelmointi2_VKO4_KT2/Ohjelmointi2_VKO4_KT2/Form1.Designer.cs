namespace Ohjelmointi2_VKO4_KT2
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_arvausteksti = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_arvatutnumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_tulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_arvattavaluku = new System.Windows.Forms.Label();
            this.txtb_arvattu = new System.Windows.Forms.TextBox();
            this.btn_arvaa = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_arvausteksti,
            this.tssl_arvatutnumero,
            this.tssl_tulos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 106);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(246, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_arvausteksti
            // 
            this.tssl_arvausteksti.Name = "tssl_arvausteksti";
            this.tssl_arvausteksti.Size = new System.Drawing.Size(99, 17);
            this.tssl_arvausteksti.Text = "Monesko arvaus: ";
            // 
            // tssl_arvatutnumero
            // 
            this.tssl_arvatutnumero.Name = "tssl_arvatutnumero";
            this.tssl_arvatutnumero.Size = new System.Drawing.Size(13, 17);
            this.tssl_arvatutnumero.Text = "0";
            // 
            // tssl_tulos
            // 
            this.tssl_tulos.Name = "tssl_tulos";
            this.tssl_tulos.Size = new System.Drawing.Size(83, 17);
            this.tssl_tulos.Text = "Ei vielä arvattu";
            // 
            // lbl_arvattavaluku
            // 
            this.lbl_arvattavaluku.AutoSize = true;
            this.lbl_arvattavaluku.Location = new System.Drawing.Point(12, 23);
            this.lbl_arvattavaluku.Name = "lbl_arvattavaluku";
            this.lbl_arvattavaluku.Size = new System.Drawing.Size(106, 13);
            this.lbl_arvattavaluku.TabIndex = 1;
            this.lbl_arvattavaluku.Text = "Anna arvaus (1-100):";
            // 
            // txtb_arvattu
            // 
            this.txtb_arvattu.Location = new System.Drawing.Point(124, 20);
            this.txtb_arvattu.Name = "txtb_arvattu";
            this.txtb_arvattu.Size = new System.Drawing.Size(82, 20);
            this.txtb_arvattu.TabIndex = 2;
            // 
            // btn_arvaa
            // 
            this.btn_arvaa.Location = new System.Drawing.Point(124, 58);
            this.btn_arvaa.Name = "btn_arvaa";
            this.btn_arvaa.Size = new System.Drawing.Size(82, 23);
            this.btn_arvaa.TabIndex = 3;
            this.btn_arvaa.Text = "Arvaa";
            this.btn_arvaa.UseVisualStyleBackColor = true;
            this.btn_arvaa.Click += new System.EventHandler(this.Btn_arvaa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 128);
            this.Controls.Add(this.btn_arvaa);
            this.Controls.Add(this.txtb_arvattu);
            this.Controls.Add(this.lbl_arvattavaluku);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "KT2 / TT 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_arvausteksti;
        private System.Windows.Forms.ToolStripStatusLabel tssl_arvatutnumero;
        private System.Windows.Forms.ToolStripStatusLabel tssl_tulos;
        private System.Windows.Forms.Label lbl_arvattavaluku;
        private System.Windows.Forms.TextBox txtb_arvattu;
        private System.Windows.Forms.Button btn_arvaa;
    }
}

