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

        RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();

        private void btnKatalogPica_Click(object sender, EventArgs e)
        {
            frmPregledZaliha froma = new frmPregledZaliha();
            froma.ShowDialog();
        }

        public void DohvatiZaposlenika()
        {
            using (var context = new PI2313_DBEntities8())
            {
                var query = from p in context.Korisniks
                            where p.Uloga == "Konobar"
                            select p;
                dgvZaposlenici.DataSource = query.ToList();
                dgvZaposlenici.Columns["ID_Korisnika"].Visible = false;
                dgvZaposlenici.Columns["Password"].Visible = false;
                dgvZaposlenici.Columns["Username"].Visible = false;
                dgvZaposlenici.Columns["Email"].Visible = false;
            }
        }

        private void frmGlavniKonobarPocetna_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenika();
        }
    }
}
