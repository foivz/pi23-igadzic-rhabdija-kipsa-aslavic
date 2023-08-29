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
    public partial class frmNovaObavijest : Form
    {
        public frmNovaObavijest()
        {
            InitializeComponent();
        }

        private void frmNovaObavijest_Load(object sender, EventArgs e)
        {

        }
        RepozitorijObavijesti novaObavijest = new RepozitorijObavijesti();
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            string opis = txtOpis.Text;
            DateTime datum = DateTime.Now;
            int korisnik = UlogiraniKorisnik.ulogirani.ID_Korisnika;

            novaObavijest.DodajObavijest(naslov, opis, datum, korisnik);
            Close();
        }

    }
}
