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
    public partial class frmDodajPice : Form
    {
        public frmDodajPice()
        {
            InitializeComponent();
        }

        RepozitorijPica odabranoPice = new RepozitorijPica();

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naziv = txtbNaziv.Text;
            double cijena = double.Parse(txtbCijena.Text);
            string kolicina = txtbKolicina.Text;

            odabranoPice.DodajPice(naziv, cijena, kolicina);
            Close();
        }

        private void frmDodajPice_Load(object sender, EventArgs e)
        {

        }
    }
}
