namespace Ohjelmointi2_VKO2_T1
{
    partial class Tietojuttu
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
            this.dtp_jobstart = new System.Windows.Forms.DateTimePicker();
            this.dtp_jobend = new System.Windows.Forms.DateTimePicker();
            this.txtb_sukunimi = new System.Windows.Forms.TextBox();
            this.lbl_etunimi = new System.Windows.Forms.Label();
            this.lbl_sukunimi = new System.Windows.Forms.Label();
            this.lbl_hetu = new System.Windows.Forms.Label();
            this.lbl_jobstart = new System.Windows.Forms.Label();
            this.lbl_jobend = new System.Windows.Forms.Label();
            this.cmbb_jobtitle = new System.Windows.Forms.ComboBox();
            this.lbl_tyonimike = new System.Windows.Forms.Label();
            this.dtp_syntpv = new System.Windows.Forms.DateTimePicker();
            this.btn_tallenna = new System.Windows.Forms.Button();
            this.txtb_etunimi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtp_jobstart
            // 
            this.dtp_jobstart.Location = new System.Drawing.Point(230, 167);
            this.dtp_jobstart.Name = "dtp_jobstart";
            this.dtp_jobstart.Size = new System.Drawing.Size(200, 20);
            this.dtp_jobstart.TabIndex = 1;
            // 
            // dtp_jobend
            // 
            this.dtp_jobend.Location = new System.Drawing.Point(230, 193);
            this.dtp_jobend.Name = "dtp_jobend";
            this.dtp_jobend.Size = new System.Drawing.Size(200, 20);
            this.dtp_jobend.TabIndex = 2;
            // 
            // txtb_sukunimi
            // 
            this.txtb_sukunimi.Location = new System.Drawing.Point(230, 115);
            this.txtb_sukunimi.Name = "txtb_sukunimi";
            this.txtb_sukunimi.Size = new System.Drawing.Size(200, 20);
            this.txtb_sukunimi.TabIndex = 3;
            // 
            // lbl_etunimi
            // 
            this.lbl_etunimi.AutoSize = true;
            this.lbl_etunimi.Location = new System.Drawing.Point(183, 92);
            this.lbl_etunimi.Name = "lbl_etunimi";
            this.lbl_etunimi.Size = new System.Drawing.Size(41, 13);
            this.lbl_etunimi.TabIndex = 6;
            this.lbl_etunimi.Text = "Etunimi";
            // 
            // lbl_sukunimi
            // 
            this.lbl_sukunimi.AutoSize = true;
            this.lbl_sukunimi.Location = new System.Drawing.Point(174, 118);
            this.lbl_sukunimi.Name = "lbl_sukunimi";
            this.lbl_sukunimi.Size = new System.Drawing.Size(50, 13);
            this.lbl_sukunimi.TabIndex = 7;
            this.lbl_sukunimi.Text = "Sukunimi";
            // 
            // lbl_hetu
            // 
            this.lbl_hetu.AutoSize = true;
            this.lbl_hetu.Location = new System.Drawing.Point(151, 144);
            this.lbl_hetu.Name = "lbl_hetu";
            this.lbl_hetu.Size = new System.Drawing.Size(73, 13);
            this.lbl_hetu.TabIndex = 8;
            this.lbl_hetu.Text = "Syntymäpäivä";
            // 
            // lbl_jobstart
            // 
            this.lbl_jobstart.AutoSize = true;
            this.lbl_jobstart.Location = new System.Drawing.Point(138, 173);
            this.lbl_jobstart.Name = "lbl_jobstart";
            this.lbl_jobstart.Size = new System.Drawing.Size(86, 13);
            this.lbl_jobstart.TabIndex = 9;
            this.lbl_jobstart.Text = "Työsuhteen alku";
            // 
            // lbl_jobend
            // 
            this.lbl_jobend.AutoSize = true;
            this.lbl_jobend.Location = new System.Drawing.Point(132, 199);
            this.lbl_jobend.Name = "lbl_jobend";
            this.lbl_jobend.Size = new System.Drawing.Size(92, 13);
            this.lbl_jobend.TabIndex = 10;
            this.lbl_jobend.Text = "Työsuhteen loppu";
            // 
            // cmbb_jobtitle
            // 
            this.cmbb_jobtitle.FormattingEnabled = true;
            this.cmbb_jobtitle.Items.AddRange(new object[] {
            "Projektityöntekijä",
            "Suunnittelija",
            "Asiantuntija",
            "Johtaja"});
            this.cmbb_jobtitle.Location = new System.Drawing.Point(230, 219);
            this.cmbb_jobtitle.Name = "cmbb_jobtitle";
            this.cmbb_jobtitle.Size = new System.Drawing.Size(200, 21);
            this.cmbb_jobtitle.TabIndex = 0;
            this.cmbb_jobtitle.Text = "Valitse";
            // 
            // lbl_tyonimike
            // 
            this.lbl_tyonimike.AutoSize = true;
            this.lbl_tyonimike.Location = new System.Drawing.Point(169, 222);
            this.lbl_tyonimike.Name = "lbl_tyonimike";
            this.lbl_tyonimike.Size = new System.Drawing.Size(55, 13);
            this.lbl_tyonimike.TabIndex = 11;
            this.lbl_tyonimike.Text = "Työnimike";
            // 
            // dtp_syntpv
            // 
            this.dtp_syntpv.Location = new System.Drawing.Point(230, 141);
            this.dtp_syntpv.Name = "dtp_syntpv";
            this.dtp_syntpv.Size = new System.Drawing.Size(200, 20);
            this.dtp_syntpv.TabIndex = 12;
            // 
            // btn_tallenna
            // 
            this.btn_tallenna.Location = new System.Drawing.Point(230, 246);
            this.btn_tallenna.Name = "btn_tallenna";
            this.btn_tallenna.Size = new System.Drawing.Size(75, 23);
            this.btn_tallenna.TabIndex = 13;
            this.btn_tallenna.Text = "Tallenna";
            this.btn_tallenna.UseVisualStyleBackColor = true;
            this.btn_tallenna.Click += new System.EventHandler(this.Btn_tallenna_Click);
            // 
            // txtb_etunimi
            // 
            this.txtb_etunimi.Location = new System.Drawing.Point(230, 89);
            this.txtb_etunimi.Name = "txtb_etunimi";
            this.txtb_etunimi.Size = new System.Drawing.Size(200, 20);
            this.txtb_etunimi.TabIndex = 15;
            // 
            // Tietojuttu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb_etunimi);
            this.Controls.Add(this.btn_tallenna);
            this.Controls.Add(this.dtp_syntpv);
            this.Controls.Add(this.lbl_tyonimike);
            this.Controls.Add(this.lbl_jobend);
            this.Controls.Add(this.lbl_jobstart);
            this.Controls.Add(this.lbl_hetu);
            this.Controls.Add(this.lbl_sukunimi);
            this.Controls.Add(this.lbl_etunimi);
            this.Controls.Add(this.txtb_sukunimi);
            this.Controls.Add(this.dtp_jobend);
            this.Controls.Add(this.dtp_jobstart);
            this.Controls.Add(this.cmbb_jobtitle);
            this.Name = "Tietojuttu";
            this.Text = "Työntekijän tiedot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_jobstart;
        private System.Windows.Forms.DateTimePicker dtp_jobend;
        private System.Windows.Forms.TextBox txtb_sukunimi;
        private System.Windows.Forms.Label lbl_etunimi;
        private System.Windows.Forms.Label lbl_sukunimi;
        private System.Windows.Forms.Label lbl_hetu;
        private System.Windows.Forms.Label lbl_jobstart;
        private System.Windows.Forms.Label lbl_jobend;
        private System.Windows.Forms.ComboBox cmbb_jobtitle;
        private System.Windows.Forms.Label lbl_tyonimike;
        private System.Windows.Forms.DateTimePicker dtp_syntpv;
        private System.Windows.Forms.Button btn_tallenna;
        private System.Windows.Forms.TextBox txtb_etunimi;
    }
}

