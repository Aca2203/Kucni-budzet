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
    public partial class Novcanik : Form
    {
        SqlConnection veza = Kontrole.Povezi();
        int broj_sloga = 0, id = 0;
        SqlDataAdapter adapter;
        DataTable dt_podaci;

        public Novcanik()
        {
            InitializeComponent();
        }

        private void Novcanik_Load(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Txt_Ucitaj();
            Cmb_Ucitaj();
        }

        private void Ucitaj_Podatke()
        {                     
            adapter = new SqlDataAdapter("SELECT * FROM Novcanik WHERE FK_osoba_email = '" + Program.email + "'", veza);
            dt_podaci = new DataTable();
            adapter.Fill(dt_podaci);
        }        

        private void Txt_Ucitaj()
        {
            if (dt_podaci.Rows.Count != 0)
            {
                txt_naziv.Text = dt_podaci.Rows[broj_sloga]["naziv"].ToString();
                txt_stanje.Text = dt_podaci.Rows[broj_sloga]["stanje"].ToString();
                id = (int) dt_podaci.Rows[broj_sloga]["id"];

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
                txt_naziv.Text = "";
                txt_stanje.Text = "";
                txt_pozicija.Text = "0";

                btn_prvi.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_poslednji.Enabled = false;
                btn_sledeci.Enabled = false;
                btn_izmeni.Enabled = false;
                btn_obrisi.Enabled = false;
            }
        }

        private void Cmb_Ucitaj()
        {
            DataTable dt_podaci_1 = dt_podaci.Copy();
            DataTable dt_podaci_2 = dt_podaci.Copy();

            cmb_iz.DataSource = dt_podaci_1;
            cmb_iz.ValueMember = "id";
            cmb_iz.DisplayMember = "naziv";
            cmb_iz.SelectedIndex = -1;

            cmb_u.DataSource = dt_podaci_2;
            cmb_u.ValueMember = "id";
            cmb_u.DisplayMember = "naziv";
            cmb_u.SelectedIndex = -1;
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

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO Novcanik(naziv, stanje, FK_osoba_email) VALUES (N'");
            naredba.Append(txt_naziv.Text + "', ");
            naredba.Append(txt_stanje.Text + ", '");
            naredba.Append(Program.email + "')");
            
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
            broj_sloga = dt_podaci.Rows.Count - 1;
            Txt_Ucitaj();
        }        

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Novcanik SET ");
            naredba.Append("naziv = N'" + txt_naziv.Text + "', ");
            naredba.Append("stanje = " + txt_stanje.Text + " ");            
            naredba.Append("WHERE id = " + id);
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
            string naredba = "DELETE FROM Novcanik WHERE id = " + id;
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

        private void btn_prebaci_Click(object sender, EventArgs e)
        {
            if (cmb_iz.SelectedIndex != -1 && cmb_u.SelectedIndex != -1)
            {
                if ((int) cmb_iz.SelectedValue != (int) cmb_u.SelectedValue)
                {
                    //MessageBox.Show("Iz: " + cmb_iz.SelectedValue + ", U: " + cmb_u.SelectedValue);

                    if (txt_suma.Text != "")
                    {
                        StringBuilder naredba = new StringBuilder("UPDATE Novcanik SET ");
                        naredba.Append("stanje = stanje - " + txt_suma.Text);
                        naredba.Append(" WHERE id = " + cmb_iz.SelectedValue);

                        SqlCommand komanda1 = new SqlCommand(naredba.ToString(), veza);

                        naredba = new StringBuilder("UPDATE Novcanik SET ");
                        naredba.Append("stanje = stanje + " + txt_suma.Text);
                        naredba.Append(" WHERE id = " + cmb_u.SelectedValue);

                        SqlCommand komanda2 = new SqlCommand(naredba.ToString(), veza);

                        veza.Open();
                        komanda1.ExecuteNonQuery();
                        komanda2.ExecuteNonQuery();
                        veza.Close();

                        Ucitaj_Podatke();
                        Txt_Ucitaj();
                    }
                    else
                    {
                        stoperica.Start();
                        lbl_poruka.Text = "Молимо Вас да унесете суму коју желите да пребаците!";
                    }
                }
                else
                {
                    stoperica.Start();
                    lbl_poruka.Text = "Новчаници морају бити различити!";
                }
            }
            else
            {
                stoperica.Start();
                lbl_poruka.Text = "Молимо Вас да изаберете новчанике!";
            }            
        }

        private void stoperica_Tick(object sender, EventArgs e)
        {
            lbl_poruka.Text = "";
            stoperica.Stop();
        }
    }
}
