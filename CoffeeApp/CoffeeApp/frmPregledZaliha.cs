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
    public partial class frmPregledZaliha : Form
    {
        public frmPregledZaliha()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPregledZaliha_Load(object sender, EventArgs e)
        {
            DohvatiKatalogPica();
        }

        public void DohvatiKatalogPica()
        {
            using (var context = new PI2313_DBEntities8())
            {
                var query = from p in context.Katalog_Pica
                            select p;
                dgvUpravljajKatalogom.DataSource = query.ToList();

                dgvUpravljajKatalogom.Columns["ID_Pica"].Visible = false;
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities8())
            {
                Katalog_Pica selektiranoPice = dgvUpravljajKatalogom.CurrentRow.DataBoundItem as Katalog_Pica;
                context.Katalog_Pica.Attach(selektiranoPice);
                context.Katalog_Pica.Remove(selektiranoPice);
                context.SaveChanges();
                DohvatiKatalogPica();
            }
        }

        private void btnUrediPice_Click(object sender, EventArgs e)
        {
            Katalog_Pica selektiranoPice = dgvUpravljajKatalogom.CurrentRow.DataBoundItem as Katalog_Pica;
            frmIzmjenaPica forma = new frmIzmjenaPica(selektiranoPice);
            forma.ShowDialog();
            DohvatiKatalogPica();
        }

        private void btnDodajPice_Click(object sender, EventArgs e)
        {
            frmDodajPice forma = new frmDodajPice();
            forma.ShowDialog();
        }
    }
}
