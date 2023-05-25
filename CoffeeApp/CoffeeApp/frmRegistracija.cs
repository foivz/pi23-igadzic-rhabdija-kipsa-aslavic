using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        public Autentifikator autentifikator = new Autentifikator();

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistriajSe_Click(object sender, EventArgs e)
        {
            string ime = txtbIme.Text;
            string prezime = txtbPrezime.Text;
            string email = txtbEmail.Text;
            string username = txtbUsername.Text;
            string password = txtbLozinka.Text;
            string passwordrep = txtbPonovnaLozinka.Text;
            autentifikator.Registracija(ime, prezime, email, username, password, passwordrep);
            Close();
        }
    }
}
