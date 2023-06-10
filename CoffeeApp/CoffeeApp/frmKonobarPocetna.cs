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
    public partial class frmKonobarPocetna : Form
    {
        public frmKonobarPocetna()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlacanjeNarudzbe_Click(object sender, EventArgs e)
        {
            frmPlacanjeNarudzbe forma = new frmPlacanjeNarudzbe();
            forma.ShowDialog();
        }
    }
}
