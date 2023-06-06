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
    public partial class frmKorisnikPocetna : Form
    {
        public frmKorisnikPocetna()
        {
            InitializeComponent();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKorisnikPocetna_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
            DohvatiDetaljeNarudzbe();
        }
        

        public void DohvatiArtikle()
        {
            using(var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Artiklis
                            select p;
                dgvArtikli.DataSource = query.ToList();

                dgvArtikli.Columns["ID_Pica"].Visible = false;
                dgvArtikli.Columns["Order_details"].Visible = false;
            }
        }

        public void DohvatiDetaljeNarudzbe()
        {
            using(var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Order_details
                            select p;
                dgvOdabranaPica.DataSource = query.ToList();

                dgvOdabranaPica.Columns["ID_OrderDetails"].Visible = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRed = dgvArtikli.SelectedRows[0];

                Artikli selctedArtikls = odabraniRed.DataBoundItem as Artikli;

                if (selctedArtikls != null)
                {
                    using (var context = new PI2313_DBEntities13())
                    {
                        Order_detail order_Detail = new Order_detail();

                        order_Detail.ID_OrderDetails = GeneriranjeKljuca(context);
                        order_Detail.Naziv_Pica = selctedArtikls.Naziv_Pica;
                        order_Detail.Kolicina = selctedArtikls.Kolicina;
                        order_Detail.Cijena = selctedArtikls.Cijena;

                        context.Order_details.Add(order_Detail);
                        context.SaveChanges();
                    }
                }
                DohvatiDetaljeNarudzbe();
            }
        }

        public int GeneriranjeKljuca(PI2313_DBEntities13 context)
        {
            List<int> postojeciKLjucevi = context.Order_details.Select(o => o.ID_OrderDetails).ToList();
            int maxID = postojeciKLjucevi.Count > 0 ? postojeciKLjucevi.Max() : 0;

            int kljuc = maxID + 1;

            return kljuc;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Order_detail odabranaNarudzba = dgvOdabranaPica.CurrentRow.DataBoundItem as Order_detail;
                context.Order_details.Attach(odabranaNarudzba);
                context.Order_details.Remove(odabranaNarudzba);
                context.SaveChanges();
                DohvatiDetaljeNarudzbe();
            }
        }

        private void btnRezervirajStol_Click(object sender, EventArgs e)
        {
            frmRezervacijaStola forma = new frmRezervacijaStola();
            forma.ShowDialog();
        }
    }
}
