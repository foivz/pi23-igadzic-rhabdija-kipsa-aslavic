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
    public partial class frmGlavniKonobarPocetna : Form
    {
        public frmGlavniKonobarPocetna()
        {
            InitializeComponent();
        }

        private void btnKatalogPica_Click(object sender, EventArgs e)
        {
            frmPregledZaliha froma = new frmPregledZaliha();
            froma.ShowDialog();
        }

        public void DohvatiZaposlenika()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Korisniks
                            where p.Uloga == "Konobar"
                            select p;
                dgvZaposlenici.DataSource = query.ToList();
                dgvZaposlenici.Columns["ID_Korisnika"].Visible = false;
                dgvZaposlenici.Columns["Password"].Visible = false;
                dgvZaposlenici.Columns["Username"].Visible = false;
                dgvZaposlenici.Columns["Email"].Visible = false;
                dgvZaposlenici.Columns["Stols"].Visible = false;
                dgvZaposlenici.Columns["Orders"].Visible = false;
            }
        }

        private void frmGlavniKonobarPocetna_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenika();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPromjeniRaspored_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            if (selektirani == null)
            {
                MessageBox.Show("Morate odabrati zaposlenika");
            }
            frmPromjenaRasporeda form = new frmPromjenaRasporeda(selektirani);
            form.ShowDialog();
            DohvatiZaposlenika();
        }

        private void btnPlacanjeNarudzbe_Click(object sender, EventArgs e)
        {
            frmPlacanjeNarudzbe forma = new frmPlacanjeNarudzbe();
            forma.ShowDialog();
        }
    }
}
