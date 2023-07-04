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
    public partial class frmUpravljanjeKorisnicima : Form
    {
        public frmUpravljanjeKorisnicima()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            DohvatiKorisnike();
        }

        public void DohvatiKorisnike()
        {
            
            using(var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Korisniks
                            select p;
                dgvUpravljanjeKorsincima.DataSource = query.ToList();
                dgvUpravljanjeKorsincima.Columns["Stols"].Visible = false;
                dgvUpravljanjeKorsincima.Columns["Orders"].Visible = false;
            }
        }

        public void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
                if (selektirani.Uloga != "Admin")
                {
                    context.Korisniks.Attach(selektirani);
                    context.Korisniks.Remove(selektirani);
                    context.SaveChanges();
                }
                if (selektirani.Uloga == "Admin")
                {
                    MessageBox.Show("Ne moze se obrisati admin!");
                }
            }
            DohvatiKorisnike();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
            frmUrediKorisnika forma = new frmUrediKorisnika(selektirani);
            forma.ShowDialog();
            DohvatiKorisnike();
        }
    }
}
