
namespace Kucni_budzet_VS
{
    partial class Korisnik_podaci
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
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.ms_pregledi = new System.Windows.Forms.MenuStrip();
            this.i_transakcije = new System.Windows.Forms.ToolStripMenuItem();
            this.i_novcanici = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_pregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(667, 198);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(219, 52);
            this.btn_izmeni.TabIndex = 26;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Enabled = false;
            this.txt_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jmbg.Location = new System.Drawing.Point(183, 209);
            this.txt_jmbg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(327, 32);
            this.txt_jmbg.TabIndex = 25;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lozinka.Location = new System.Drawing.Point(635, 151);
            this.txt_lozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.Size = new System.Drawing.Size(327, 32);
            this.txt_lozinka.TabIndex = 24;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(183, 151);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(327, 32);
            this.txt_email.TabIndex = 23;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(635, 93);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(327, 32);
            this.txt_prezime.TabIndex = 22;
            // 
            // txt_ime
            // 
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(183, 93);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(327, 32);
            this.txt_ime.TabIndex = 21;
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jmbg.Location = new System.Drawing.Point(104, 211);
            this.lbl_jmbg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(73, 26);
            this.lbl_jmbg.TabIndex = 20;
            this.lbl_jmbg.Text = "ЈМБГ:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(523, 95);
            this.lbl_prezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(109, 26);
            this.lbl_prezime.TabIndex = 19;
            this.lbl_prezime.Text = "Презиме:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(116, 95);
            this.lbl_ime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(62, 26);
            this.lbl_ime.TabIndex = 18;
            this.lbl_ime.Text = "Име:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(524, 154);
            this.lbl_lozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(104, 26);
            this.lbl_lozinka.TabIndex = 17;
            this.lbl_lozinka.Text = "Лозинка:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(22, 154);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(158, 26);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(16, 46);
            this.lbl_tekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(224, 26);
            this.lbl_tekst.TabIndex = 15;
            this.lbl_tekst.Text = "Подаци о кориснику:";
            // 
            // ms_pregledi
            // 
            this.ms_pregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_pregledi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_pregledi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_transakcije,
            this.i_novcanici});
            this.ms_pregledi.Location = new System.Drawing.Point(0, 0);
            this.ms_pregledi.Name = "ms_pregledi";
            this.ms_pregledi.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_pregledi.Size = new System.Drawing.Size(975, 24);
            this.ms_pregledi.TabIndex = 29;
            this.ms_pregledi.Text = "Прегледи";
            // 
            // i_transakcije
            // 
            this.i_transakcije.Name = "i_transakcije";
            this.i_transakcije.Size = new System.Drawing.Size(142, 20);
            this.i_transakcije.Text = "Преглед трансакција";
            this.i_transakcije.Click += new System.EventHandler(this.i_transakcije_Click);
            // 
            // i_novcanici
            // 
            this.i_novcanici.Name = "i_novcanici";
            this.i_novcanici.Size = new System.Drawing.Size(132, 20);
            this.i_novcanici.Text = "Преглед новчаника";
            this.i_novcanici.Click += new System.EventHandler(this.i_novcanici_Click);
            // 
            // Korisnik_podaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 287);
            this.Controls.Add(this.ms_pregledi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_tekst);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Korisnik_podaci";
            this.Text = "Корисник - подаци";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Korisnik_FormClosed);
            this.Load += new System.EventHandler(this.Korisnik_podaci_Load);
            this.ms_pregledi.ResumeLayout(false);
            this.ms_pregledi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.MenuStrip ms_pregledi;
        private System.Windows.Forms.ToolStripMenuItem i_transakcije;
        private System.Windows.Forms.ToolStripMenuItem i_novcanici;
    }
}