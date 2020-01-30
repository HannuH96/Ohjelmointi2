namespace Ohjelmointi2_VKO2_T4
{
    partial class Input
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
            this.lbl_nimi = new System.Windows.Forms.Label();
            this.lbl_mitattava = new System.Windows.Forms.Label();
            this.chb_toiminnassa = new System.Windows.Forms.CheckBox();
            this.lbl_sijainti = new System.Windows.Forms.Label();
            this.txtb_nimi = new System.Windows.Forms.TextBox();
            this.cbb_mitattava = new System.Windows.Forms.ComboBox();
            this.cbb_sijainti = new System.Windows.Forms.ComboBox();
            this.btn_vie = new System.Windows.Forms.Button();
            this.dgv_tiedot = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiedot)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nimi
            // 
            this.lbl_nimi.AutoSize = true;
            this.lbl_nimi.Location = new System.Drawing.Point(100, 59);
            this.lbl_nimi.Name = "lbl_nimi";
            this.lbl_nimi.Size = new System.Drawing.Size(33, 13);
            this.lbl_nimi.TabIndex = 0;
            this.lbl_nimi.Text = "Nimi: ";
            // 
            // lbl_mitattava
            // 
            this.lbl_mitattava.AutoSize = true;
            this.lbl_mitattava.Location = new System.Drawing.Point(100, 85);
            this.lbl_mitattava.Name = "lbl_mitattava";
            this.lbl_mitattava.Size = new System.Drawing.Size(78, 13);
            this.lbl_mitattava.TabIndex = 1;
            this.lbl_mitattava.Text = "Mitattava arvo:";
            // 
            // chb_toiminnassa
            // 
            this.chb_toiminnassa.AutoSize = true;
            this.chb_toiminnassa.Location = new System.Drawing.Point(188, 109);
            this.chb_toiminnassa.Name = "chb_toiminnassa";
            this.chb_toiminnassa.Size = new System.Drawing.Size(85, 17);
            this.chb_toiminnassa.TabIndex = 2;
            this.chb_toiminnassa.Text = "Toiminnassa";
            this.chb_toiminnassa.UseVisualStyleBackColor = true;
            // 
            // lbl_sijainti
            // 
            this.lbl_sijainti.AutoSize = true;
            this.lbl_sijainti.Location = new System.Drawing.Point(100, 135);
            this.lbl_sijainti.Name = "lbl_sijainti";
            this.lbl_sijainti.Size = new System.Drawing.Size(40, 13);
            this.lbl_sijainti.TabIndex = 3;
            this.lbl_sijainti.Text = "Sijainti:";
            // 
            // txtb_nimi
            // 
            this.txtb_nimi.Location = new System.Drawing.Point(188, 56);
            this.txtb_nimi.Name = "txtb_nimi";
            this.txtb_nimi.Size = new System.Drawing.Size(121, 20);
            this.txtb_nimi.TabIndex = 4;
            // 
            // cbb_mitattava
            // 
            this.cbb_mitattava.FormattingEnabled = true;
            this.cbb_mitattava.Items.AddRange(new object[] {
            "Kosteus",
            "Lämpötila",
            "PH",
            "Tuulen nopeus"});
            this.cbb_mitattava.Location = new System.Drawing.Point(188, 82);
            this.cbb_mitattava.Name = "cbb_mitattava";
            this.cbb_mitattava.Size = new System.Drawing.Size(121, 21);
            this.cbb_mitattava.TabIndex = 5;
            this.cbb_mitattava.Text = "Valitse";
            // 
            // cbb_sijainti
            // 
            this.cbb_sijainti.FormattingEnabled = true;
            this.cbb_sijainti.Items.AddRange(new object[] {
            "Sisällä",
            "Ulkona",
            "Ulkona suojatusti"});
            this.cbb_sijainti.Location = new System.Drawing.Point(188, 132);
            this.cbb_sijainti.Name = "cbb_sijainti";
            this.cbb_sijainti.Size = new System.Drawing.Size(121, 21);
            this.cbb_sijainti.TabIndex = 6;
            this.cbb_sijainti.Text = "Valitse";
            // 
            // btn_vie
            // 
            this.btn_vie.Location = new System.Drawing.Point(335, 56);
            this.btn_vie.Name = "btn_vie";
            this.btn_vie.Size = new System.Drawing.Size(106, 97);
            this.btn_vie.TabIndex = 7;
            this.btn_vie.Text = "Vie";
            this.btn_vie.UseVisualStyleBackColor = true;
            this.btn_vie.Click += new System.EventHandler(this.Btn_vie_Click);
            // 
            // dgv_tiedot
            // 
            this.dgv_tiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tiedot.Location = new System.Drawing.Point(103, 178);
            this.dgv_tiedot.Name = "dgv_tiedot";
            this.dgv_tiedot.Size = new System.Drawing.Size(338, 150);
            this.dgv_tiedot.TabIndex = 8;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 413);
            this.Controls.Add(this.dgv_tiedot);
            this.Controls.Add(this.btn_vie);
            this.Controls.Add(this.cbb_sijainti);
            this.Controls.Add(this.cbb_mitattava);
            this.Controls.Add(this.txtb_nimi);
            this.Controls.Add(this.lbl_sijainti);
            this.Controls.Add(this.chb_toiminnassa);
            this.Controls.Add(this.lbl_mitattava);
            this.Controls.Add(this.lbl_nimi);
            this.Name = "Input";
            this.Text = "Mittaus";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiedot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nimi;
        private System.Windows.Forms.Label lbl_mitattava;
        private System.Windows.Forms.CheckBox chb_toiminnassa;
        private System.Windows.Forms.Label lbl_sijainti;
        private System.Windows.Forms.TextBox txtb_nimi;
        private System.Windows.Forms.ComboBox cbb_mitattava;
        private System.Windows.Forms.ComboBox cbb_sijainti;
        private System.Windows.Forms.Button btn_vie;
        private System.Windows.Forms.DataGridView dgv_tiedot;
    }
}

