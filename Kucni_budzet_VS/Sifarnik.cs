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
    public partial class Sifarnik : Form
    {
        SqlConnection veza = Kontrole.Povezi();
        DataTable tabela;
        SqlDataAdapter adapter;
        string naredba;
        string ime_tabele;

        public Sifarnik(string tabela)
        {
            ime_tabele = tabela;            
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            switch (ime_tabele)
            {                
                case "Trosak":
                    this.Text = "Трошкови";
                    break;

                case "Organizaciona_jedinica":
                    this.Text = "Организационе јединице";
                    break;

                case "Firma":
                    this.Text = "Фирме";
                    break;

                default:
                    break;
            }

            grid_ucitaj();
        }

        private void grid_ucitaj()
        {            
            naredba = "SELECT id, naziv AS 'Назив' FROM " + ime_tabele;                            

            adapter = new SqlDataAdapter(naredba, veza);
            tabela = new DataTable();

            adapter.Fill(tabela);

            grid_podaci.DataSource = tabela;
            grid_podaci.Columns["id"].ReadOnly = true;
            grid_podaci.Columns["id"].Width = 55;            
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();

            if (menjano != null)
            {
                try
                {
                    adapter.Update(menjano);
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }

            Close();
        }
    }
}
