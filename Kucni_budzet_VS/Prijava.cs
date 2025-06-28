using System;
using System.Windows.Forms;

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
                stoperica.Start();
                lbl_poruka.Text = "Молимо вас да унесете ваше податке!";
            }
            else
            {
                //MessageBox.Show("Ради!");
                int rezultat = Kontrole.Provera_Korisnika(email, lozinka);

                if (rezultat == -2)
                {
                    stoperica.Start();
                    lbl_poruka.Text = "Унели сте непостојећу имејл адресу!";
                }
                if (rezultat == -1)
                {
                    stoperica.Start();
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

        private void stoperica_Tick(object sender, EventArgs e)
        {
            lbl_poruka.Text = "";
            stoperica.Stop();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            txt_email.Text = "aleksandarstefanovic@KB_A.rs";
            txt_lozinka.Text = "coamafija1312";
            this.BeginInvoke((MethodInvoker) delegate {
                btn_prijava.Focus();
            });
        }
    }
}
