namespace Ohjelmointi2_VKO3_H3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ss_tilastot = new System.Windows.Forms.StatusStrip();
            this.sslbl_aika = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslbl_tulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_napille = new System.Windows.Forms.ToolStrip();
            this.tsb_startgame = new System.Windows.Forms.ToolStripButton();
            this.sslbl_huti = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_tilastot.SuspendLayout();
            this.ts_napille.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_tilastot
            // 
            this.ss_tilastot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslbl_aika,
            this.sslbl_tulos,
            this.sslbl_huti});
            this.ss_tilastot.Location = new System.Drawing.Point(0, 319);
            this.ss_tilastot.Name = "ss_tilastot";
            this.ss_tilastot.Size = new System.Drawing.Size(334, 22);
            this.ss_tilastot.TabIndex = 0;
            this.ss_tilastot.Text = "statusStrip1";
            // 
            // sslbl_aika
            // 
            this.sslbl_aika.Name = "sslbl_aika";
            this.sslbl_aika.Size = new System.Drawing.Size(50, 17);
            this.sslbl_aika.Text = "Aika: 0 s";
            // 
            // sslbl_tulos
            // 
            this.sslbl_tulos.Name = "sslbl_tulos";
            this.sslbl_tulos.Size = new System.Drawing.Size(61, 17);
            this.sslbl_tulos.Text = "Osumat: 0";
            // 
            // ts_napille
            // 
            this.ts_napille.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_startgame});
            this.ts_napille.Location = new System.Drawing.Point(0, 0);
            this.ts_napille.Name = "ts_napille";
            this.ts_napille.Size = new System.Drawing.Size(334, 25);
            this.ts_napille.TabIndex = 1;
            this.ts_napille.Text = "toolStrip1";
            // 
            // tsb_startgame
            // 
            this.tsb_startgame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_startgame.Image = ((System.Drawing.Image)(resources.GetObject("tsb_startgame.Image")));
            this.tsb_startgame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_startgame.Name = "tsb_startgame";
            this.tsb_startgame.Size = new System.Drawing.Size(23, 22);
            this.tsb_startgame.Text = "Aloita peli";
            this.tsb_startgame.Click += new System.EventHandler(this.Tsb_startgame_Click);
            // 
            // sslbl_huti
            // 
            this.sslbl_huti.Name = "sslbl_huti";
            this.sslbl_huti.Size = new System.Drawing.Size(55, 17);
            this.sslbl_huti.Text = "Ohi: 0 / 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.ts_napille);
            this.Controls.Add(this.ss_tilastot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Klikkaa nappia";
            this.ss_tilastot.ResumeLayout(false);
            this.ss_tilastot.PerformLayout();
            this.ts_napille.ResumeLayout(false);
            this.ts_napille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_tilastot;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_aika;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_tulos;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_huti;
        private System.Windows.Forms.ToolStrip ts_napille;
        private System.Windows.Forms.ToolStripButton tsb_startgame;
    }
}

