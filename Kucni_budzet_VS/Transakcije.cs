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
        SqlDataAdapter adapter;
        DataTable tabela;

        public Transakcije()
        {
            InitializeComponent();
        }

        private void Transakcije_Load(object sender, EventArgs e)
        {
            txt_popuni();
            grid_popuni();
        }

        private void txt_popuni()
        {
            txt_email.Text = Program.email;

            adapter = new SqlDataAdapter("SELECT ime + ' ' + prezime AS 'Име и презиме особе' FROM Osoba WHERE email = '" + Program.email + "'", veza);

            tabela = new DataTable();
            adapter.Fill(tabela);

            txt_ime_prezime.Text = tabela.Rows[0]["Име и презиме особе"].ToString();            
        }

        private void grid_popuni()
        {
            adapter = new SqlDataAdapter("SELECT Promet.datum AS 'Датум и време', Novcanik.naziv AS 'Новчаник', Trosak.naziv AS 'Трошак', Organizaciona_jedinica.naziv AS 'Организациона јединица', Firma.naziv AS 'Фирма', Promet.ulaz AS 'Улаз', Promet.izlaz AS 'Излаз', Promet.kolicina AS 'Количина' FROM Promet JOIN Osoba ON Promet.FK_osoba_email = Osoba.email JOIN Novcanik ON Promet.FK_novcanik_id = Novcanik.id JOIN Trosak ON Promet.FK_trosak_id = Trosak.id JOIN Organizaciona_jedinica ON Promet.FK_organizaciona_jedinica_id = Organizaciona_jedinica.id JOIN Firma ON Promet.FK_firma_id = Firma.id WHERE Osoba.email = '" + Program.email + "' ORDER BY datum; ", veza);
            
            tabela = new DataTable();
            adapter.Fill(tabela);

            grid_promet.DataSource = tabela;
        }
    }
}
