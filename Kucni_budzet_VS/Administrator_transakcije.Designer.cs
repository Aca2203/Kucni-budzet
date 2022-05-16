
namespace Kucni_budzet_VS
{
    partial class Administrator_transakcije
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
            this.grid_promet = new System.Windows.Forms.DataGridView();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.cmb_datum = new System.Windows.Forms.DateTimePicker();
            this.lbl_vreme = new System.Windows.Forms.Label();
            this.cmb_vreme = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ime_prezime = new System.Windows.Forms.Label();
            this.cmb_email = new System.Windows.Forms.ComboBox();
            this.txt_ime_prezime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_promet
            // 
            this.grid_promet.AllowUserToAddRows = false;
            this.grid_promet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_promet.Location = new System.Drawing.Point(12, 362);
            this.grid_promet.Name = "grid_promet";
            this.grid_promet.RowHeadersWidth = 51;
            this.grid_promet.RowTemplate.Height = 24;
            this.grid_promet.Size = new System.Drawing.Size(1440, 348);
            this.grid_promet.TabIndex = 0;
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(187, 19);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(101, 34);
            this.lbl_datum.TabIndex = 1;
            this.lbl_datum.Text = "Датум:";
            // 
            // cmb_datum
            // 
            this.cmb_datum.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datum.Location = new System.Drawing.Point(12, 71);
            this.cmb_datum.Name = "cmb_datum";
            this.cmb_datum.Size = new System.Drawing.Size(436, 40);
            this.cmb_datum.TabIndex = 2;
            // 
            // lbl_vreme
            // 
            this.lbl_vreme.AutoSize = true;
            this.lbl_vreme.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vreme.Location = new System.Drawing.Point(568, 19);
            this.lbl_vreme.Name = "lbl_vreme";
            this.lbl_vreme.Size = new System.Drawing.Size(101, 34);
            this.lbl_vreme.TabIndex = 3;
            this.lbl_vreme.Text = "Време:";
            // 
            // cmb_vreme
            // 
            this.cmb_vreme.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vreme.Location = new System.Drawing.Point(535, 70);
            this.cmb_vreme.Name = "cmb_vreme";
            this.cmb_vreme.Size = new System.Drawing.Size(143, 40);
            this.cmb_vreme.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(857, 19);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(198, 34);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_ime_prezime
            // 
            this.lbl_ime_prezime.AutoSize = true;
            this.lbl_ime_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime_prezime.Location = new System.Drawing.Point(1208, 19);
            this.lbl_ime_prezime.Name = "lbl_ime_prezime";
            this.lbl_ime_prezime.Size = new System.Drawing.Size(213, 34);
            this.lbl_ime_prezime.TabIndex = 7;
            this.lbl_ime_prezime.Text = "Име и презиме:";
            // 
            // cmb_email
            // 
            this.cmb_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_email.FormattingEnabled = true;
            this.cmb_email.Location = new System.Drawing.Point(766, 70);
            this.cmb_email.Name = "cmb_email";
            this.cmb_email.Size = new System.Drawing.Size(354, 41);
            this.cmb_email.TabIndex = 8;
            // 
            // txt_ime_prezime
            // 
            this.txt_ime_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime_prezime.Location = new System.Drawing.Point(1164, 71);
            this.txt_ime_prezime.Name = "txt_ime_prezime";
            this.txt_ime_prezime.Size = new System.Drawing.Size(288, 40);
            this.txt_ime_prezime.TabIndex = 9;
            // 
            // Administrator_transakcije
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1464, 722);
            this.Controls.Add(this.txt_ime_prezime);
            this.Controls.Add(this.cmb_email);
            this.Controls.Add(this.lbl_ime_prezime);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.cmb_vreme);
            this.Controls.Add(this.lbl_vreme);
            this.Controls.Add(this.cmb_datum);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.grid_promet);
            this.Name = "Administrator_transakcije";
            this.Text = "Администратор - трансакције";
            this.Load += new System.EventHandler(this.Administrator_transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_promet;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.DateTimePicker cmb_datum;
        private System.Windows.Forms.Label lbl_vreme;
        private System.Windows.Forms.TextBox cmb_vreme;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ime_prezime;
        private System.Windows.Forms.ComboBox cmb_email;
        private System.Windows.Forms.TextBox txt_ime_prezime;
    }
}