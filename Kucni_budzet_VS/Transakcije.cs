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
        string naredba;
        SqlCommand komanda;

        public Transakcije()
        {
            InitializeComponent();
        }

        private void Transakcije_Load(object sender, EventArgs e)
        {
            txt_popuni();
            txt_stanje_popuni();
            grid_popuni();
            cmb_popuni();
        }

        private void txt_popuni()
        {
            txt_email.Text = Program.email;

            adapter = new SqlDataAdapter("SELECT ime + ' ' + prezime AS 'Име и презиме особе' FROM Osoba WHERE email = '" + Program.email + "'", veza);

            tabela = new DataTable();
            adapter.Fill(tabela);

            txt_ime_prezime.Text = tabela.Rows[0]["Име и презиме особе"].ToString();            
        }

        private void txt_stanje_popuni()
        {
            komanda = new SqlCommand("SELECT SUM(stanje) FROM Novcanik JOIN Osoba ON Novcanik.FK_osoba_email = Osoba.email WHERE Osoba.email = '" + Program.email + "'", veza);

            veza.Open();
            string rezultat = komanda.ExecuteScalar().ToString();
            veza.Close();

            txt_stanje.Text = rezultat;
        }

        private void grid_popuni()
        {
            adapter = new SqlDataAdapter("SELECT Promet.datum AS 'Датум и време', Novcanik.naziv AS 'Новчаник', Trosak.naziv AS 'Трошак', Organizaciona_jedinica.naziv AS 'Организациона јединица', Firma.naziv AS 'Фирма', Promet.ulaz AS 'Улаз', Promet.izlaz AS 'Излаз', Promet.kolicina AS 'Количина' FROM Promet JOIN Osoba ON Promet.FK_osoba_email = Osoba.email JOIN Novcanik ON Promet.FK_novcanik_id = Novcanik.id JOIN Trosak ON Promet.FK_trosak_id = Trosak.id JOIN Organizaciona_jedinica ON Promet.FK_organizaciona_jedinica_id = Organizaciona_jedinica.id JOIN Firma ON Promet.FK_firma_id = Firma.id WHERE Osoba.email = '" + Program.email + "' ORDER BY datum; ", veza);
            
            tabela = new DataTable();
            adapter.Fill(tabela);

            grid_promet.DataSource = tabela;
        }

        private void cmb_popuni()
        {
            naredba = "SELECT 0 AS id, N'Сви новчаници' AS naziv UNION SELECT id, naziv FROM Novcanik WHERE FK_osoba_email = '" + Program.email + "'";
            
            adapter = new SqlDataAdapter(naredba, veza);
            tabela = new DataTable();          
            adapter.Fill(tabela);

            cmb_novcanik.DataSource = tabela;
            cmb_novcanik.ValueMember = "id";
            cmb_novcanik.DisplayMember = "naziv";
            cmb_novcanik.SelectedValue = 0;            
        }

        private void cmb_novcanik_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_novcanik.IsHandleCreated && cmb_novcanik.Focused)
            {
                if ((int) cmb_novcanik.SelectedValue == 0)
                {
                    txt_stanje_popuni();
                }
                else
                {
                    txt_stanje_promeni();
                }                
            }
        }

        private void txt_stanje_promeni()
        {
            komanda = new SqlCommand("SELECT stanje FROM Novcanik JOIN Osoba ON Novcanik.FK_osoba_email = Osoba.email WHERE Osoba.email = '" + Program.email + "' AND Novcanik.id = " + cmb_novcanik.SelectedValue, veza);

            veza.Open();
            string rezultat = komanda.ExecuteScalar().ToString();
            veza.Close();

            txt_stanje.Text = rezultat;
        }
    }
}
