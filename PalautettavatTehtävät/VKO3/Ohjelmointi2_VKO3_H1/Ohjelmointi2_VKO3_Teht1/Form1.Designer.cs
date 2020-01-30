namespace Ohjelmointi2_VKO3_Teht1
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
            this.btn_nappi1 = new System.Windows.Forms.Button();
            this.btn_nappi2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nappi1
            // 
            this.btn_nappi1.Location = new System.Drawing.Point(99, 87);
            this.btn_nappi1.Name = "btn_nappi1";
            this.btn_nappi1.Size = new System.Drawing.Size(75, 23);
            this.btn_nappi1.TabIndex = 0;
            this.btn_nappi1.Text = "Luo kenttä";
            this.btn_nappi1.UseVisualStyleBackColor = true;
            this.btn_nappi1.Click += new System.EventHandler(this.Btn_nappi1_Click);
            // 
            // btn_nappi2
            // 
            this.btn_nappi2.Location = new System.Drawing.Point(99, 146);
            this.btn_nappi2.Name = "btn_nappi2";
            this.btn_nappi2.Size = new System.Drawing.Size(75, 23);
            this.btn_nappi2.TabIndex = 1;
            this.btn_nappi2.Text = "Luo kenttä";
            this.btn_nappi2.UseVisualStyleBackColor = true;
            this.btn_nappi2.Click += new System.EventHandler(this.Btn_nappi2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 345);
            this.Controls.Add(this.btn_nappi2);
            this.Controls.Add(this.btn_nappi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nappi1;
        private System.Windows.Forms.Button btn_nappi2;
    }
}

