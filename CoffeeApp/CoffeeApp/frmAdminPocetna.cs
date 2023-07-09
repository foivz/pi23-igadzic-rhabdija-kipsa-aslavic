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
    public partial class frmAdminPocetna : Form
    {
        public frmAdminPocetna()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            frmUpravljanjeKorisnicima forma = new frmUpravljanjeKorisnicima();
            forma.ShowDialog();
        }

        private void btnPregeldZaliha_Click(object sender, EventArgs e)
        {
            frmPregledZaliha form = new frmPregledZaliha();
            form.ShowDialog();
        }

        private void btnPlacanjeNarudzbe_Click(object sender, EventArgs e)
        {
            frmPlacanjeNarudzbe forma = new frmPlacanjeNarudzbe();
            forma.ShowDialog();
        }

        private void btnPromjeniRaspored_Click(object sender, EventArgs e)
        {

            if (dgvZaposlenici.CurrentRow == null)
            {
                MessageBox.Show("Morate odabrati zaposlenika");
            }
            else
            {
                var trazeniID_row = dgvZaposlenici.CurrentRow;
                var trID = trazeniID_row.Cells["ID_Korisnika"];
                int ID = int.Parse(trID.Value.ToString());
                
                using (var context = new PI2313_DBEntities13())
                {

                    var query = from p in context.Korisniks
                                where p.ID_Korisnika == ID
                                select p;
                    var res = query.ToList();
                    Korisnik selektirani = res[0] as Korisnik;

                    frmPromjenaRasporeda form = new frmPromjenaRasporeda(selektirani);
                    form.ShowDialog();
                }
            }
            DohvatiZaposlenika();
        }

        public void DohvatiZaposlenika()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Korisniks
                            join fk1 in context.Ulogas
                                on p.Uloga equals fk1.ID_uloga
                            join fk2 in context.Smjenas
                                on p.Smjena equals fk2.ID_smjena
                            where p.Uloga == 2 || p.Uloga == 3
                            select new
                            {
                                ID_Korisnika = p.ID_Korisnika,
                                Ime = p.Ime,
                                Prezime = p.Prezime,
                                Uloga = fk1.Naziv_uloge,
                                Smjena = fk2.Naziv_smjene,
                                Status_Racuna = p.Status_Racuna
                            };

                dgvZaposlenici.DataSource = query.ToList();
                dgvZaposlenici.Columns["ID_Korisnika"].Visible = false;
            }
        }

        private void frmAdminPocetna_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenika();
        }
    }
}
