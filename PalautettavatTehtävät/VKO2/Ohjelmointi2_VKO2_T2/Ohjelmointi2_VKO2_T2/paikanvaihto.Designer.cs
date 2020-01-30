namespace Ohjelmointi2_VKO2_T2
{
    partial class Paikanvaihto
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
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.txtb_x = new System.Windows.Forms.TextBox();
            this.txtb_y = new System.Windows.Forms.TextBox();
            this.btn_siirra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(67, 82);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(14, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(67, 108);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(14, 13);
            this.lbl_y.TabIndex = 1;
            this.lbl_y.Text = "Y";
            // 
            // txtb_x
            // 
            this.txtb_x.Location = new System.Drawing.Point(109, 79);
            this.txtb_x.Name = "txtb_x";
            this.txtb_x.Size = new System.Drawing.Size(75, 20);
            this.txtb_x.TabIndex = 2;
            // 
            // txtb_y
            // 
            this.txtb_y.Location = new System.Drawing.Point(109, 105);
            this.txtb_y.Name = "txtb_y";
            this.txtb_y.Size = new System.Drawing.Size(75, 20);
            this.txtb_y.TabIndex = 3;
            // 
            // btn_siirra
            // 
            this.btn_siirra.Location = new System.Drawing.Point(109, 131);
            this.btn_siirra.Name = "btn_siirra";
            this.btn_siirra.Size = new System.Drawing.Size(75, 20);
            this.btn_siirra.TabIndex = 4;
            this.btn_siirra.Text = "Vaihda";
            this.btn_siirra.UseVisualStyleBackColor = true;
            this.btn_siirra.Click += new System.EventHandler(this.Btn_siirra_Click);
            // 
            // Paikanvaihto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_siirra);
            this.Controls.Add(this.txtb_y);
            this.Controls.Add(this.txtb_x);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Name = "Paikanvaihto";
            this.Text = "Paikanvaihto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.TextBox txtb_x;
        private System.Windows.Forms.TextBox txtb_y;
        private System.Windows.Forms.Button btn_siirra;
    }
}

