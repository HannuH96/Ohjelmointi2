namespace Ohjelmointi2_Vko3_T2tai5
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
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_vie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tuo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_lopeta = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_tekstilaatikko = new System.Windows.Forms.RichTextBox();
            this.ts_tyokalut = new System.Windows.Forms.ToolStrip();
            this.tsb_vie = new System.Windows.Forms.ToolStripButton();
            this.tsb_tuo = new System.Windows.Forms.ToolStripButton();
            this.tstxtb_poista = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_poista = new System.Windows.Forms.ToolStripButton();
            this.ms_menu.SuspendLayout();
            this.ts_tyokalut.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(347, 24);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_vie,
            this.tsmi_tuo,
            this.tsmi_lopeta});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmi_vie
            // 
            this.tsmi_vie.Name = "tsmi_vie";
            this.tsmi_vie.Size = new System.Drawing.Size(110, 22);
            this.tsmi_vie.Text = "Vie";
            this.tsmi_vie.Click += new System.EventHandler(this.Tsmi_vie_Click);
            // 
            // tsmi_tuo
            // 
            this.tsmi_tuo.Name = "tsmi_tuo";
            this.tsmi_tuo.Size = new System.Drawing.Size(110, 22);
            this.tsmi_tuo.Text = "Tuo";
            this.tsmi_tuo.Click += new System.EventHandler(this.tsmi_tuo_click);
            // 
            // tsmi_lopeta
            // 
            this.tsmi_lopeta.Name = "tsmi_lopeta";
            this.tsmi_lopeta.Size = new System.Drawing.Size(110, 22);
            this.tsmi_lopeta.Text = "Lopeta";
            this.tsmi_lopeta.Click += new System.EventHandler(this.Tsmi_lopeta_Click);
            // 
            // rtb_tekstilaatikko
            // 
            this.rtb_tekstilaatikko.Location = new System.Drawing.Point(12, 135);
            this.rtb_tekstilaatikko.Name = "rtb_tekstilaatikko";
            this.rtb_tekstilaatikko.Size = new System.Drawing.Size(324, 215);
            this.rtb_tekstilaatikko.TabIndex = 1;
            this.rtb_tekstilaatikko.Text = "";
            this.rtb_tekstilaatikko.TextChanged += new System.EventHandler(this.Rtb_tekstilaatikko_TextChanged);
            // 
            // ts_tyokalut
            // 
            this.ts_tyokalut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_vie,
            this.tsb_tuo,
            this.tstxtb_poista,
            this.tsb_poista});
            this.ts_tyokalut.Location = new System.Drawing.Point(0, 24);
            this.ts_tyokalut.Name = "ts_tyokalut";
            this.ts_tyokalut.Size = new System.Drawing.Size(347, 25);
            this.ts_tyokalut.TabIndex = 2;
            this.ts_tyokalut.Text = "toolStrip1";
            // 
            // tsb_vie
            // 
            this.tsb_vie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_vie.Image = ((System.Drawing.Image)(resources.GetObject("tsb_vie.Image")));
            this.tsb_vie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_vie.Name = "tsb_vie";
            this.tsb_vie.Size = new System.Drawing.Size(23, 22);
            this.tsb_vie.Text = "Vie";
            this.tsb_vie.Click += new System.EventHandler(this.Tsmi_vie_Click);
            // 
            // tsb_tuo
            // 
            this.tsb_tuo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_tuo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_tuo.Image")));
            this.tsb_tuo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_tuo.Name = "tsb_tuo";
            this.tsb_tuo.Size = new System.Drawing.Size(23, 22);
            this.tsb_tuo.Text = "Tuo";
            this.tsb_tuo.Click += new System.EventHandler(this.tsmi_tuo_click);
            // 
            // tstxtb_poista
            // 
            this.tstxtb_poista.Name = "tstxtb_poista";
            this.tstxtb_poista.Size = new System.Drawing.Size(100, 25);
            // 
            // tsb_poista
            // 
            this.tsb_poista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_poista.Image = ((System.Drawing.Image)(resources.GetObject("tsb_poista.Image")));
            this.tsb_poista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_poista.Name = "tsb_poista";
            this.tsb_poista.Size = new System.Drawing.Size(23, 22);
            this.tsb_poista.Text = "Poista";
            this.tsb_poista.Click += new System.EventHandler(this.Tsb_poista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.Controls.Add(this.ts_tyokalut);
            this.Controls.Add(this.rtb_tekstilaatikko);
            this.Controls.Add(this.ms_menu);
            this.MainMenuStrip = this.ms_menu;
            this.Name = "Form1";
            this.Text = "Harjoitus 1 + 5 (VT 2)";
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ts_tyokalut.ResumeLayout(false);
            this.ts_tyokalut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_vie;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tuo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_lopeta;
        private System.Windows.Forms.RichTextBox rtb_tekstilaatikko;
        private System.Windows.Forms.ToolStrip ts_tyokalut;
        private System.Windows.Forms.ToolStripButton tsb_vie;
        private System.Windows.Forms.ToolStripButton tsb_tuo;
        private System.Windows.Forms.ToolStripTextBox tstxtb_poista;
        private System.Windows.Forms.ToolStripButton tsb_poista;
    }
}

