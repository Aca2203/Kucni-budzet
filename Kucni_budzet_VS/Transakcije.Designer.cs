
namespace Kucni_budzet_VS
{
    partial class Transakcije
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
            this.lbl_ime_prezime = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ime_prezime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(27, 23);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(198, 34);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_ime_prezime
            // 
            this.lbl_ime_prezime.AutoSize = true;
            this.lbl_ime_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime_prezime.Location = new System.Drawing.Point(12, 78);
            this.lbl_ime_prezime.Name = "lbl_ime_prezime";
            this.lbl_ime_prezime.Size = new System.Drawing.Size(213, 34);
            this.lbl_ime_prezime.TabIndex = 1;
            this.lbl_ime_prezime.Text = "Име и презиме:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(241, 20);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(441, 40);
            this.txt_email.TabIndex = 2;
            // 
            // txt_ime_prezime
            // 
            this.txt_ime_prezime.Enabled = false;
            this.txt_ime_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime_prezime.Location = new System.Drawing.Point(241, 75);
            this.txt_ime_prezime.Name = "txt_ime_prezime";
            this.txt_ime_prezime.Size = new System.Drawing.Size(441, 40);
            this.txt_ime_prezime.TabIndex = 3;
            // 
            // Transakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 709);
            this.Controls.Add(this.txt_ime_prezime);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_ime_prezime);
            this.Controls.Add(this.lbl_email);
            this.Name = "Transakcije";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.Transakcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ime_prezime;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ime_prezime;
    }
}