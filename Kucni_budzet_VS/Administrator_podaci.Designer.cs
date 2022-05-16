
namespace Kucni_budzet_VS
{
    partial class Administrator_podaci
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
            this.ms_pregledi = new System.Windows.Forms.MenuStrip();
            this.i_transakcije = new System.Windows.Forms.ToolStripMenuItem();
            this.i_osobe = new System.Windows.Forms.ToolStripMenuItem();
            this.i_sifarnici = new System.Windows.Forms.ToolStripMenuItem();
            this.i_novcanici = new System.Windows.Forms.ToolStripMenuItem();
            this.i_troskovi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_organizacione_jedinice = new System.Windows.Forms.ToolStripMenuItem();
            this.i_firme = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.lbl_stanje = new System.Windows.Forms.Label();
            this.txt_stanje = new System.Windows.Forms.TextBox();
            this.ms_pregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_pregledi
            // 
            this.ms_pregledi.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_pregledi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_pregledi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_transakcije,
            this.i_osobe,
            this.i_sifarnici});
            this.ms_pregledi.Location = new System.Drawing.Point(0, 0);
            this.ms_pregledi.Name = "ms_pregledi";
            this.ms_pregledi.Size = new System.Drawing.Size(1292, 26);
            this.ms_pregledi.TabIndex = 0;
            this.ms_pregledi.Text = "Прегледи";
            // 
            // i_transakcije
            // 
            this.i_transakcije.Name = "i_transakcije";
            this.i_transakcije.Size = new System.Drawing.Size(169, 22);
            this.i_transakcije.Text = "Преглед трансакција";
            this.i_transakcije.Click += new System.EventHandler(this.i_transakcije_Click);
            // 
            // i_osobe
            // 
            this.i_osobe.Name = "i_osobe";
            this.i_osobe.Size = new System.Drawing.Size(122, 22);
            this.i_osobe.Text = "Преглед особа";
            // 
            // i_sifarnici
            // 
            this.i_sifarnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_novcanici,
            this.i_troskovi,
            this.i_organizacione_jedinice,
            this.i_firme});
            this.i_sifarnici.Name = "i_sifarnici";
            this.i_sifarnici.Size = new System.Drawing.Size(165, 22);
            this.i_sifarnici.Text = "Преглед шифарника";
            // 
            // i_novcanici
            // 
            this.i_novcanici.Name = "i_novcanici";
            this.i_novcanici.Size = new System.Drawing.Size(267, 26);
            this.i_novcanici.Text = "Новчаници";
            // 
            // i_troskovi
            // 
            this.i_troskovi.Name = "i_troskovi";
            this.i_troskovi.Size = new System.Drawing.Size(267, 26);
            this.i_troskovi.Text = "Трошкови";
            // 
            // i_organizacione_jedinice
            // 
            this.i_organizacione_jedinice.Name = "i_organizacione_jedinice";
            this.i_organizacione_jedinice.Size = new System.Drawing.Size(267, 26);
            this.i_organizacione_jedinice.Text = "Организационе јединице";
            // 
            // i_firme
            // 
            this.i_firme.Name = "i_firme";
            this.i_firme.Size = new System.Drawing.Size(267, 26);
            this.i_firme.Text = "Фирме";
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(12, 51);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(360, 34);
            this.lbl_tekst.TabIndex = 1;
            this.lbl_tekst.Text = "Подаци о администратору:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(20, 184);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(198, 34);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(689, 184);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(130, 34);
            this.lbl_lozinka.TabIndex = 3;
            this.lbl_lozinka.Text = "Лозинка:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(145, 112);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(73, 34);
            this.lbl_ime.TabIndex = 4;
            this.lbl_ime.Text = "Име:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(688, 112);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(131, 34);
            this.lbl_prezime.TabIndex = 5;
            this.lbl_prezime.Text = "Презиме:";
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jmbg.Location = new System.Drawing.Point(130, 255);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(88, 34);
            this.lbl_jmbg.TabIndex = 6;
            this.lbl_jmbg.Text = "ЈМБГ:";
            // 
            // txt_ime
            // 
            this.txt_ime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(235, 109);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(435, 40);
            this.txt_ime.TabIndex = 7;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(838, 109);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(435, 40);
            this.txt_prezime.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(235, 181);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(435, 40);
            this.txt_email.TabIndex = 9;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lozinka.Location = new System.Drawing.Point(838, 181);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.Size = new System.Drawing.Size(435, 40);
            this.txt_lozinka.TabIndex = 10;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jmbg.Location = new System.Drawing.Point(235, 252);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(435, 40);
            this.txt_jmbg.TabIndex = 11;
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(873, 330);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(292, 64);
            this.btn_izmeni.TabIndex = 12;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // lbl_stanje
            // 
            this.lbl_stanje.AutoSize = true;
            this.lbl_stanje.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stanje.Location = new System.Drawing.Point(18, 346);
            this.lbl_stanje.Name = "lbl_stanje";
            this.lbl_stanje.Size = new System.Drawing.Size(200, 34);
            this.lbl_stanje.TabIndex = 13;
            this.lbl_stanje.Text = "Укупно стање:";
            // 
            // txt_stanje
            // 
            this.txt_stanje.Enabled = false;
            this.txt_stanje.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stanje.Location = new System.Drawing.Point(235, 343);
            this.txt_stanje.Name = "txt_stanje";
            this.txt_stanje.Size = new System.Drawing.Size(220, 40);
            this.txt_stanje.TabIndex = 14;
            // 
            // Administrator_podaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 500);
            this.Controls.Add(this.txt_stanje);
            this.Controls.Add(this.lbl_stanje);
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
            this.Controls.Add(this.ms_pregledi);
            this.MainMenuStrip = this.ms_pregledi;
            this.Name = "Administrator_podaci";
            this.Text = "Администратор - подаци";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.ms_pregledi.ResumeLayout(false);
            this.ms_pregledi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_pregledi;
        private System.Windows.Forms.ToolStripMenuItem i_transakcije;
        private System.Windows.Forms.ToolStripMenuItem i_osobe;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.ToolStripMenuItem i_sifarnici;
        private System.Windows.Forms.ToolStripMenuItem i_novcanici;
        private System.Windows.Forms.ToolStripMenuItem i_troskovi;
        private System.Windows.Forms.ToolStripMenuItem i_organizacione_jedinice;
        private System.Windows.Forms.ToolStripMenuItem i_firme;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Label lbl_stanje;
        private System.Windows.Forms.TextBox txt_stanje;
    }
}