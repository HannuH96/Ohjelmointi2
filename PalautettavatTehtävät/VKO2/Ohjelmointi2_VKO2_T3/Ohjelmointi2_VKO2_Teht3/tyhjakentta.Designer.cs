namespace Ohjelmointi2_VKO2_Teht3
{
    partial class tyhjakentta
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
            this.lbl_virhe = new System.Windows.Forms.Label();
            this.btn_virhedismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_virhe
            // 
            this.lbl_virhe.AutoSize = true;
            this.lbl_virhe.Location = new System.Drawing.Point(16, 20);
            this.lbl_virhe.Name = "lbl_virhe";
            this.lbl_virhe.Size = new System.Drawing.Size(191, 13);
            this.lbl_virhe.TabIndex = 0;
            this.lbl_virhe.Text = "Jokin kenttä on tyhjä, eihän se nyt käy!";
            // 
            // btn_virhedismiss
            // 
            this.btn_virhedismiss.Location = new System.Drawing.Point(82, 53);
            this.btn_virhedismiss.Name = "btn_virhedismiss";
            this.btn_virhedismiss.Size = new System.Drawing.Size(59, 28);
            this.btn_virhedismiss.TabIndex = 1;
            this.btn_virhedismiss.Text = "OK";
            this.btn_virhedismiss.UseVisualStyleBackColor = true;
            this.btn_virhedismiss.Click += new System.EventHandler(this.Btn_virhedismiss_Click);
            // 
            // tyhjakentta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 93);
            this.Controls.Add(this.btn_virhedismiss);
            this.Controls.Add(this.lbl_virhe);
            this.Name = "tyhjakentta";
            this.Text = "tyhjakentta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_virhe;
        private System.Windows.Forms.Button btn_virhedismiss;
    }
}