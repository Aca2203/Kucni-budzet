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
            podaci_ucitaj();            
        }

        private void podaci_ucitaj()
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
            string lozinka = txt_lozinka.Text;            

            StringBuilder naredba = new StringBuilder("UPDATE Osoba SET ");
            naredba.Append("ime = N'" + ime + "', ");
            naredba.Append("prezime = N'" + prezime + "', ");
            naredba.Append("lozinka = '" + lozinka + "' ");            
            naredba.Append("WHERE email = '" + Program.email + "'");

            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void i_transakcije_Click(object sender, EventArgs e)
        {
            Transakcije forma = new Transakcije();
            forma.Show();
        }

        private void i_novcanici_Click(object sender, EventArgs e)
        {
            Novcanik frm_novcanik = new Novcanik();
            frm_novcanik.Show();
        }

        private void i_troskovi_Click(object sender, EventArgs e)
        {
            Sifarnik frm_novcanici = new Sifarnik("Trosak");
            frm_novcanici.Show();
        }

        private void i_org_Click(object sender, EventArgs e)
        {
            Sifarnik frm_novcanici = new Sifarnik("Organizaciona_jedinica");
            frm_novcanici.Show();
        }

        private void i_firme_Click(object sender, EventArgs e)
        {
            Sifarnik frm_novcanici = new Sifarnik("Firma");
            frm_novcanici.Show();
        }

        private void i_osobe_Click(object sender, EventArgs e)
        {
            Osobe frm_osobe = new Osobe();
            frm_osobe.Show();
        }
    }
}
