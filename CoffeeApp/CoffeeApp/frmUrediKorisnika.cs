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
    public partial class frmUrediKorisnika : Form
    {
        public frmUrediKorisnika(Korisnik selektiraniKorisnik)
        {
            InitializeComponent();
            this.selektirani = selektiraniKorisnik;
        }
        public Korisnik selektirani;

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var contex = new PI2313_DBEntities13())
            {
                string ime = txtbIme.Text.ToString();
                string prezime = txtbPrezime.Text.ToString();
                string email = txtbEmail.Text.ToString();
                string username = txtbUsername.Text.ToString();
                string lozinka = txtbLozinka.Text.ToString();
                string uloga = cmbUloga.SelectedItem as string;

                contex.Korisniks.Attach(selektirani);
                selektirani.Ime = ime;
                selektirani.Prezime = prezime;
                selektirani.Email = email;
                selektirani.Username = username;
                selektirani.Password = lozinka;
                selektirani.Uloga = uloga;
                contex.SaveChanges();
            }
            Close();
        }

        private void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            if (selektirani.Uloga == "Admin")
            {
                txtbIme.ReadOnly = true;
                txtbPrezime.ReadOnly = true;
                txtbEmail.ReadOnly = true;
                txtbUsername.ReadOnly = true;
                txtbLozinka.ReadOnly = true;
                cmbUloga.SelectedText = "Admin";
                cmbUloga.Enabled = false;
                btnSpremi.Enabled = false;

            }
            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;
            txtbEmail.Text = selektirani.Email;
            txtbUsername.Text = selektirani.Username;
            txtbLozinka.Text = selektirani.Password;
            cmbUloga.SelectedItem = selektirani.Uloga;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
