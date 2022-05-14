
namespace Kucni_budzet_VS
{
    partial class Login
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.btn_prijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(219, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(101, 17);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Location = new System.Drawing.Point(252, 181);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(68, 17);
            this.lbl_lozinka.TabIndex = 1;
            this.lbl_lozinka.Text = "Лозинка:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(353, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(265, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Location = new System.Drawing.Point(353, 178);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.Size = new System.Drawing.Size(265, 22);
            this.txt_lozinka.TabIndex = 3;
            // 
            // btn_prijava
            // 
            this.btn_prijava.Location = new System.Drawing.Point(339, 232);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(152, 42);
            this.btn_prijava.TabIndex = 4;
            this.btn_prijava.Text = "Пријави се!";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_email);
            this.Name = "Login";
            this.Text = "Пријава";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.Button btn_prijava;
    }
}

