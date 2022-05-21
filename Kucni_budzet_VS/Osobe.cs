using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kucni_budzet_VS
{
    public partial class Osobe : Form
    {
        SqlConnection veza = Kontrole.Povezi();
        int broj_sloga = 0;
        SqlDataAdapter adapter;
        DataTable tabela, dt_podaci;

        public Osobe()
        {
            InitializeComponent();
        }

        private void Osobe_Load(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void Ucitaj_Podatke()
        {
            adapter = new SqlDataAdapter("SELECT id, naziv FROM Uloga", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            
            cmb_uloga.DataSource = tabela;
            cmb_uloga.ValueMember = "id";
            cmb_uloga.DisplayMember = "naziv";

            adapter = new SqlDataAdapter("SELECT * FROM Osoba", veza);
            dt_podaci = new DataTable();
            adapter.Fill(dt_podaci);            
        }

        private void Txt_Ucitaj()
        {
            if (dt_podaci.Rows.Count != 0)
            {                
                txt_ime.Text = dt_podaci.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = dt_podaci.Rows[broj_sloga]["prezime"].ToString();
                txt_email.Text = dt_podaci.Rows[broj_sloga]["email"].ToString();
                txt_lozinka.Text = dt_podaci.Rows[broj_sloga]["lozinka"].ToString();                
                txt_jmbg.Text = dt_podaci.Rows[broj_sloga]["jmbg"].ToString();
                cmb_uloga.SelectedValue = dt_podaci.Rows[broj_sloga]["FK_uloga_id"];

                txt_pozicija.Text = (broj_sloga + 1) + "/" + dt_podaci.Rows.Count;

                btn_izmeni.Enabled = true;
                btn_obrisi.Enabled = true;
                if (broj_sloga == 0)
                {
                    btn_prvi.Enabled = false;
                    btn_prethodni.Enabled = false;
                }
                else
                {
                    btn_prvi.Enabled = true;
                    btn_prethodni.Enabled = true;
                }

                if (broj_sloga == dt_podaci.Rows.Count - 1)
                {
                    btn_poslednji.Enabled = false;
                    btn_sledeci.Enabled = false;
                }
                else
                {
                    btn_poslednji.Enabled = true;
                    btn_sledeci.Enabled = true;
                }
            }
            else
            {                
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_email.Text = "";
                txt_lozinka.Text = "";
                txt_jmbg.Text = "";                
                txt_pozicija.Text = "0";

                btn_prvi.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_poslednji.Enabled = false;
                btn_sledeci.Enabled = false;
                btn_izmeni.Enabled = false;
                btn_obrisi.Enabled = false;
            }
        }

        private void btn_prvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Ucitaj();
        }

        private void btn_poslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = dt_podaci.Rows.Count - 1;
            Txt_Ucitaj();
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Ucitaj();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Ucitaj();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Osoba SET ");
            naredba.Append("ime = N'" + txt_ime.Text + "', ");
            naredba.Append("prezime = N'" + txt_prezime.Text + "', ");
            naredba.Append("jmbg = '" + txt_jmbg.Text + "', ");
            naredba.Append("lozinka = '" + txt_lozinka.Text + "', ");
            naredba.Append("FK_uloga_id = " + cmb_uloga.SelectedValue + " ");
            naredba.Append("WHERE email = '" + txt_email.Text + "'");
            //MessageBox.Show(naredba.ToString());
            
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM Osoba WHERE email = '" + txt_email.Text + "'";
            //MessageBox.Show(naredba.ToString());
            
            SqlCommand komanda = new SqlCommand(naredba, veza);
            bool brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if (brisano)
            {
                Ucitaj_Podatke();
                if (broj_sloga > 0) broj_sloga--;

                Txt_Ucitaj();
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO Osoba(ime, prezime, jmbg, email, lozinka, FK_uloga_id) VALUES (N'");
            naredba.Append(txt_ime.Text + "', N'");
            naredba.Append(txt_prezime.Text + "', '");
            naredba.Append(txt_jmbg.Text + "', '");
            naredba.Append(txt_email.Text + "', '");
            naredba.Append(txt_lozinka.Text + "', ");
            naredba.Append(cmb_uloga.SelectedValue + ")");
            //MessageBox.Show(naredba.ToString());
            
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Ucitaj();
        }
    }
}
