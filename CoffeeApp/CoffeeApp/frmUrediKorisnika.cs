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
                int uloga = cmbUloga.SelectedIndex + 1;

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
            if (selektirani.Uloga == 1)
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

            popuniCmbUloge();

            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;
            txtbEmail.Text = selektirani.Email;
            txtbUsername.Text = selektirani.Username;
            txtbLozinka.Text = selektirani.Password;
            cmbUloga.SelectedIndex = selektirani.Uloga - 1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void popuniCmbUloge()
        {
            List<Uloga> uloge;

            using(var context = new PI2313_DBEntities13())
            {
                uloge = context.Ulogas.ToList();
            }

            cmbUloga.DataSource = uloge;

            for (int i = 1; i < cmbUloga.Items.Count; i++)
            {
                if ((cmbUloga.Items[i] as Uloga).ID_uloga == selektirani.Uloga)
                {
                    cmbUloga.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
