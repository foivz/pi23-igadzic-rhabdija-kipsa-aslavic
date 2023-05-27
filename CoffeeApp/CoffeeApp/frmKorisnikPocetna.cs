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
        }
        

        public void DohvatiArtikle()
        {
            using (var context = new PI2313_DBEntities11())
            {
                var query = from p in context.Artiklis
                            select p;
                dgvArtikli.DataSource = query.ToList();

                dgvArtikli.Columns["ID_Pica"].Visible = false;
                dgvArtikli.Columns["Order_details"].Visible = false;
            }
        }
    }
}
