using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class frmRadnoVrijeme : Form
    {
        public frmRadnoVrijeme()
        {
            InitializeComponent();
            dgvRadnoVrijeme.SelectionChanged += dgvRadnoVrijeme_SelectionChanged;
        }

        private void frmRadnoVrijeme_Load(object sender, EventArgs e)
        {
            DohvatiRadnoVrijeme();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DohvatiRadnoVrijeme()
        {
            using(var context = new PI2313_DBEntities13())
            {
                var query = from r in context.Radno_Vrijeme
                            join k in context.Korisniks on r.ID_Korisnika equals k.ID_Korisnika
                            select new
                            {
                                Dan = r.Dan_Tjedna,
                                Od = r.Vrijeme_Od,
                                Do = r.Vrijeme_Do,
                                PosljenjiMijenjao = k.Ime + k.Prezime

                            };
                dgvRadnoVrijeme.DataSource = query.ToList();
            }
        }

        private void dgvRadnoVrijeme_SelectionChanged(object sender, EventArgs e)
        {
            btnIzmjeni.Enabled = dgvRadnoVrijeme.SelectedRows.Count > 0;
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (dgvRadnoVrijeme.CurrentRow == null)
            {
                MessageBox.Show("Trebate izbarati dan");

            } else
            {
                string odabraniDan = dgvRadnoVrijeme.SelectedRows[0].Cells["Dan"].Value.ToString();
                frmRadnoVrijemeIzmjena form = new frmRadnoVrijemeIzmjena(odabraniDan);
                form.ShowDialog();
                DohvatiRadnoVrijeme();
            }
        }
    }
}
