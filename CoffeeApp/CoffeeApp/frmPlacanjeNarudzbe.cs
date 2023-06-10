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
    public partial class frmPlacanjeNarudzbe : Form
    {
        public frmPlacanjeNarudzbe()
        {
            InitializeComponent();
        }

        private void frmPlacanjeNarudzbe_Load(object sender, EventArgs e)
        {
            DohvatiNarudzbe();
            DohvatiArtikle();
        }

        public void DohvatiNarudzbe()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Orders
                            select p;
                dgvNarudzbe.DataSource = query.ToList();

                dgvNarudzbe.Columns["ID_Order"].Visible = false;
                dgvNarudzbe.Columns["ID_korisnika"].Visible = false;
                dgvNarudzbe.Columns["Order_details"].Visible = false;
                dgvNarudzbe.Columns["Korisnik"].Visible = false;

            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlatiNarudzbu_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Order odabranaNarudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Order;
                
                context.Orders.Attach(odabranaNarudzba);
                odabranaNarudzba.status = "placeno";              
                context.SaveChanges();
            }
            DohvatiNarudzbe();           
        }

        private void dgvNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            Order odabranaNarudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Order;
            if(odabranaNarudzba.status == "placeno")
            {
                btnPlatiNarudzbu.Enabled = false;
            }
            else
            {
                btnPlatiNarudzbu.Enabled=true;
            }
            DohvatiArtikle();
        }

        public void DohvatiArtikle()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Order_details
                            select p;
                dgvArtikli.DataSource = query.ToList();

                dgvArtikli.Columns["ID_OrderDetails"].Visible = false;
                dgvArtikli.Columns["ID_Order"].Visible = false;
                dgvArtikli.Columns["ID_Pica"].Visible = false;
                dgvArtikli.Columns["Artikli"].Visible = false;
                dgvArtikli.Columns["Order"].Visible = false;


                if (dgvNarudzbe.SelectedRows.Count > 0) { 
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvArtikli.DataSource];
                currencyManager1.SuspendBinding();

                foreach (DataGridViewRow row in dgvArtikli.Rows)
                {
                    if (row.Cells["ID_Order"].Value.ToString() != (dgvNarudzbe.CurrentRow.DataBoundItem as Order).ID_Order.ToString())
                    {
                        row.Visible = false;
                    }
                }
                currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
