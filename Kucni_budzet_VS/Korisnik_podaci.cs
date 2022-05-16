using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kucni_budzet_VS
{
    public partial class Korisnik_podaci : Form
    {
        public Korisnik_podaci()
        {
            InitializeComponent();
        }

        private void Korisnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
