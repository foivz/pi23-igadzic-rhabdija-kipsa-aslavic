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
    public partial class frmNoviDogadaj : Form
    {
        public frmNoviDogadaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string opis = txtOpis.Text;
            DateTime datum = DateTime.Now;
            DateTime vrijemePocetka = dtpVrijemePocetka.Value;
            double cijena = double.Parse(nudCijena.Text);
            int idAmn = UlogiraniKorisnik.ulogirani.ID_Korisnika;

            RepozitorijDogadaja repozitorij = new RepozitorijDogadaja();
            repozitorij.DodajDogadaj(naziv, opis, datum, vrijemePocetka, cijena, idAmn);

            MessageBox.Show("Dogadaj je uspjesno dodan!");
            Close();
        }
    }
}
