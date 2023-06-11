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

        Order aktivnaNarudzba = new Order();
        List<Order_detail> listaArtikalaZaNarudzbu = new List<Order_detail>();



        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void frmKorisnikPocetna_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
            DohvatiDetaljeNarudzbe();
            using (var context = new PI2313_DBEntities13())
            {
                aktivnaNarudzba.ID_Order=GeneriranjeKljucaNarudzba(context);
                aktivnaNarudzba.ID_Korisnika = UlogiraniKorisnik.ulogirani.ID_Korisnika;
                aktivnaNarudzba.kupac = UlogiraniKorisnik.ulogirani.Username;
            }
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

            dgvOdabranaPica.DataSource = null;
            
            if (listaArtikalaZaNarudzbu != null && listaArtikalaZaNarudzbu.Count > 0) 
            {               
                dgvOdabranaPica.DataSource = listaArtikalaZaNarudzbu;
                dgvOdabranaPica.Columns["ID_OrderDetails"].Visible = false;
                dgvOdabranaPica.Columns["ID_Order"].Visible = false;
                dgvOdabranaPica.Columns["ID_Pica"].Visible = false;
                dgvOdabranaPica.Columns["Artikli"].Visible = false;
                dgvOdabranaPica.Columns["Order"].Visible = false;
            }
        }

        public void ProvjeraKolicine(Artikli selectedArtikl)
        {
            using (var context = new PI2313_DBEntities13())
            {
                double kolicinaSelectedArtikla = 0;
                foreach (Order_detail o in listaArtikalaZaNarudzbu)
                {
                    if (o.Naziv_Pica == selectedArtikl.Naziv_Pica)
                    {
                        kolicinaSelectedArtikla += 1;
                    }
                }
                if (selectedArtikl.Dostupno_Komada == kolicinaSelectedArtikla)
                {
                    btnDodaj.Enabled = false;
                }
                else
                {
                    btnDodaj.Enabled = true;
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                Artikli selctedArtikls = dgvArtikli.CurrentRow.DataBoundItem as Artikli;

                if (selctedArtikls != null)
                {
                    using (var context = new PI2313_DBEntities13())
                    {
                        Order_detail order_Detail = new Order_detail();

                        order_Detail.ID_OrderDetails = GeneriranjeKljuca(context);
                        order_Detail.ID_Order = aktivnaNarudzba.ID_Order;
                        order_Detail.ID_Pica = selctedArtikls.ID_Pica;
                        order_Detail.Naziv_Pica = selctedArtikls.Naziv_Pica;
                        order_Detail.Kolicina = selctedArtikls.Kolicina;
                        order_Detail.Cijena = selctedArtikls.Cijena;

                        listaArtikalaZaNarudzbu.Add(order_Detail);
                    }                    
                }
                DohvatiDetaljeNarudzbe();
                ProvjeraKolicine(selctedArtikls);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaArtikalaZaNarudzbu != null && listaArtikalaZaNarudzbu.Count > 0)
            {
                if (dgvOdabranaPica.SelectedRows.Count > 0)
                {
                    Order_detail selectedDetail = dgvOdabranaPica.CurrentRow.DataBoundItem as Order_detail;

                    if (selectedDetail != null)
                    {
                        listaArtikalaZaNarudzbu.Remove(selectedDetail);
                    }
                    DohvatiDetaljeNarudzbe();
                    ProvjeraKolicine(dgvArtikli.CurrentRow.DataBoundItem as Artikli);
                }
            }
        }

        public int GeneriranjeKljuca(PI2313_DBEntities13 context)
        {
            List<int> postojeciKLjucevi = context.Order_details.Select(o => o.ID_OrderDetails).ToList();
            int maxID = postojeciKLjucevi.Count > 0 ? postojeciKLjucevi.Max() : 0;

            int kljuc = maxID + 1;

            return kljuc;
        }

        public int GeneriranjeKljucaNarudzba(PI2313_DBEntities13 context)
        {
            List<int> postojeciKLjucevi = context.Orders.Select(o => o.ID_Order).ToList();
            int maxID = postojeciKLjucevi.Count > 0 ? postojeciKLjucevi.Max() : 0;

            int kljuc = maxID + 1;

            return kljuc;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                double zbroj = 0;

                aktivnaNarudzba.ID_Order = GeneriranjeKljucaNarudzba(context);

                aktivnaNarudzba.status = "aktivna";
                foreach(Order_detail o in listaArtikalaZaNarudzbu)
                {
                    zbroj = zbroj + o.Cijena;
                                     
                }
                aktivnaNarudzba.Ukupna_Cijena = zbroj;
                context.Orders.Add(aktivnaNarudzba);
                context.SaveChanges();

                foreach (Order_detail o in listaArtikalaZaNarudzbu)
                {
                    o.ID_OrderDetails = GeneriranjeKljuca(context);
                    o.ID_Order = aktivnaNarudzba.ID_Order;
                    context.Order_details.Add(o);
                    context.SaveChanges();
                }

                foreach (Artikli row in context.Artiklis)
                {
                    var brojacArtikla = row.Dostupno_Komada;
                    foreach (Order_detail stavka in listaArtikalaZaNarudzbu)
                    {
                        if (stavka.Naziv_Pica == row.Naziv_Pica)
                        {
                            brojacArtikla -= 1;
                        }
                    }
                    context.Artiklis.Attach(row);
                    row.Dostupno_Komada = brojacArtikla;
                }
                context.SaveChanges();

                aktivnaNarudzba.ID_Order = GeneriranjeKljucaNarudzba(context);
                dgvOdabranaPica.DataSource = null;

                var query = from p in context.Artiklis
                            select p;
                dgvArtikli.DataSource = query.ToList();
            }
        }

        private void btnRezervirajStol_Click(object sender, EventArgs e)
        {
            frmRezervacijaStola forma = new frmRezervacijaStola();
            forma.ShowDialog();
        }

        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                Artikli selectedArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikli;
                ProvjeraKolicine(selectedArtikl);
            }
        }
    }
}
