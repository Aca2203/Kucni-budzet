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
    public partial class Administrator_transakcije : Form
    {
        SqlConnection veza = Kontrole.Povezi();
        DataTable tabela;
        SqlDataAdapter adapter;

        public Administrator_transakcije()
        {
            InitializeComponent();
        }

        private void Administrator_transakcije_Load(object sender, EventArgs e)
        {
            grid_popuni();            
        }

        private void grid_popuni()
        {
            string naredba = "SELECT Promet.datum AS 'Датум и време', Osoba.email AS 'Имејл адреса', Osoba.ime + ' ' + Osoba.prezime AS 'Име и презиме особе', Novcanik.naziv AS 'Новчаник', Trosak.naziv AS 'Трошак', Promet.kolicina AS 'Количина', Organizaciona_jedinica.naziv AS 'Организациона јединица', Firma.naziv AS 'Фирма', Promet.ulaz AS 'Улаз', Promet.izlaz AS 'Излаз', Promet.opis AS 'Опис' FROM Promet JOIN Osoba ON Promet.FK_osoba_email = Osoba.email JOIN Novcanik ON Promet.FK_novcanik_id = Novcanik.id JOIN Trosak ON Promet.FK_trosak_id = Trosak.id JOIN Organizaciona_jedinica ON Promet.FK_organizaciona_jedinica_id = Organizaciona_jedinica.id JOIN Firma ON Promet.FK_firma_id = Firma.id ORDER BY datum";

            adapter = new SqlDataAdapter(naredba, veza);
            tabela = new DataTable();
            adapter.Fill(tabela);

            grid_promet.DataSource = tabela;
        }             
    }
}
