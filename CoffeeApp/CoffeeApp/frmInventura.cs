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
    public partial class frmInventura : Form
    {
        public frmInventura()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInventura_Load(object sender, EventArgs e)
        {
            DohvatiKatalogManjkova();
        }

        private void DohvatiKatalogManjkova()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Artiklis
                            where p.Dostupno_Komada < 4
                            select p;
                dgvInventura.DataSource = query.ToList();

                dgvInventura.Columns["ID_Pica"].Visible = false;
                dgvInventura.Columns["Order_details"].Visible = false;
            }
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                var narucenaKol = (int)numUDKolicinaZaNaruciti.Value;
                if (dgvInventura.SelectedRows.Count > 0)
                {
                    Artikli selectedArtikls = dgvInventura.CurrentRow.DataBoundItem as Artikli;
                    context.Artiklis.Attach(selectedArtikls);
                    selectedArtikls.Dostupno_Komada += narucenaKol;
                    context.SaveChanges();
                }
            }
            DohvatiKatalogManjkova();
        }
    }
}
