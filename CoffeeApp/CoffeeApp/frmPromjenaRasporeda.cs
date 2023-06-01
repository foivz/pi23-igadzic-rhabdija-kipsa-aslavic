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
    public partial class frmPromjenaRasporeda : Form
    {
        public frmPromjenaRasporeda(Korisnik selektiraniKorisnik)
        {
            InitializeComponent();
            this.selektirani = selektiraniKorisnik;
        }

        public Korisnik selektirani;

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var contex = new PI2313_DBEntities13())
            {
                string ime = txtbIme.Text.ToString();
                string prezime = txtbPrezime.Text.ToString();
                string smjena = cmbSmjena.SelectedItem as string;

                contex.Korisniks.Attach(selektirani);
                selektirani.Ime = ime;
                selektirani.Prezime = prezime;
                selektirani.Smjena = smjena;
                contex.SaveChanges();
            }
            Close();
        }

        private void frmPromjenaRasporeda_Load(object sender, EventArgs e)
        {
            txtbIme.ReadOnly = true;
            txtbPrezime.ReadOnly = true;
            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;
            cmbSmjena.Text = selektirani.Smjena;
        }
    }
}
