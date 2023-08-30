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
    public partial class frmIzmjeniDogadaj : Form
    {
        private Dogadaj odabraniDogadaj;
        public frmIzmjeniDogadaj(Dogadaj dogadaj)
        {
            InitializeComponent();
            odabraniDogadaj = dogadaj;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIzmjeniDogadaj_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = odabraniDogadaj.Naziv;
            txtOpis.Text = odabraniDogadaj.Opis;
            dtpDatum.Value = odabraniDogadaj.Datum;
            DateTime kombiniraniDateTime = dtpDatum.Value.Date + odabraniDogadaj.Vrijeme_pocetka;
            dtpVrijemePocetka.Format = DateTimePickerFormat.Time;
            dtpVrijemePocetka.ShowUpDown = true;
            dtpVrijemePocetka.Value = kombiniraniDateTime;
            nudCijena.Value = (decimal)odabraniDogadaj.Cijena;
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            using(var context = new PI2313_DBEntities13())
            {
                Dogadaj izmjenaDogadaja = context.Dogadajs.FirstOrDefault(d => d.ID_Dogadaja == odabraniDogadaj.ID_Dogadaja);

                izmjenaDogadaja.Naziv = txtNaziv.Text;
                izmjenaDogadaja.Opis = txtOpis.Text;
                izmjenaDogadaja.Datum = dtpDatum.Value.Date;
                izmjenaDogadaja.Vrijeme_pocetka = dtpVrijemePocetka.Value.TimeOfDay;
                izmjenaDogadaja.Cijena = (double)nudCijena.Value;
                izmjenaDogadaja.ID_Administratora = UlogiraniKorisnik.ulogirani.ID_Korisnika;

                context.SaveChanges();
                MessageBox.Show("Događaj je promijenjen!");
                Close();
            }
        }
    }
}
