using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CoffeeApp
{
    public partial class frmRadnoVrijemeIzmjena : Form
    {
        public frmRadnoVrijemeIzmjena(string odabraniDan)
        {
            InitializeComponent();


            lblOdabraniDan.Text = odabraniDan;
            lblOdabraniDan.Width = 200;
            lblOdabraniDan.Height = 50;
            lblOdabraniDan.ForeColor = Color.Blue;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            DateTime vrijemeOd = dtpVrijemeOd.Value;
            DateTime vrijemeDo = dtpVrijemeDo.Value;
            int korisnikId = UlogiraniKorisnik.ulogirani.ID_Korisnika;

            using (var context = new PI2313_DBEntities13())
            {
                if(vrijemeOd <= vrijemeDo)
                {
                    string odabraniDan = lblOdabraniDan.Text;
                    var zapis = context.Radno_Vrijeme.FirstOrDefault(r => r.Dan_Tjedna == odabraniDan);

                    zapis.Vrijeme_Od = vrijemeOd.TimeOfDay;
                    zapis.Vrijeme_Do = vrijemeDo.TimeOfDay;

                    zapis.ID_Korisnika = korisnikId;

                    context.SaveChanges();

                    MessageBox.Show("Promjena uspješno spremljena!");
                    Close();
                } else
                {
                    MessageBox.Show("Pogrešno postavljeno radno vrijeme!");
                }
            }

        }
    }
}
