namespace Ohjelmointi2_Harjoitustyö
{
    partial class form_aloitusikkuna
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
            this.btn_start = new System.Windows.Forms.Button();
            this.cbb_pelaajalista0 = new System.Windows.Forms.ComboBox();
            this.txtb_etun0 = new System.Windows.Forms.TextBox();
            this.txtb_sukun0 = new System.Windows.Forms.TextBox();
            this.txtb_syntpv0 = new System.Windows.Forms.TextBox();
            this.lbl_etun1 = new System.Windows.Forms.Label();
            this.lbl_sukun1 = new System.Windows.Forms.Label();
            this.lbl_svuosi1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_syntpv1 = new System.Windows.Forms.TextBox();
            this.txtb_sukun1 = new System.Windows.Forms.TextBox();
            this.txtb_etun1 = new System.Windows.Forms.TextBox();
            this.cbb_pelaajalista1 = new System.Windows.Forms.ComboBox();
            this.chb_tietokone = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilastotaulukkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_olemassaoleva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(295, 264);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(150, 90);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Aloita peli";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // cbb_pelaajalista0
            // 
            this.cbb_pelaajalista0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_pelaajalista0.FormattingEnabled = true;
            this.cbb_pelaajalista0.Location = new System.Drawing.Point(143, 106);
            this.cbb_pelaajalista0.Name = "cbb_pelaajalista0";
            this.cbb_pelaajalista0.Size = new System.Drawing.Size(203, 21);
            this.cbb_pelaajalista0.TabIndex = 100;
            this.cbb_pelaajalista0.SelectedIndexChanged += new System.EventHandler(this.Cbb_pelaajalista0_SelectedIndexChanged);
            // 
            // txtb_etun0
            // 
            this.txtb_etun0.Location = new System.Drawing.Point(143, 133);
            this.txtb_etun0.Name = "txtb_etun0";
            this.txtb_etun0.Size = new System.Drawing.Size(203, 20);
            this.txtb_etun0.TabIndex = 1;
            this.txtb_etun0.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // txtb_sukun0
            // 
            this.txtb_sukun0.Location = new System.Drawing.Point(143, 159);
            this.txtb_sukun0.Name = "txtb_sukun0";
            this.txtb_sukun0.Size = new System.Drawing.Size(203, 20);
            this.txtb_sukun0.TabIndex = 2;
            this.txtb_sukun0.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // txtb_syntpv0
            // 
            this.txtb_syntpv0.Location = new System.Drawing.Point(143, 185);
            this.txtb_syntpv0.Name = "txtb_syntpv0";
            this.txtb_syntpv0.Size = new System.Drawing.Size(85, 20);
            this.txtb_syntpv0.TabIndex = 3;
            this.txtb_syntpv0.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_syntpv0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_syntpv1_KeyPress);
            this.txtb_syntpv0.Leave += new System.EventHandler(this.Txtb_syntpv0_Leave);
            // 
            // lbl_etun1
            // 
            this.lbl_etun1.AutoSize = true;
            this.lbl_etun1.Location = new System.Drawing.Point(96, 136);
            this.lbl_etun1.Name = "lbl_etun1";
            this.lbl_etun1.Size = new System.Drawing.Size(41, 13);
            this.lbl_etun1.TabIndex = 7;
            this.lbl_etun1.Text = "Etunimi";
            // 
            // lbl_sukun1
            // 
            this.lbl_sukun1.AutoSize = true;
            this.lbl_sukun1.Location = new System.Drawing.Point(87, 162);
            this.lbl_sukun1.Name = "lbl_sukun1";
            this.lbl_sukun1.Size = new System.Drawing.Size(50, 13);
            this.lbl_sukun1.TabIndex = 8;
            this.lbl_sukun1.Text = "Sukunimi";
            // 
            // lbl_svuosi1
            // 
            this.lbl_svuosi1.AutoSize = true;
            this.lbl_svuosi1.Location = new System.Drawing.Point(65, 188);
            this.lbl_svuosi1.Name = "lbl_svuosi1";
            this.lbl_svuosi1.Size = new System.Drawing.Size(72, 13);
            this.lbl_svuosi1.TabIndex = 10;
            this.lbl_svuosi1.Text = "Syntymävuosi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Syntymävuosi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Etunimi";
            // 
            // txtb_syntpv1
            // 
            this.txtb_syntpv1.Location = new System.Drawing.Point(530, 185);
            this.txtb_syntpv1.Name = "txtb_syntpv1";
            this.txtb_syntpv1.Size = new System.Drawing.Size(85, 20);
            this.txtb_syntpv1.TabIndex = 6;
            this.txtb_syntpv1.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_syntpv1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_syntpv1_KeyPress);
            this.txtb_syntpv1.Leave += new System.EventHandler(this.Txtb_syntpv1_Leave);
            // 
            // txtb_sukun1
            // 
            this.txtb_sukun1.Location = new System.Drawing.Point(530, 159);
            this.txtb_sukun1.Name = "txtb_sukun1";
            this.txtb_sukun1.Size = new System.Drawing.Size(203, 20);
            this.txtb_sukun1.TabIndex = 5;
            this.txtb_sukun1.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // txtb_etun1
            // 
            this.txtb_etun1.Location = new System.Drawing.Point(530, 133);
            this.txtb_etun1.Name = "txtb_etun1";
            this.txtb_etun1.Size = new System.Drawing.Size(203, 20);
            this.txtb_etun1.TabIndex = 4;
            this.txtb_etun1.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // cbb_pelaajalista1
            // 
            this.cbb_pelaajalista1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_pelaajalista1.FormattingEnabled = true;
            this.cbb_pelaajalista1.Location = new System.Drawing.Point(530, 106);
            this.cbb_pelaajalista1.Name = "cbb_pelaajalista1";
            this.cbb_pelaajalista1.Size = new System.Drawing.Size(203, 21);
            this.cbb_pelaajalista1.TabIndex = 101;
            this.cbb_pelaajalista1.SelectedIndexChanged += new System.EventHandler(this.Cbb_pelaajalista1_SelectedIndexChanged);
            // 
            // chb_tietokone
            // 
            this.chb_tietokone.AutoSize = true;
            this.chb_tietokone.Location = new System.Drawing.Point(530, 211);
            this.chb_tietokone.Name = "chb_tietokone";
            this.chb_tietokone.Size = new System.Drawing.Size(74, 17);
            this.chb_tietokone.TabIndex = 7;
            this.chb_tietokone.Text = "Tietokone";
            this.chb_tietokone.UseVisualStyleBackColor = true;
            this.chb_tietokone.CheckedChanged += new System.EventHandler(this.Chb_tietokone_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tilastotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tilastotToolStripMenuItem
            // 
            this.tilastotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tilastotaulukkoToolStripMenuItem});
            this.tilastotToolStripMenuItem.Name = "tilastotToolStripMenuItem";
            this.tilastotToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tilastotToolStripMenuItem.Text = "Tilastot";
            // 
            // tilastotaulukkoToolStripMenuItem
            // 
            this.tilastotaulukkoToolStripMenuItem.Name = "tilastotaulukkoToolStripMenuItem";
            this.tilastotaulukkoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tilastotaulukkoToolStripMenuItem.Text = "Tulostaulukko";
            this.tilastotaulukkoToolStripMenuItem.Click += new System.EventHandler(this.TilastotaulukkoToolStripMenuItem_Click);
            // 
            // lbl_olemassaoleva
            // 
            this.lbl_olemassaoleva.AutoSize = true;
            this.lbl_olemassaoleva.Location = new System.Drawing.Point(12, 109);
            this.lbl_olemassaoleva.Name = "lbl_olemassaoleva";
            this.lbl_olemassaoleva.Size = new System.Drawing.Size(125, 13);
            this.lbl_olemassaoleva.TabIndex = 22;
            this.lbl_olemassaoleva.Text = "Olemassa olevat pelaajat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Olemassa olevat pelaajat";
            // 
            // form_aloitusikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_olemassaoleva);
            this.Controls.Add(this.chb_tietokone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_syntpv1);
            this.Controls.Add(this.txtb_sukun1);
            this.Controls.Add(this.txtb_etun1);
            this.Controls.Add(this.cbb_pelaajalista1);
            this.Controls.Add(this.lbl_svuosi1);
            this.Controls.Add(this.lbl_sukun1);
            this.Controls.Add(this.lbl_etun1);
            this.Controls.Add(this.txtb_syntpv0);
            this.Controls.Add(this.txtb_sukun0);
            this.Controls.Add(this.txtb_etun0);
            this.Controls.Add(this.cbb_pelaajalista0);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form_aloitusikkuna";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ristinolla | Aloitusikkuna";
            this.Load += new System.EventHandler(this.Form_aloitusikkuna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox cbb_pelaajalista0;
        private System.Windows.Forms.TextBox txtb_etun0;
        private System.Windows.Forms.TextBox txtb_sukun0;
        private System.Windows.Forms.TextBox txtb_syntpv0;
        private System.Windows.Forms.Label lbl_etun1;
        private System.Windows.Forms.Label lbl_sukun1;
        private System.Windows.Forms.Label lbl_svuosi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_syntpv1;
        private System.Windows.Forms.TextBox txtb_sukun1;
        private System.Windows.Forms.TextBox txtb_etun1;
        private System.Windows.Forms.ComboBox cbb_pelaajalista1;
        private System.Windows.Forms.CheckBox chb_tietokone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tilastotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilastotaulukkoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_olemassaoleva;
        private System.Windows.Forms.Label label5;
    }
}