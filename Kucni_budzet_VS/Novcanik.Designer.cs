
namespace Kucni_budzet_VS
{
    partial class Novcanik
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
            this.components = new System.ComponentModel.Container();
            this.txt_pozicija = new System.Windows.Forms.TextBox();
            this.txt_stanje = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.lbl_stanje = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.lbl_prebacivanje = new System.Windows.Forms.Label();
            this.cmb_iz = new System.Windows.Forms.ComboBox();
            this.cmb_u = new System.Windows.Forms.ComboBox();
            this.lbl_linija = new System.Windows.Forms.Label();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.lbl_iz = new System.Windows.Forms.Label();
            this.lbl_u = new System.Windows.Forms.Label();
            this.lbl_suma = new System.Windows.Forms.Label();
            this.btn_prebaci = new System.Windows.Forms.Button();
            this.lbl_poruka = new System.Windows.Forms.Label();
            this.stoperica = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_pozicija
            // 
            this.txt_pozicija.Enabled = false;
            this.txt_pozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pozicija.Location = new System.Drawing.Point(649, 11);
            this.txt_pozicija.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pozicija.Name = "txt_pozicija";
            this.txt_pozicija.Size = new System.Drawing.Size(77, 32);
            this.txt_pozicija.TabIndex = 54;
            // 
            // txt_stanje
            // 
            this.txt_stanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stanje.Location = new System.Drawing.Point(223, 114);
            this.txt_stanje.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stanje.Name = "txt_stanje";
            this.txt_stanje.Size = new System.Drawing.Size(327, 32);
            this.txt_stanje.TabIndex = 53;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_naziv.Location = new System.Drawing.Point(223, 66);
            this.txt_naziv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(327, 32);
            this.txt_naziv.TabIndex = 52;
            // 
            // lbl_stanje
            // 
            this.lbl_stanje.AutoSize = true;
            this.lbl_stanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stanje.Location = new System.Drawing.Point(132, 117);
            this.lbl_stanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stanje.Name = "lbl_stanje";
            this.lbl_stanje.Size = new System.Drawing.Size(86, 26);
            this.lbl_stanje.TabIndex = 51;
            this.lbl_stanje.Text = "Стање:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naziv.Location = new System.Drawing.Point(137, 69);
            this.lbl_naziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(81, 26);
            this.lbl_naziv.TabIndex = 50;
            this.lbl_naziv.Text = "Назив:";
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(241, 23);
            this.lbl_tekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(257, 26);
            this.lbl_tekst.TabIndex = 49;
            this.lbl_tekst.Text = "Подаци о новчаницима:";
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sledeci.Location = new System.Drawing.Point(487, 197);
            this.btn_sledeci.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(63, 52);
            this.btn_sledeci.TabIndex = 61;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prethodni.Location = new System.Drawing.Point(223, 197);
            this.btn_prethodni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(63, 52);
            this.btn_prethodni.TabIndex = 60;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prvi.Location = new System.Drawing.Point(16, 197);
            this.btn_prvi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(63, 52);
            this.btn_prvi.TabIndex = 59;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poslednji.Location = new System.Drawing.Point(663, 197);
            this.btn_poslednji.Margin = new System.Windows.Forms.Padding(2);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(63, 52);
            this.btn_poslednji.TabIndex = 58;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(507, 262);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(219, 52);
            this.btn_obrisi.TabIndex = 57;
            this.btn_obrisi.Text = "Обриши новчаник";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(16, 262);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(219, 52);
            this.btn_dodaj.TabIndex = 56;
            this.btn_dodaj.Text = "Додај новчаник";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(260, 262);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(219, 52);
            this.btn_izmeni.TabIndex = 55;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // lbl_prebacivanje
            // 
            this.lbl_prebacivanje.AutoSize = true;
            this.lbl_prebacivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prebacivanje.Location = new System.Drawing.Point(254, 362);
            this.lbl_prebacivanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prebacivanje.Name = "lbl_prebacivanje";
            this.lbl_prebacivanje.Size = new System.Drawing.Size(229, 26);
            this.lbl_prebacivanje.TabIndex = 62;
            this.lbl_prebacivanje.Text = "Пребацивање новца:";
            // 
            // cmb_iz
            // 
            this.cmb_iz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_iz.FormattingEnabled = true;
            this.cmb_iz.Location = new System.Drawing.Point(141, 412);
            this.cmb_iz.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_iz.Name = "cmb_iz";
            this.cmb_iz.Size = new System.Drawing.Size(183, 34);
            this.cmb_iz.TabIndex = 63;
            // 
            // cmb_u
            // 
            this.cmb_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_u.FormattingEnabled = true;
            this.cmb_u.Location = new System.Drawing.Point(141, 472);
            this.cmb_u.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_u.Name = "cmb_u";
            this.cmb_u.Size = new System.Drawing.Size(183, 34);
            this.cmb_u.TabIndex = 64;
            // 
            // lbl_linija
            // 
            this.lbl_linija.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_linija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_linija.Location = new System.Drawing.Point(12, 336);
            this.lbl_linija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_linija.Name = "lbl_linija";
            this.lbl_linija.Size = new System.Drawing.Size(714, 2);
            this.lbl_linija.TabIndex = 65;
            // 
            // txt_suma
            // 
            this.txt_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma.Location = new System.Drawing.Point(141, 538);
            this.txt_suma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(183, 32);
            this.txt_suma.TabIndex = 66;
            // 
            // lbl_iz
            // 
            this.lbl_iz.AutoSize = true;
            this.lbl_iz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iz.Location = new System.Drawing.Point(83, 415);
            this.lbl_iz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_iz.Name = "lbl_iz";
            this.lbl_iz.Size = new System.Drawing.Size(45, 26);
            this.lbl_iz.TabIndex = 67;
            this.lbl_iz.Text = "Из:";
            // 
            // lbl_u
            // 
            this.lbl_u.AutoSize = true;
            this.lbl_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_u.Location = new System.Drawing.Point(96, 475);
            this.lbl_u.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_u.Name = "lbl_u";
            this.lbl_u.Size = new System.Drawing.Size(32, 26);
            this.lbl_u.TabIndex = 68;
            this.lbl_u.Text = "У:";
            // 
            // lbl_suma
            // 
            this.lbl_suma.AutoSize = true;
            this.lbl_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma.Location = new System.Drawing.Point(55, 541);
            this.lbl_suma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_suma.Name = "lbl_suma";
            this.lbl_suma.Size = new System.Drawing.Size(73, 26);
            this.lbl_suma.TabIndex = 69;
            this.lbl_suma.Text = "Сума:";
            // 
            // btn_prebaci
            // 
            this.btn_prebaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prebaci.Location = new System.Drawing.Point(459, 462);
            this.btn_prebaci.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prebaci.Name = "btn_prebaci";
            this.btn_prebaci.Size = new System.Drawing.Size(219, 52);
            this.btn_prebaci.TabIndex = 70;
            this.btn_prebaci.Text = "Пребаци новац";
            this.btn_prebaci.UseVisualStyleBackColor = true;
            this.btn_prebaci.Click += new System.EventHandler(this.btn_prebaci_Click);
            // 
            // lbl_poruka
            // 
            this.lbl_poruka.AutoSize = true;
            this.lbl_poruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poruka.ForeColor = System.Drawing.Color.Red;
            this.lbl_poruka.Location = new System.Drawing.Point(83, 592);
            this.lbl_poruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_poruka.Name = "lbl_poruka";
            this.lbl_poruka.Size = new System.Drawing.Size(0, 26);
            this.lbl_poruka.TabIndex = 72;
            // 
            // stoperica
            // 
            this.stoperica.Interval = 2500;
            this.stoperica.Tick += new System.EventHandler(this.stoperica_Tick);
            // 
            // Novcanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 637);
            this.Controls.Add(this.lbl_poruka);
            this.Controls.Add(this.btn_prebaci);
            this.Controls.Add(this.lbl_suma);
            this.Controls.Add(this.lbl_u);
            this.Controls.Add(this.lbl_iz);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.lbl_linija);
            this.Controls.Add(this.cmb_u);
            this.Controls.Add(this.cmb_iz);
            this.Controls.Add(this.lbl_prebacivanje);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.txt_pozicija);
            this.Controls.Add(this.txt_stanje);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.lbl_stanje);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_tekst);
            this.Name = "Novcanik";
            this.Text = "Новчаник";
            this.Load += new System.EventHandler(this.Novcanik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pozicija;
        private System.Windows.Forms.TextBox txt_stanje;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.Label lbl_stanje;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Label lbl_prebacivanje;
        private System.Windows.Forms.ComboBox cmb_iz;
        private System.Windows.Forms.ComboBox cmb_u;
        private System.Windows.Forms.Label lbl_linija;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.Label lbl_iz;
        private System.Windows.Forms.Label lbl_u;
        private System.Windows.Forms.Label lbl_suma;
        private System.Windows.Forms.Button btn_prebaci;
        private System.Windows.Forms.Label lbl_poruka;
        private System.Windows.Forms.Timer stoperica;
    }
}