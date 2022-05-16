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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        

        private void Administrator_Load(object sender, EventArgs e)
        {
            txt_email.Text = Program.email;
            txt_lozinka.Text = Program.lozinka;

            SqlConnection veza = Kontrole.Povezi();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ime, prezime, jmbg FROM Osoba WHERE email = '" + Program.email + "'", veza);
            
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            txt_ime.Text = tabela.Rows[0]["ime"].ToString();
            txt_prezime.Text = tabela.Rows[0]["prezime"].ToString();
            txt_jmbg.Text = tabela.Rows[0]["jmbg"].ToString();
        }

        private void i_transakcije_Click(object sender, EventArgs e)
        {

        }
    }
}
