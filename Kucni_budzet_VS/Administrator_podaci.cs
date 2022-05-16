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
    public partial class Administrator_podaci : Form
    {
        SqlConnection veza = Kontrole.Povezi();

        public Administrator_podaci()
        {
            InitializeComponent();
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        

        private void Administrator_Load(object sender, EventArgs e)
        {
            txt_ucitaj();
        }

        private void txt_ucitaj()
        {
            txt_email.Text = Program.email;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ime, prezime, jmbg, lozinka FROM Osoba WHERE email = '" + Program.email + "'", veza);

            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            txt_ime.Text = tabela.Rows[0]["ime"].ToString();
            txt_prezime.Text = tabela.Rows[0]["prezime"].ToString();
            txt_jmbg.Text = tabela.Rows[0]["jmbg"].ToString();
            txt_lozinka.Text = tabela.Rows[0]["lozinka"].ToString();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            string ime = txt_ime.Text;
            string prezime = txt_prezime.Text;
            string email = txt_email.Text;
            string lozinka = txt_lozinka.Text;
            string jmbg = txt_jmbg.Text;

            StringBuilder naredba = new StringBuilder("UPDATE Osoba SET ");
            naredba.Append("ime = N'" + ime + "', ");
            naredba.Append("prezime = N'" + prezime + "', ");
            naredba.Append("lozinka = '" + lozinka + "', ");
            naredba.Append("jmbg = '" + jmbg + "' ");
            naredba.Append("WHERE email = '" + email + "'");

            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void i_transakcije_Click(object sender, EventArgs e)
        {
            
        }
    }
}
