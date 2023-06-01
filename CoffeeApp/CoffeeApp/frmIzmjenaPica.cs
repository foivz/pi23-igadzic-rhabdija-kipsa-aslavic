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
    public partial class frmIzmjenaPica : Form
    {
        public frmIzmjenaPica(Artikli odabranoPice)
        {
            InitializeComponent();
            this.pice = odabranoPice;
        }
        public Artikli pice;

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using(var context = new PI2313_DBEntities13())
            {
                string nazivPica = txtbNaziv.Text;
                double cijenaPica = double.Parse(txtbCijena.Text);
                string kolicinaPica = txtbKolicina.Text;

                context.Artiklis.Attach(pice);
                pice.Naziv_Pica = nazivPica;
                pice.Cijena = cijenaPica;
                pice.Kolicina = kolicinaPica;
                context.SaveChanges();
            }
            Close();
        }

        private void frmIzmjenaPica_Load(object sender, EventArgs e)
        {
            txtbNaziv.Text = pice.Naziv_Pica;
            txtbCijena.Text = pice.Cijena.ToString();
            txtbKolicina.Text = pice.Kolicina;
        }
    }
}
