
namespace Kucni_budzet_VS
{
    partial class Prijava
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
            this.lbl_poruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(33, 60);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(198, 34);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(101, 116);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(130, 34);
            this.lbl_lozinka.TabIndex = 1;
            this.lbl_lozinka.Text = "Лозинка:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(251, 57);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(509, 40);
            this.txt_email.TabIndex = 2;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lozinka.Location = new System.Drawing.Point(251, 113);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.PasswordChar = '*';
            this.txt_lozinka.Size = new System.Drawing.Size(509, 40);
            this.txt_lozinka.TabIndex = 3;
            // 
            // btn_prijava
            // 
            this.btn_prijava.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prijava.Location = new System.Drawing.Point(275, 196);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(275, 59);
            this.btn_prijava.TabIndex = 4;
            this.btn_prijava.Text = "Пријави се!";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.btn_prijava_Click);
            // 
            // lbl_poruka
            // 
            this.lbl_poruka.AutoSize = true;
            this.lbl_poruka.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poruka.ForeColor = System.Drawing.Color.Red;
            this.lbl_poruka.Location = new System.Drawing.Point(35, 280);
            this.lbl_poruka.Name = "lbl_poruka";
            this.lbl_poruka.Size = new System.Drawing.Size(0, 21);
            this.lbl_poruka.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 329);
            this.Controls.Add(this.lbl_poruka);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_email);
            this.Name = "Login";
            this.Text = "Пријава";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.Button btn_prijava;
        private System.Windows.Forms.Label lbl_poruka;
    }
}

