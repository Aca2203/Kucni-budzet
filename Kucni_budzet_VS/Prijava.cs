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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string lozinka = txt_lozinka.Text;

            if (email == "" && lozinka == "")
            {
                lbl_poruka.Text = "Молимо вас да унесете ваше податке!";
            }
            else
            {
                //MessageBox.Show("Ради!");
                int rezultat = Kontrole.Provera_Korisnika(email, lozinka);

                if (rezultat == -2)
                {
                    lbl_poruka.Text = "Унели сте непостојећу имејл адресу!";
                }
                if (rezultat == -1)
                {
                    lbl_poruka.Text = "Погрешна лозинка!";
                }

                if (rezultat == 1)
                {
                    MessageBox.Show("Успешно сте се улоговали!");

                    Program.email = txt_email.Text;

                    Administrator_podaci frm_administrator = new Administrator_podaci();
                    Hide();
                    frm_administrator.Show();
                }

                if (rezultat == 2)
                {
                    MessageBox.Show("Успешно сте се улоговали!");

                    Program.email = txt_email.Text;

                    Korisnik_podaci frm_korisnik = new Korisnik_podaci();
                    Hide();
                    frm_korisnik.Show();
                }
            }            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
