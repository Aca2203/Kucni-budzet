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
    public partial class Transakcije : Form
    {
        SqlConnection veza = Kontrole.Povezi();

        public Transakcije()
        {
            InitializeComponent();
        }

        private void Transakcije_Load(object sender, EventArgs e)
        {
            txt_popuni();
        }

        private void txt_popuni()
        {
            txt_email.Text = Program.email;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ime + ' ' + prezime AS 'Име и презиме особе' FROM Osoba WHERE email = '" + Program.email + "'", veza);

            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            txt_ime_prezime.Text = tabela.Rows[0]["Име и презиме особе"].ToString();            
        }
    }
}
