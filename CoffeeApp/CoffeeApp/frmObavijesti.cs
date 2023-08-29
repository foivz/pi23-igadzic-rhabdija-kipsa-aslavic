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
    public partial class frmObavijesti : Form
    {
        public frmObavijesti()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            
            DohvatiObavijesti();
        }

        private void DohvatiObavijesti()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from o in context.Obavijestis
                            join k in context.Korisniks on o.ID_Korisnika equals k.ID_Korisnika
                            select new
                            {
                                ObavijestID = o.ID_Obavijesti,
                                Naslov = o.Naslov,
                                Opis = o.Opis,
                                Datum = o.Datum,
                             // KorisnikID = o.ID_Korisnika,
                                Objavio = k.Ime
                            };

                dgvObavijesti.DataSource = query.ToList();
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaObavijest form = new frmNovaObavijest();
            form.ShowDialog();
            DohvatiObavijesti(); 
        }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13()) {
                if (dgvObavijesti.CurrentRow != null)
                {
                    int obavijestID = (int)dgvObavijesti.CurrentRow.Cells["ObavijestID"].Value;
                    var oznacenaObavijest = context.Obavijestis.Find(obavijestID);
                    context.Obavijestis.Remove(oznacenaObavijest);
                    context.SaveChanges();
                } else
                {
                    MessageBox.Show("Oznacite obavijest kako biste je izbrisali");
                }
                DohvatiObavijesti();
            }
        }
    }
}
