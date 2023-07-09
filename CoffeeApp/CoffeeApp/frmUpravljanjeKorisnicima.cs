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
                dgvUpravljanjeKorsincima.Columns["Uloga1"].Visible = false;
                dgvUpravljanjeKorsincima.Columns["Smjena1"].Visible = false;
            }
        }

        public void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
                if (selektirani.Uloga != 1)
                {
                    context.Korisniks.Attach(selektirani);
                    selektirani.Status_Racuna = "Neaktivan";
                    context.SaveChanges();
                }
                if (selektirani.Uloga == 1)
                {
                    MessageBox.Show("Ne moze se deaktivirati admin!");
                }
            }
            DohvatiKorisnike();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvUpravljanjeKorsincima.CurrentRow == null)
            {
                MessageBox.Show("Morate odabrati zaposlenika");
            }
            else
            {
                var trazeniID_row = dgvUpravljanjeKorsincima.CurrentRow;
                var trID = trazeniID_row.Cells["ID_Korisnika"];
                int ID = int.Parse(trID.Value.ToString());

                using (var context = new PI2313_DBEntities13())
                {

                    var query = from p in context.Korisniks
                                where p.ID_Korisnika == ID
                                select p;
                    var res = query.ToList();
                    Korisnik selektirani = res[0] as Korisnik;

                    frmUrediKorisnika forma = new frmUrediKorisnika(selektirani, context);
                    forma.ShowDialog();
                }
            }
            DohvatiKorisnike();
        }
    }
}
