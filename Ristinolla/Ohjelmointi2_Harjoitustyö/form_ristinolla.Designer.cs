namespace Ohjelmointi2_Harjoitustyö
{
    partial class form_ristinolla
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
            this.pcb_ristikko = new System.Windows.Forms.PictureBox();
            this.pcb_ulkoreuna = new System.Windows.Forms.PictureBox();
            this.pnl_pelaaja0 = new System.Windows.Forms.Panel();
            this.lbl_aktvuoro0 = new System.Windows.Forms.Label();
            this.lbl_nimi0 = new System.Windows.Forms.Label();
            this.pnl_pelaaja1 = new System.Windows.Forms.Panel();
            this.lbl_aktvuoro1 = new System.Windows.Forms.Label();
            this.lbl_nimi1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ristikko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ulkoreuna)).BeginInit();
            this.pnl_pelaaja0.SuspendLayout();
            this.pnl_pelaaja1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcb_ristikko
            // 
            this.pcb_ristikko.BackColor = System.Drawing.Color.White;
            this.pcb_ristikko.Location = new System.Drawing.Point(17, 82);
            this.pcb_ristikko.Name = "pcb_ristikko";
            this.pcb_ristikko.Size = new System.Drawing.Size(606, 606);
            this.pcb_ristikko.TabIndex = 11;
            this.pcb_ristikko.TabStop = false;
            // 
            // pcb_ulkoreuna
            // 
            this.pcb_ulkoreuna.BackColor = System.Drawing.Color.Black;
            this.pcb_ulkoreuna.Location = new System.Drawing.Point(12, 77);
            this.pcb_ulkoreuna.Name = "pcb_ulkoreuna";
            this.pcb_ulkoreuna.Size = new System.Drawing.Size(616, 616);
            this.pcb_ulkoreuna.TabIndex = 12;
            this.pcb_ulkoreuna.TabStop = false;
            // 
            // pnl_pelaaja0
            // 
            this.pnl_pelaaja0.BackColor = System.Drawing.Color.White;
            this.pnl_pelaaja0.Controls.Add(this.lbl_aktvuoro0);
            this.pnl_pelaaja0.Controls.Add(this.lbl_nimi0);
            this.pnl_pelaaja0.Location = new System.Drawing.Point(12, 12);
            this.pnl_pelaaja0.Name = "pnl_pelaaja0";
            this.pnl_pelaaja0.Size = new System.Drawing.Size(300, 34);
            this.pnl_pelaaja0.TabIndex = 14;
            // 
            // lbl_aktvuoro0
            // 
            this.lbl_aktvuoro0.AutoSize = true;
            this.lbl_aktvuoro0.Location = new System.Drawing.Point(213, 9);
            this.lbl_aktvuoro0.Name = "lbl_aktvuoro0";
            this.lbl_aktvuoro0.Size = new System.Drawing.Size(84, 13);
            this.lbl_aktvuoro0.TabIndex = 16;
            this.lbl_aktvuoro0.Text = "Pelivuorossa (O)";
            this.lbl_aktvuoro0.Visible = false;
            // 
            // lbl_nimi0
            // 
            this.lbl_nimi0.AutoSize = true;
            this.lbl_nimi0.Location = new System.Drawing.Point(3, 9);
            this.lbl_nimi0.Name = "lbl_nimi0";
            this.lbl_nimi0.Size = new System.Drawing.Size(112, 13);
            this.lbl_nimi0.TabIndex = 0;
            this.lbl_nimi0.Text = "Etunimi Sukunimi (plj0)";
            // 
            // pnl_pelaaja1
            // 
            this.pnl_pelaaja1.BackColor = System.Drawing.Color.White;
            this.pnl_pelaaja1.Controls.Add(this.lbl_aktvuoro1);
            this.pnl_pelaaja1.Controls.Add(this.lbl_nimi1);
            this.pnl_pelaaja1.Location = new System.Drawing.Point(328, 12);
            this.pnl_pelaaja1.Name = "pnl_pelaaja1";
            this.pnl_pelaaja1.Size = new System.Drawing.Size(300, 34);
            this.pnl_pelaaja1.TabIndex = 15;
            // 
            // lbl_aktvuoro1
            // 
            this.lbl_aktvuoro1.AutoSize = true;
            this.lbl_aktvuoro1.Location = new System.Drawing.Point(213, 9);
            this.lbl_aktvuoro1.Name = "lbl_aktvuoro1";
            this.lbl_aktvuoro1.Size = new System.Drawing.Size(83, 13);
            this.lbl_aktvuoro1.TabIndex = 17;
            this.lbl_aktvuoro1.Text = "Pelivuorossa (X)";
            this.lbl_aktvuoro1.Visible = false;
            // 
            // lbl_nimi1
            // 
            this.lbl_nimi1.AutoSize = true;
            this.lbl_nimi1.Location = new System.Drawing.Point(3, 9);
            this.lbl_nimi1.Name = "lbl_nimi1";
            this.lbl_nimi1.Size = new System.Drawing.Size(112, 13);
            this.lbl_nimi1.TabIndex = 1;
            this.lbl_nimi1.Text = "Etunimi Sukunimi (plj1)";
            // 
            // form_ristinolla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(639, 703);
            this.Controls.Add(this.pnl_pelaaja1);
            this.Controls.Add(this.pnl_pelaaja0);
            this.Controls.Add(this.pcb_ristikko);
            this.Controls.Add(this.pcb_ulkoreuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_ristinolla";
            this.Text = "Ristinolla | Peli";
            this.Load += new System.EventHandler(this.Form_ristinolla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ristikko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ulkoreuna)).EndInit();
            this.pnl_pelaaja0.ResumeLayout(false);
            this.pnl_pelaaja0.PerformLayout();
            this.pnl_pelaaja1.ResumeLayout(false);
            this.pnl_pelaaja1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_ristikko;
        private System.Windows.Forms.PictureBox pcb_ulkoreuna;
        private System.Windows.Forms.Panel pnl_pelaaja0;
        private System.Windows.Forms.Label lbl_aktvuoro0;
        private System.Windows.Forms.Label lbl_nimi0;
        private System.Windows.Forms.Panel pnl_pelaaja1;
        private System.Windows.Forms.Label lbl_aktvuoro1;
        private System.Windows.Forms.Label lbl_nimi1;
    }
}

