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
    public partial class frmDogadaji : Form
    {
        public frmDogadaji()
        {
            InitializeComponent();
        }

        private void frmDogadaji_Load(object sender, EventArgs e)
        {
            DohvatiDogadaje();
        }

        public void DohvatiDogadaje()
        {
            using(var context = new PI2313_DBEntities13())
            {
                var query = from d in context.Dogadajs
                            select d;

                dgvDogadaji.DataSource = query.ToList();

                dgvDogadaji.Columns["ID_Administratora"].Visible = false;
                dgvDogadaji.Columns["Kartas"].Visible = false;
                dgvDogadaji.Columns["Korisnik"].Visible = false;

               
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajDogadaj_Click(object sender, EventArgs e)
        {
            frmNoviDogadaj form = new frmNoviDogadaj();
            form.ShowDialog();
            DohvatiDogadaje();
        }
    }
}
