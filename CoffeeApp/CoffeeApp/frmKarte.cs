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
    public partial class frmKarte : Form
    {
        public frmKarte()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKarte_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        public void Osvjezi()
        {
            DohvatiDogadaje();
            DohvatiKarte();
        }

        public void DohvatiDogadaje()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from d in context.Dogadajs
                            select d;

                dgvDogadaji.DataSource = query.ToList();

                dgvDogadaji.Columns["ID_Dogadaja"].Visible = false;
                dgvDogadaji.Columns["ID_Administratora"].Visible = false;
                dgvDogadaji.Columns["Kartas"].Visible = false;
                dgvDogadaji.Columns["Korisnik"].Visible = false;
            }
        }

        public void DohvatiKarte()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from karta in context.Kartas
                            join dogadaj in context.Dogadajs on karta.ID_Dogadaja equals dogadaj.ID_Dogadaja
                            join korisnik in context.Korisniks on karta.ID_Korisnika equals korisnik.ID_Korisnika
                            group karta by new { dogadaj.Naziv, dogadaj.Opis, dogadaj.Cijena } into grp
                            select new
                            {
                                Naziv = grp.Key.Naziv,
                                Opis = grp.Key.Opis,
                                Cijena = grp.Key.Cijena,
                                Broj_karata = grp.Count(),
                                Ukupno = grp.Key.Cijena * grp.Count()
                            };

                dgvKarte.DataSource = query.ToList();
                            
            }
        }

        
        public void btnKupiKartu_Click(object sender, EventArgs e)
        {
            if(dgvDogadaji.SelectedRows != null)
            {
                int dogadajId = (int)dgvDogadaji.SelectedRows[0].Cells["ID_Dogadaja"].Value;
                int korisnikId = UlogiraniKorisnik.ulogirani.ID_Korisnika;

                RepozitorijKarata karteRepozitorij = new RepozitorijKarata();
                karteRepozitorij.DodajKartu(dogadajId, korisnikId);

                MessageBox.Show("Karta je kupljena.");
                Osvjezi();
            } else
            {
                MessageBox.Show("Događaj nije odabran za kupovinu karte");
            }
        }

        private void btnPoništi_Click(object sender, EventArgs e)
        {
            if(dgvKarte.SelectedRows != null)
            {
                string naziv = dgvKarte.SelectedRows[0].Cells["Naziv"].Value.ToString();

                using(var context = new PI2313_DBEntities13())
                {
                    var dogadaj = context.Dogadajs.FirstOrDefault(d => d.Naziv == naziv);

                    if(dogadaj != null)
                    {
                        var karta = context.Kartas.FirstOrDefault(k => k.ID_Dogadaja == dogadaj.ID_Dogadaja);

                        if(karta != null)
                        {
                            context.Kartas.Remove(karta);
                            context.SaveChanges();

                            MessageBox.Show("Karta uspješno izbrisana!");
                            Osvjezi();
                        } else
                        {
                            MessageBox.Show("Karta za odabrani dogadaj nije pronadena");
                        }
                    } else
                    {
                        MessageBox.Show("Dogadaj za odabranu kartu nije pronaden!");
                    }

                }
            } else
            {
                MessageBox.Show("Odaberite kartu koju zelite ponistiti!");
            }
        }
    }
}
