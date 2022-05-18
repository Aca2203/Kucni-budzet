
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
            this.grid_promet = new System.Windows.Forms.DataGridView();
            this.lbl_linija = new System.Windows.Forms.Label();
            this.cmb_datum = new System.Windows.Forms.DateTimePicker();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_novcanik = new System.Windows.Forms.Label();
            this.cmb_novcanik = new System.Windows.Forms.ComboBox();
            this.lbl_ulaz = new System.Windows.Forms.Label();
            this.lbl_izlaz = new System.Windows.Forms.Label();
            this.lbl_kolicina = new System.Windows.Forms.Label();
            this.txt_ulaz = new System.Windows.Forms.TextBox();
            this.txt_izlaz = new System.Windows.Forms.TextBox();
            this.txt_kolicina = new System.Windows.Forms.TextBox();
            this.lbl_trosak = new System.Windows.Forms.Label();
            this.lbl_org = new System.Windows.Forms.Label();
            this.lbl_firma = new System.Windows.Forms.Label();
            this.cmb_org = new System.Windows.Forms.ComboBox();
            this.cmb_trosak = new System.Windows.Forms.ComboBox();
            this.cmb_firma = new System.Windows.Forms.ComboBox();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.txt_opis = new System.Windows.Forms.TextBox();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.txt_stanje = new System.Windows.Forms.TextBox();
            this.lbl_stanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(20, 19);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(158, 26);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_ime_prezime
            // 
            this.lbl_ime_prezime.AutoSize = true;
            this.lbl_ime_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime_prezime.Location = new System.Drawing.Point(9, 63);
            this.lbl_ime_prezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ime_prezime.Name = "lbl_ime_prezime";
            this.lbl_ime_prezime.Size = new System.Drawing.Size(173, 26);
            this.lbl_ime_prezime.TabIndex = 1;
            this.lbl_ime_prezime.Text = "Име и презиме:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(181, 16);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(332, 32);
            this.txt_email.TabIndex = 2;
            // 
            // txt_ime_prezime
            // 
            this.txt_ime_prezime.Enabled = false;
            this.txt_ime_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime_prezime.Location = new System.Drawing.Point(181, 61);
            this.txt_ime_prezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ime_prezime.Name = "txt_ime_prezime";
            this.txt_ime_prezime.Size = new System.Drawing.Size(332, 32);
            this.txt_ime_prezime.TabIndex = 3;
            // 
            // grid_promet
            // 
            this.grid_promet.AllowUserToAddRows = false;
            this.grid_promet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_promet.Location = new System.Drawing.Point(9, 362);
            this.grid_promet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_promet.Name = "grid_promet";
            this.grid_promet.RowHeadersWidth = 51;
            this.grid_promet.RowTemplate.Height = 24;
            this.grid_promet.Size = new System.Drawing.Size(1008, 258);
            this.grid_promet.TabIndex = 4;
            // 
            // lbl_linija
            // 
            this.lbl_linija.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_linija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_linija.Location = new System.Drawing.Point(9, 158);
            this.lbl_linija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_linija.Name = "lbl_linija";
            this.lbl_linija.Size = new System.Drawing.Size(997, 2);
            this.lbl_linija.TabIndex = 5;
            // 
            // cmb_datum
            // 
            this.cmb_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datum.Location = new System.Drawing.Point(9, 214);
            this.cmb_datum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_datum.Name = "cmb_datum";
            this.cmb_datum.Size = new System.Drawing.Size(346, 32);
            this.cmb_datum.TabIndex = 6;
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(145, 174);
            this.lbl_datum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(84, 26);
            this.lbl_datum.TabIndex = 7;
            this.lbl_datum.Text = "Датум:";
            // 
            // lbl_novcanik
            // 
            this.lbl_novcanik.AutoSize = true;
            this.lbl_novcanik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novcanik.Location = new System.Drawing.Point(416, 174);
            this.lbl_novcanik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_novcanik.Name = "lbl_novcanik";
            this.lbl_novcanik.Size = new System.Drawing.Size(117, 26);
            this.lbl_novcanik.TabIndex = 8;
            this.lbl_novcanik.Text = "Новчаник:";
            // 
            // cmb_novcanik
            // 
            this.cmb_novcanik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_novcanik.FormattingEnabled = true;
            this.cmb_novcanik.Location = new System.Drawing.Point(379, 214);
            this.cmb_novcanik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_novcanik.Name = "cmb_novcanik";
            this.cmb_novcanik.Size = new System.Drawing.Size(183, 34);
            this.cmb_novcanik.TabIndex = 9;
            this.cmb_novcanik.SelectedValueChanged += new System.EventHandler(this.cmb_novcanik_SelectedValueChanged);
            // 
            // lbl_ulaz
            // 
            this.lbl_ulaz.AutoSize = true;
            this.lbl_ulaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ulaz.Location = new System.Drawing.Point(614, 174);
            this.lbl_ulaz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ulaz.Name = "lbl_ulaz";
            this.lbl_ulaz.Size = new System.Drawing.Size(68, 26);
            this.lbl_ulaz.TabIndex = 10;
            this.lbl_ulaz.Text = "Улаз:";
            // 
            // lbl_izlaz
            // 
            this.lbl_izlaz.AutoSize = true;
            this.lbl_izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izlaz.Location = new System.Drawing.Point(753, 174);
            this.lbl_izlaz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_izlaz.Name = "lbl_izlaz";
            this.lbl_izlaz.Size = new System.Drawing.Size(81, 26);
            this.lbl_izlaz.TabIndex = 11;
            this.lbl_izlaz.Text = "Излаз:";
            // 
            // lbl_kolicina
            // 
            this.lbl_kolicina.AutoSize = true;
            this.lbl_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kolicina.Location = new System.Drawing.Point(895, 174);
            this.lbl_kolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kolicina.Name = "lbl_kolicina";
            this.lbl_kolicina.Size = new System.Drawing.Size(118, 26);
            this.lbl_kolicina.TabIndex = 12;
            this.lbl_kolicina.Text = "Количина:";
            // 
            // txt_ulaz
            // 
            this.txt_ulaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ulaz.Location = new System.Drawing.Point(584, 214);
            this.txt_ulaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ulaz.Name = "txt_ulaz";
            this.txt_ulaz.Size = new System.Drawing.Size(117, 32);
            this.txt_ulaz.TabIndex = 13;
            // 
            // txt_izlaz
            // 
            this.txt_izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_izlaz.Location = new System.Drawing.Point(730, 214);
            this.txt_izlaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_izlaz.Name = "txt_izlaz";
            this.txt_izlaz.Size = new System.Drawing.Size(117, 32);
            this.txt_izlaz.TabIndex = 14;
            // 
            // txt_kolicina
            // 
            this.txt_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kolicina.Location = new System.Drawing.Point(880, 214);
            this.txt_kolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_kolicina.Name = "txt_kolicina";
            this.txt_kolicina.Size = new System.Drawing.Size(138, 32);
            this.txt_kolicina.TabIndex = 15;
            // 
            // lbl_trosak
            // 
            this.lbl_trosak.AutoSize = true;
            this.lbl_trosak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trosak.Location = new System.Drawing.Point(63, 264);
            this.lbl_trosak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_trosak.Name = "lbl_trosak";
            this.lbl_trosak.Size = new System.Drawing.Size(95, 26);
            this.lbl_trosak.TabIndex = 16;
            this.lbl_trosak.Text = "Трошак:";
            // 
            // lbl_org
            // 
            this.lbl_org.AutoSize = true;
            this.lbl_org.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_org.Location = new System.Drawing.Point(231, 264);
            this.lbl_org.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_org.Name = "lbl_org";
            this.lbl_org.Size = new System.Drawing.Size(272, 26);
            this.lbl_org.TabIndex = 17;
            this.lbl_org.Text = "Организациона јединица:";
            // 
            // lbl_firma
            // 
            this.lbl_firma.AutoSize = true;
            this.lbl_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firma.Location = new System.Drawing.Point(588, 264);
            this.lbl_firma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firma.Name = "lbl_firma";
            this.lbl_firma.Size = new System.Drawing.Size(89, 26);
            this.lbl_firma.TabIndex = 18;
            this.lbl_firma.Text = "Фирма:";
            // 
            // cmb_org
            // 
            this.cmb_org.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_org.FormattingEnabled = true;
            this.cmb_org.Location = new System.Drawing.Point(220, 305);
            this.cmb_org.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_org.Name = "cmb_org";
            this.cmb_org.Size = new System.Drawing.Size(288, 34);
            this.cmb_org.TabIndex = 19;
            // 
            // cmb_trosak
            // 
            this.cmb_trosak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trosak.FormattingEnabled = true;
            this.cmb_trosak.Location = new System.Drawing.Point(9, 305);
            this.cmb_trosak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_trosak.Name = "cmb_trosak";
            this.cmb_trosak.Size = new System.Drawing.Size(185, 34);
            this.cmb_trosak.TabIndex = 20;
            // 
            // cmb_firma
            // 
            this.cmb_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_firma.FormattingEnabled = true;
            this.cmb_firma.Location = new System.Drawing.Point(532, 305);
            this.cmb_firma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_firma.Name = "cmb_firma";
            this.cmb_firma.Size = new System.Drawing.Size(188, 34);
            this.cmb_firma.TabIndex = 21;
            // 
            // lbl_opis
            // 
            this.lbl_opis.AutoSize = true;
            this.lbl_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opis.Location = new System.Drawing.Point(853, 264);
            this.lbl_opis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(70, 26);
            this.lbl_opis.TabIndex = 22;
            this.lbl_opis.Text = "Опис:";
            // 
            // txt_opis
            // 
            this.txt_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opis.Location = new System.Drawing.Point(748, 305);
            this.txt_opis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.Size = new System.Drawing.Size(270, 32);
            this.txt_opis.TabIndex = 23;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(529, 36);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(160, 37);
            this.btn_dodaj.TabIndex = 24;
            this.btn_dodaj.Text = "Додај трансакцију";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(693, 36);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(160, 37);
            this.btn_izmeni.TabIndex = 25;
            this.btn_izmeni.Text = "Измени трансакцију";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(857, 36);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(160, 37);
            this.btn_obrisi.TabIndex = 26;
            this.btn_obrisi.Text = "Обриши трансакцију";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            // 
            // txt_stanje
            // 
            this.txt_stanje.Enabled = false;
            this.txt_stanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stanje.Location = new System.Drawing.Point(181, 108);
            this.txt_stanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_stanje.Name = "txt_stanje";
            this.txt_stanje.Size = new System.Drawing.Size(332, 32);
            this.txt_stanje.TabIndex = 28;
            // 
            // lbl_stanje
            // 
            this.lbl_stanje.AutoSize = true;
            this.lbl_stanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stanje.Location = new System.Drawing.Point(92, 111);
            this.lbl_stanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stanje.Name = "lbl_stanje";
            this.lbl_stanje.Size = new System.Drawing.Size(86, 26);
            this.lbl_stanje.TabIndex = 27;
            this.lbl_stanje.Text = "Стање:";
            // 
            // Transakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 629);
            this.Controls.Add(this.txt_stanje);
            this.Controls.Add(this.lbl_stanje);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.lbl_opis);
            this.Controls.Add(this.cmb_firma);
            this.Controls.Add(this.cmb_trosak);
            this.Controls.Add(this.cmb_org);
            this.Controls.Add(this.lbl_firma);
            this.Controls.Add(this.lbl_org);
            this.Controls.Add(this.lbl_trosak);
            this.Controls.Add(this.txt_kolicina);
            this.Controls.Add(this.txt_izlaz);
            this.Controls.Add(this.txt_ulaz);
            this.Controls.Add(this.lbl_kolicina);
            this.Controls.Add(this.lbl_izlaz);
            this.Controls.Add(this.lbl_ulaz);
            this.Controls.Add(this.cmb_novcanik);
            this.Controls.Add(this.lbl_novcanik);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.cmb_datum);
            this.Controls.Add(this.lbl_linija);
            this.Controls.Add(this.grid_promet);
            this.Controls.Add(this.txt_ime_prezime);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_ime_prezime);
            this.Controls.Add(this.lbl_email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Transakcije";
            this.Text = "Трансакције";
            this.Load += new System.EventHandler(this.Transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ime_prezime;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ime_prezime;
        private System.Windows.Forms.DataGridView grid_promet;
        private System.Windows.Forms.Label lbl_linija;
        private System.Windows.Forms.DateTimePicker cmb_datum;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_novcanik;
        private System.Windows.Forms.ComboBox cmb_novcanik;
        private System.Windows.Forms.Label lbl_ulaz;
        private System.Windows.Forms.Label lbl_izlaz;
        private System.Windows.Forms.Label lbl_kolicina;
        private System.Windows.Forms.TextBox txt_ulaz;
        private System.Windows.Forms.TextBox txt_izlaz;
        private System.Windows.Forms.TextBox txt_kolicina;
        private System.Windows.Forms.Label lbl_trosak;
        private System.Windows.Forms.Label lbl_org;
        private System.Windows.Forms.Label lbl_firma;
        private System.Windows.Forms.ComboBox cmb_org;
        private System.Windows.Forms.ComboBox cmb_trosak;
        private System.Windows.Forms.ComboBox cmb_firma;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.TextBox txt_opis;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.TextBox txt_stanje;
        private System.Windows.Forms.Label lbl_stanje;
    }
}