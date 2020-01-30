namespace Ohjelmointi2_VKO4_VT1TT2
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
            this.ms_tiedosto = new System.Windows.Forms.MenuStrip();
            this.tsmi_tiedosto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_vie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tuo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edellinen = new System.Windows.Forms.Button();
            this.btn_seuraava = new System.Windows.Forms.Button();
            this.txtb_naytto = new System.Windows.Forms.TextBox();
            this.prb_sijainti = new System.Windows.Forms.ProgressBar();
            this.ms_tiedosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_tiedosto
            // 
            this.ms_tiedosto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_tiedosto});
            this.ms_tiedosto.Location = new System.Drawing.Point(0, 0);
            this.ms_tiedosto.Name = "ms_tiedosto";
            this.ms_tiedosto.Size = new System.Drawing.Size(255, 24);
            this.ms_tiedosto.TabIndex = 0;
            this.ms_tiedosto.Text = "menuStrip1";
            // 
            // tsmi_tiedosto
            // 
            this.tsmi_tiedosto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_vie,
            this.tsmi_tuo});
            this.tsmi_tiedosto.Name = "tsmi_tiedosto";
            this.tsmi_tiedosto.Size = new System.Drawing.Size(65, 20);
            this.tsmi_tiedosto.Text = "Tiedosto";
            // 
            // tsmi_vie
            // 
            this.tsmi_vie.Name = "tsmi_vie";
            this.tsmi_vie.Size = new System.Drawing.Size(95, 22);
            this.tsmi_vie.Text = "Vie";
            this.tsmi_vie.Click += new System.EventHandler(this.Tsmi_vie_Click);
            // 
            // tsmi_tuo
            // 
            this.tsmi_tuo.Enabled = false;
            this.tsmi_tuo.Name = "tsmi_tuo";
            this.tsmi_tuo.Size = new System.Drawing.Size(95, 22);
            this.tsmi_tuo.Text = "Tuo";
            this.tsmi_tuo.Click += new System.EventHandler(this.Tsmi_tuo_Click);
            // 
            // btn_edellinen
            // 
            this.btn_edellinen.Enabled = false;
            this.btn_edellinen.Location = new System.Drawing.Point(12, 69);
            this.btn_edellinen.Name = "btn_edellinen";
            this.btn_edellinen.Size = new System.Drawing.Size(49, 20);
            this.btn_edellinen.TabIndex = 1;
            this.btn_edellinen.Text = "<";
            this.btn_edellinen.UseVisualStyleBackColor = true;
            this.btn_edellinen.Click += new System.EventHandler(this.Btn_edellinen_Click);
            // 
            // btn_seuraava
            // 
            this.btn_seuraava.Enabled = false;
            this.btn_seuraava.Location = new System.Drawing.Point(197, 70);
            this.btn_seuraava.Name = "btn_seuraava";
            this.btn_seuraava.Size = new System.Drawing.Size(49, 20);
            this.btn_seuraava.TabIndex = 2;
            this.btn_seuraava.Text = ">";
            this.btn_seuraava.UseVisualStyleBackColor = true;
            this.btn_seuraava.Click += new System.EventHandler(this.Btn_seuraava_Click);
            // 
            // txtb_naytto
            // 
            this.txtb_naytto.Enabled = false;
            this.txtb_naytto.Location = new System.Drawing.Point(67, 70);
            this.txtb_naytto.Name = "txtb_naytto";
            this.txtb_naytto.Size = new System.Drawing.Size(124, 20);
            this.txtb_naytto.TabIndex = 3;
            this.txtb_naytto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_naytto_KeyPress);
            this.txtb_naytto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_naytto_KeyUp);
            // 
            // prb_sijainti
            // 
            this.prb_sijainti.Location = new System.Drawing.Point(12, 111);
            this.prb_sijainti.Maximum = 99;
            this.prb_sijainti.Name = "prb_sijainti";
            this.prb_sijainti.Size = new System.Drawing.Size(231, 23);
            this.prb_sijainti.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 170);
            this.Controls.Add(this.prb_sijainti);
            this.Controls.Add(this.txtb_naytto);
            this.Controls.Add(this.btn_seuraava);
            this.Controls.Add(this.btn_edellinen);
            this.Controls.Add(this.ms_tiedosto);
            this.KeyPreview = true;
            this.MainMenuStrip = this.ms_tiedosto;
            this.Name = "Form1";
            this.Text = "KT1 / TT2";
            this.ms_tiedosto.ResumeLayout(false);
            this.ms_tiedosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_tiedosto;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tiedosto;
        private System.Windows.Forms.ToolStripMenuItem tsmi_vie;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tuo;
        private System.Windows.Forms.Button btn_edellinen;
        private System.Windows.Forms.Button btn_seuraava;
        private System.Windows.Forms.TextBox txtb_naytto;
        private System.Windows.Forms.ProgressBar prb_sijainti;
    }
}

